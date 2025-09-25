using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactsApplicationWinForms
{
    public partial class USAddAndUpdateContact : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;
        private int _ContactID;
        private clsContact _Contact;

        public USAddAndUpdateContact(int contactID = -1)
        {
            InitializeComponent();
            LoadCountries();

            if (contactID == -1)
            {
                // --- ADD NEW MODE ---
                _Mode = enMode.AddNew;
                _Contact = new clsContact();
                _ContactID = -1;

                TitleOFAddUpdateUC.Text = "Add New Contact";
                lblContactID.Text = "Unknown";
                btnDeleteImage.Visible = false;
            }
            else
            {
                // --- UPDATE MODE ---
                _Mode = enMode.Update;
                _ContactID = contactID;
                _Contact = clsContact.Find(contactID);

                if (_Contact == null)
                {
                    MessageBox.Show("This form will close because the contact does not exist.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    return;
                }

                ImplementUpdateMenu(_Contact);
            }
        }

        private void LoadCountries()
        {
            DataTable dtCountries = clsCountry.GetAllCountries(); // must return ID + Name columns

            cbCountries.DataSource = dtCountries;
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
            cbCountries.SelectedIndex = -1; // nothing selected initially
        }

        private void ImplementUpdateMenu(clsContact contact)
        {
            TitleOFAddUpdateUC.Text = "Update Contact";

            lblContactID.Text = contact.ID.ToString();
            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            txtPhone.Text = contact.Phone;
            txtEmail.Text = contact.Email;
            txtAddress.Text = contact.Address;
            dtBirthDate.Value = contact.DateOfBirth;
            cbCountries.SelectedValue = contact.CountryID;

            if (!string.IsNullOrEmpty(contact.ImagePath) && File.Exists(contact.ImagePath))
            {
                pbContactPic.Image = Image.FromFile(contact.ImagePath);
                pbContactPic.SizeMode = PictureBoxSizeMode.Zoom;
                pbContactPic.Tag = contact.ImagePath;
                btnDeleteImage.Visible = true;
            }
            else
            {
                pbContactPic.Image = null; // fallback (optional: load a default image)
                btnDeleteImage.Visible = false;
            }
        }

        private void ImplementGivenDataToContact()
        {
            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.DateOfBirth = dtBirthDate.Value;
            _Contact.CountryID = (int)cbCountries.SelectedValue;

            // Image
            _Contact.ImagePath = pbContactPic.Tag?.ToString() ?? "";
        }

        private void SetNewImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Contact Picture";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbContactPic.Image = Image.FromFile(ofd.FileName);
                    pbContactPic.SizeMode = PictureBoxSizeMode.Zoom;
                    pbContactPic.Tag = ofd.FileName;

                    btnDeleteImage.Visible = true;
                }
            }
        }

        private void DeleteExistedImage()
        {
            pbContactPic.Image = null; // optional: set a default image
            pbContactPic.Tag = null;
            btnDeleteImage.Visible = false;
        }

        // ======================
        // EVENT HANDLERS
        // ======================
        private void btnSetImage_Click(object sender, EventArgs e)
        {
            SetNewImage();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            DeleteExistedImage();
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            ImplementGivenDataToContact();

            bool success = _Contact.Save(); // Save handles Add/Update internally

            if (success)
            {
                string msg = (_Mode == enMode.AddNew)
                    ? "Contact added successfully."
                    : "Contact updated successfully.";

                MessageBox.Show(msg, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to show all contacts (optional)
               // UCShowAllContacts showContactUC = new UCShowAllContacts();
               // showContactUC.Show();
               
            }
            else
            {
                MessageBox.Show("Oops, something went wrong.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
