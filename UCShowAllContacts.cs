using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactsApplicationWinForms
{
    public partial class UCShowAllContacts : UserControl
    {
        public UCShowAllContacts()
        {
            InitializeComponent();
            _RefrechContacts();

        }

        private void _RefrechContacts()
        {
            dgvContacts.DataSource = clsContact.GetAllContacts();
        }

        public void RefreshContacts()
        {
            _RefrechContacts();
        }

        private void MainMenueTitle_Click(object sender, EventArgs e)
        {

        }

        private void UCShowAllContacts_Load(object sender, EventArgs e)
        {
            _RefrechContacts();
        }

        // To Update
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null) return;

            int contactID = (int)dgvContacts.CurrentRow.Cells[0].Value;

            // Wrap UC inside a dialog form
            using (Form frm = new Form())
            {
                frm.Text = "Update Contact";
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Size = new Size(600, 500);

                var ucUpdate = new USAddAndUpdateContact(contactID);
                ucUpdate.Dock = DockStyle.Fill;

                // IMPORTANT: when Save is successful, set DialogResult = OK inside UC
                frm.Controls.Add(ucUpdate);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshContacts(); // reload grid after update
                }
            }
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null) return;

            int contactID = (int)dgvContacts.CurrentRow.Cells[0].Value;

            if (MessageBox.Show(
                  $"Are you sure you want to delete contact with ID {contactID}?",
                  "Confirm Delete",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsContact.DeleteContact(contactID))
                {
                    MessageBox.Show($"Contact {contactID} deleted successfully");
                }
                else
                {
                    MessageBox.Show($"Failed to delete contact {contactID}");
                }

                RefreshContacts();
            }

        }

        private void dgvContacts_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }
    }
}
