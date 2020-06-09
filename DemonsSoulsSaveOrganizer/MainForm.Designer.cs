namespace DemonsSoulsSaveOrganizer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblProfilesDir = new System.Windows.Forms.Label();
            this.txtProfilesDir = new System.Windows.Forms.TextBox();
            this.btnBrowseProfilesDir = new System.Windows.Forms.Button();
            this.btnBrowseSavefileDir = new System.Windows.Forms.Button();
            this.txtSavefileDir = new System.Windows.Forms.TextBox();
            this.lblSavefileDir = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadSavestate = new System.Windows.Forms.Button();
            this.btnImportSavestate = new System.Windows.Forms.Button();
            this.trvSavestates = new System.Windows.Forms.TreeView();
            this.hlkAbout = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfilesDir
            // 
            this.lblProfilesDir.AutoSize = true;
            this.lblProfilesDir.Location = new System.Drawing.Point(6, 16);
            this.lblProfilesDir.Name = "lblProfilesDir";
            this.lblProfilesDir.Size = new System.Drawing.Size(89, 13);
            this.lblProfilesDir.TabIndex = 0;
            this.lblProfilesDir.Text = "Profiles Directory:";
            // 
            // txtProfilesDir
            // 
            this.txtProfilesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfilesDir.Location = new System.Drawing.Point(9, 32);
            this.txtProfilesDir.Name = "txtProfilesDir";
            this.txtProfilesDir.ReadOnly = true;
            this.txtProfilesDir.Size = new System.Drawing.Size(512, 20);
            this.txtProfilesDir.TabIndex = 1;
            // 
            // btnBrowseProfilesDir
            // 
            this.btnBrowseProfilesDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseProfilesDir.Location = new System.Drawing.Point(527, 30);
            this.btnBrowseProfilesDir.Name = "btnBrowseProfilesDir";
            this.btnBrowseProfilesDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseProfilesDir.TabIndex = 2;
            this.btnBrowseProfilesDir.Text = "Browse";
            this.btnBrowseProfilesDir.UseVisualStyleBackColor = true;
            this.btnBrowseProfilesDir.Click += new System.EventHandler(this.btnBrowseProfilesDir_Click);
            // 
            // btnBrowseSavefileDir
            // 
            this.btnBrowseSavefileDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseSavefileDir.Location = new System.Drawing.Point(527, 69);
            this.btnBrowseSavefileDir.Name = "btnBrowseSavefileDir";
            this.btnBrowseSavefileDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSavefileDir.TabIndex = 5;
            this.btnBrowseSavefileDir.Text = "Browse";
            this.btnBrowseSavefileDir.UseVisualStyleBackColor = true;
            this.btnBrowseSavefileDir.Click += new System.EventHandler(this.btnBrowseSavefileDir_Click);
            // 
            // txtSavefileDir
            // 
            this.txtSavefileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavefileDir.Location = new System.Drawing.Point(9, 71);
            this.txtSavefileDir.Name = "txtSavefileDir";
            this.txtSavefileDir.ReadOnly = true;
            this.txtSavefileDir.Size = new System.Drawing.Size(512, 20);
            this.txtSavefileDir.TabIndex = 4;
            // 
            // lblSavefileDir
            // 
            this.lblSavefileDir.AutoSize = true;
            this.lblSavefileDir.Location = new System.Drawing.Point(6, 55);
            this.lblSavefileDir.Name = "lblSavefileDir";
            this.lblSavefileDir.Size = new System.Drawing.Size(93, 13);
            this.lblSavefileDir.TabIndex = 3;
            this.lblSavefileDir.Text = "Savefile Directory:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblProfilesDir);
            this.groupBox1.Controls.Add(this.txtProfilesDir);
            this.groupBox1.Controls.Add(this.btnBrowseProfilesDir);
            this.groupBox1.Controls.Add(this.txtSavefileDir);
            this.groupBox1.Controls.Add(this.btnBrowseSavefileDir);
            this.groupBox1.Controls.Add(this.lblSavefileDir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lstProfiles);
            this.groupBox2.Controls.Add(this.btnDeleteProfile);
            this.groupBox2.Controls.Add(this.btnEditProfile);
            this.groupBox2.Controls.Add(this.btnAddProfile);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 296);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profiles";
            // 
            // lstProfiles
            // 
            this.lstProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.IntegralHeight = false;
            this.lstProfiles.Location = new System.Drawing.Point(67, 19);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(133, 271);
            this.lstProfiles.TabIndex = 4;
            this.lstProfiles.SelectedIndexChanged += new System.EventHandler(this.lstProfiles_SelectedIndexChanged);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(6, 77);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(55, 23);
            this.btnDeleteProfile.TabIndex = 3;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(6, 48);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(55, 23);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Location = new System.Drawing.Point(6, 19);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(55, 23);
            this.btnAddProfile.TabIndex = 1;
            this.btnAddProfile.Text = "New";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnLoadSavestate);
            this.groupBox3.Controls.Add(this.btnImportSavestate);
            this.groupBox3.Controls.Add(this.trvSavestates);
            this.groupBox3.Location = new System.Drawing.Point(224, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 296);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Savestates";
            // 
            // btnLoadSavestate
            // 
            this.btnLoadSavestate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadSavestate.Location = new System.Drawing.Point(145, 267);
            this.btnLoadSavestate.Name = "btnLoadSavestate";
            this.btnLoadSavestate.Size = new System.Drawing.Size(133, 23);
            this.btnLoadSavestate.TabIndex = 2;
            this.btnLoadSavestate.Text = "Load Savestate";
            this.btnLoadSavestate.UseVisualStyleBackColor = true;
            this.btnLoadSavestate.Click += new System.EventHandler(this.btnLoadSavestate_Click);
            // 
            // btnImportSavestate
            // 
            this.btnImportSavestate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportSavestate.Location = new System.Drawing.Point(6, 267);
            this.btnImportSavestate.Name = "btnImportSavestate";
            this.btnImportSavestate.Size = new System.Drawing.Size(133, 23);
            this.btnImportSavestate.TabIndex = 1;
            this.btnImportSavestate.Text = "Import Savestate";
            this.btnImportSavestate.UseVisualStyleBackColor = true;
            this.btnImportSavestate.Click += new System.EventHandler(this.btnImportSavestate_Click);
            // 
            // trvSavestates
            // 
            this.trvSavestates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvSavestates.Location = new System.Drawing.Point(6, 19);
            this.trvSavestates.Name = "trvSavestates";
            this.trvSavestates.Size = new System.Drawing.Size(384, 242);
            this.trvSavestates.TabIndex = 0;
            // 
            // hlkAbout
            // 
            this.hlkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hlkAbout.AutoSize = true;
            this.hlkAbout.Location = new System.Drawing.Point(585, 417);
            this.hlkAbout.Name = "hlkAbout";
            this.hlkAbout.Size = new System.Drawing.Size(35, 13);
            this.hlkAbout.TabIndex = 3;
            this.hlkAbout.TabStop = true;
            this.hlkAbout.Text = "About";
            this.hlkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hlkAbout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 439);
            this.Controls.Add(this.hlkAbout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(536, 287);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demon\'s Souls Save Organizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfilesDir;
        private System.Windows.Forms.TextBox txtProfilesDir;
        private System.Windows.Forms.Button btnBrowseProfilesDir;
        private System.Windows.Forms.Button btnBrowseSavefileDir;
        private System.Windows.Forms.TextBox txtSavefileDir;
        private System.Windows.Forms.Label lblSavefileDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.TreeView trvSavestates;
        private System.Windows.Forms.Button btnLoadSavestate;
        private System.Windows.Forms.Button btnImportSavestate;
        private System.Windows.Forms.LinkLabel hlkAbout;
    }
}

