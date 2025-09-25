using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApplicationWinForms
{
    public partial class FormMainMenue : Form
    {
        // Fields
        private int _currentContactID = -1;

        // UserControls
        private UCShowAllContacts _uCShowAllContacts;
        private USAddAndUpdateContact _addNewContactUC;
        private USAddAndUpdateContact _updateContactUC;

        public FormMainMenue()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        // 🔹 Initialize UserControls
        private void InitializeUserControls()
        {
            _uCShowAllContacts = new UCShowAllContacts();
            _addNewContactUC = new USAddAndUpdateContact(-1);

            // Add them to form (UpdateContact will be created later)
            PNLContainer.Controls.Add(_uCShowAllContacts);
            PNLContainer.Controls.Add(_addNewContactUC);

            // Dock for full view
            _uCShowAllContacts.Dock = DockStyle.Fill;
            _addNewContactUC.Dock = DockStyle.Fill;

            // Default view
            ShowControl(_uCShowAllContacts);
        }

        // 🔹 Utility: Show only one control at a time
        private void ShowControl(UserControl controlToShow)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is UserControl)
                    ctrl.Hide();
            }
            controlToShow.Show();
            controlToShow.BringToFront();

            if (controlToShow is UCShowAllContacts contactsUC)
            {
                contactsUC.RefreshContacts(); // reload latest data
            }

        }

        // 🔹 Utility: Move side panel
        private void ShowSidePanelInPosition(int pos)
        {
            switch (pos)
            {
                case 1:
                    SidePNL.Location = new Point(12, 134);
                    SidePNL.Visible = true;               // make sure it's visible
                    SidePNL.BringToFront();               // bring above other controls
                    break;
                case 2:
                    SidePNL.Location = new Point(12, 223);
                    SidePNL.Visible = true;               // make sure it's visible
                    SidePNL.BringToFront();
                    break;
                case 3:
                    SidePNL.Location = new Point(12, 312);
                    SidePNL.Visible = true;               // make sure it's visible
                    SidePNL.BringToFront();
                    break;
                default: SidePNL.Location = new Point(12, 134);
                    SidePNL.Visible = true;               // make sure it's visible
                    SidePNL.BringToFront();
                    break;
            }
        }

        // ===============================
        // 🔹 Button Events
        // ===============================

        private void btnShowContacts_Click(object sender, EventArgs e)
        {
            ShowSidePanelInPosition(1);
            ShowControl(_uCShowAllContacts);
            
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            ShowSidePanelInPosition(2);
            ShowControl(_addNewContactUC);
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            ShowSidePanelInPosition(3);
            PNLContainer.Controls.Add(pnlAskAboutContactID);
            pnlAskAboutContactID.BringToFront();
            pnlAskAboutContactID.Visible = true;
            pnlAskAboutContactID.Dock = DockStyle.Fill;
        }

        private void btnFindContact_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContactID.Text))
            {
                pnlAskAboutContactID.Hide();
                _currentContactID = int.Parse(txtContactID.Text);

                // Recreate update control with the correct ID
                if (_updateContactUC != null)
                    this.Controls.Remove(_updateContactUC);

                _updateContactUC = new USAddAndUpdateContact(_currentContactID);
                _updateContactUC.Dock = DockStyle.Fill;
                this.Controls.Add(_updateContactUC);

                ShowControl(_updateContactUC);
            }
            else
            {
                MessageBox.Show("Please Enter Contact ID ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMainMenue_Load(object sender, EventArgs e)
        {

        }
    }

}
