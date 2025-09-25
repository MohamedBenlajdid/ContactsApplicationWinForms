namespace ContactsApplicationWinForms
{
    partial class UCShowAllContacts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.MainMenueTitle = new System.Windows.Forms.Label();
            this.CMSUpdateDeleteContact = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.CMSUpdateDeleteContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContacts
            // 
            this.dgvContacts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.ContextMenuStrip = this.CMSUpdateDeleteContact;
            this.dgvContacts.Location = new System.Drawing.Point(0, 41);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(628, 318);
            this.dgvContacts.TabIndex = 0;
            this.dgvContacts.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvContacts_CellContextMenuStripNeeded);
            // 
            // MainMenueTitle
            // 
            this.MainMenueTitle.AutoSize = true;
            this.MainMenueTitle.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenueTitle.Location = new System.Drawing.Point(194, 0);
            this.MainMenueTitle.Name = "MainMenueTitle";
            this.MainMenueTitle.Size = new System.Drawing.Size(213, 38);
            this.MainMenueTitle.TabIndex = 1;
            this.MainMenueTitle.Text = "You Contact  : ";
            this.MainMenueTitle.Click += new System.EventHandler(this.MainMenueTitle_Click);
            // 
            // CMSUpdateDeleteContact
            // 
            this.CMSUpdateDeleteContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CMSUpdateDeleteContact.Name = "CMSUpdateDeleteContact";
            this.CMSUpdateDeleteContact.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSUpdateDeleteContact.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // UCShowAllContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.MainMenueTitle);
            this.Controls.Add(this.dgvContacts);
            this.Name = "UCShowAllContacts";
            this.Size = new System.Drawing.Size(628, 359);
            this.Load += new System.EventHandler(this.UCShowAllContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.CMSUpdateDeleteContact.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Label MainMenueTitle;
        private System.Windows.Forms.ContextMenuStrip CMSUpdateDeleteContact;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
