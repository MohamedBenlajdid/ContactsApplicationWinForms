namespace ContactsApplicationWinForms
{
    partial class FormMainMenue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenue));
            this.MainMenueTitle = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnAddNewContact = new System.Windows.Forms.Button();
            this.SidePNL = new System.Windows.Forms.Panel();
            this.btnMainMenue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAskAboutContactID = new System.Windows.Forms.Panel();
            this.btnFindContact = new System.Windows.Forms.Button();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.TitleOFAddUpdateUC = new System.Windows.Forms.Label();
            this.PNLContainer = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAskAboutContactID.SuspendLayout();
            this.PNLContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenueTitle
            // 
            this.MainMenueTitle.AutoSize = true;
            this.MainMenueTitle.Font = new System.Drawing.Font("Urdu Typesetting", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenueTitle.Location = new System.Drawing.Point(234, 0);
            this.MainMenueTitle.Name = "MainMenueTitle";
            this.MainMenueTitle.Size = new System.Drawing.Size(428, 53);
            this.MainMenueTitle.TabIndex = 0;
            this.MainMenueTitle.Text = "Manage You Contact World Easly";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SidePanel.Controls.Add(this.btnUpdateContact);
            this.SidePanel.Controls.Add(this.btnAddNewContact);
            this.SidePanel.Controls.Add(this.SidePNL);
            this.SidePanel.Controls.Add(this.btnMainMenue);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(155, 450);
            this.SidePanel.TabIndex = 1;
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.FlatAppearance.BorderSize = 0;
            this.btnUpdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContact.Location = new System.Drawing.Point(0, 312);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(155, 83);
            this.btnUpdateContact.TabIndex = 4;
            this.btnUpdateContact.Text = "UpdateContact";
            this.btnUpdateContact.UseVisualStyleBackColor = true;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnAddNewContact
            // 
            this.btnAddNewContact.FlatAppearance.BorderSize = 0;
            this.btnAddNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewContact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContact.Location = new System.Drawing.Point(0, 223);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.Size = new System.Drawing.Size(155, 83);
            this.btnAddNewContact.TabIndex = 4;
            this.btnAddNewContact.Text = "Add Contact";
            this.btnAddNewContact.UseVisualStyleBackColor = true;
            this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // SidePNL
            // 
            this.SidePNL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SidePNL.Location = new System.Drawing.Point(12, 134);
            this.SidePNL.Name = "SidePNL";
            this.SidePNL.Size = new System.Drawing.Size(10, 83);
            this.SidePNL.TabIndex = 2;
            // 
            // btnMainMenue
            // 
            this.btnMainMenue.FlatAppearance.BorderSize = 0;
            this.btnMainMenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenue.Location = new System.Drawing.Point(0, 134);
            this.btnMainMenue.Name = "btnMainMenue";
            this.btnMainMenue.Size = new System.Drawing.Size(155, 83);
            this.btnMainMenue.TabIndex = 3;
            this.btnMainMenue.Text = "Main Menue";
            this.btnMainMenue.UseVisualStyleBackColor = true;
            this.btnMainMenue.Click += new System.EventHandler(this.btnShowContacts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAskAboutContactID
            // 
            this.pnlAskAboutContactID.Controls.Add(this.btnFindContact);
            this.pnlAskAboutContactID.Controls.Add(this.txtContactID);
            this.pnlAskAboutContactID.Controls.Add(this.TitleOFAddUpdateUC);
            this.pnlAskAboutContactID.Location = new System.Drawing.Point(0, 3);
            this.pnlAskAboutContactID.Name = "pnlAskAboutContactID";
            this.pnlAskAboutContactID.Size = new System.Drawing.Size(645, 391);
            this.pnlAskAboutContactID.TabIndex = 3;
            // 
            // btnFindContact
            // 
            this.btnFindContact.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFindContact.FlatAppearance.BorderSize = 0;
            this.btnFindContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindContact.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindContact.Location = new System.Drawing.Point(215, 230);
            this.btnFindContact.Name = "btnFindContact";
            this.btnFindContact.Size = new System.Drawing.Size(165, 37);
            this.btnFindContact.TabIndex = 25;
            this.btnFindContact.Text = "Find Contact";
            this.btnFindContact.UseVisualStyleBackColor = false;
            this.btnFindContact.Click += new System.EventHandler(this.btnFindContact_Click);
            // 
            // txtContactID
            // 
            this.txtContactID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactID.Location = new System.Drawing.Point(244, 154);
            this.txtContactID.MaxLength = 100;
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(112, 32);
            this.txtContactID.TabIndex = 4;
            // 
            // TitleOFAddUpdateUC
            // 
            this.TitleOFAddUpdateUC.AutoSize = true;
            this.TitleOFAddUpdateUC.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleOFAddUpdateUC.Location = new System.Drawing.Point(131, 75);
            this.TitleOFAddUpdateUC.Name = "TitleOFAddUpdateUC";
            this.TitleOFAddUpdateUC.Size = new System.Drawing.Size(322, 38);
            this.TitleOFAddUpdateUC.TabIndex = 3;
            this.TitleOFAddUpdateUC.Text = "Please Enter Contact ID";
            // 
            // PNLContainer
            // 
            this.PNLContainer.Controls.Add(this.pnlAskAboutContactID);
            this.PNLContainer.Location = new System.Drawing.Point(154, 56);
            this.PNLContainer.Name = "PNLContainer";
            this.PNLContainer.Size = new System.Drawing.Size(645, 393);
            this.PNLContainer.TabIndex = 4;
            // 
            // FormMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNLContainer);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.MainMenueTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsSystem";
            this.Load += new System.EventHandler(this.FormMainMenue_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAskAboutContactID.ResumeLayout(false);
            this.pnlAskAboutContactID.PerformLayout();
            this.PNLContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenueTitle;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnMainMenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnAddNewContact;
        private System.Windows.Forms.Panel SidePNL;
        private System.Windows.Forms.Panel pnlAskAboutContactID;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Label TitleOFAddUpdateUC;
        private System.Windows.Forms.Button btnFindContact;
        private System.Windows.Forms.Panel PNLContainer;
    }
}

