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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblProfilesDir = new System.Windows.Forms.Label();
            this.txtProfilesDir = new System.Windows.Forms.TextBox();
            this.btnBrowseProfilesDir = new System.Windows.Forms.Button();
            this.btnBrowseSavefileDir = new System.Windows.Forms.Button();
            this.txtSavefileDir = new System.Windows.Forms.TextBox();
            this.lblSavefileDir = new System.Windows.Forms.Label();
            this.grbSetup = new System.Windows.Forms.GroupBox();
            this.grbProfiles = new System.Windows.Forms.GroupBox();
            this.tsProfiles = new System.Windows.Forms.ToolStrip();
            this.tsbAddProfile = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteProfile = new System.Windows.Forms.ToolStripButton();
            this.tsbEditProfile = new System.Windows.Forms.ToolStripButton();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.grbSavestates = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbImportSavestate = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadSavestate = new System.Windows.Forms.ToolStripButton();
            this.trvSavestates = new System.Windows.Forms.TreeView();
            this.cmsSavestates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRenameSavestate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSavestate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProfiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRenameProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.picGear = new System.Windows.Forms.PictureBox();
            this.grbSetup.SuspendLayout();
            this.grbProfiles.SuspendLayout();
            this.tsProfiles.SuspendLayout();
            this.grbSavestates.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cmsSavestates.SuspendLayout();
            this.cmsProfiles.SuspendLayout();
            this.cmsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfilesDir
            // 
            this.lblProfilesDir.AutoSize = true;
            this.lblProfilesDir.Location = new System.Drawing.Point(6, 59);
            this.lblProfilesDir.Name = "lblProfilesDir";
            this.lblProfilesDir.Size = new System.Drawing.Size(89, 13);
            this.lblProfilesDir.TabIndex = 0;
            this.lblProfilesDir.Text = "Profiles Directory:";
            // 
            // txtProfilesDir
            // 
            this.txtProfilesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfilesDir.Location = new System.Drawing.Point(9, 75);
            this.txtProfilesDir.Name = "txtProfilesDir";
            this.txtProfilesDir.ReadOnly = true;
            this.txtProfilesDir.Size = new System.Drawing.Size(416, 20);
            this.txtProfilesDir.TabIndex = 1;
            // 
            // btnBrowseProfilesDir
            // 
            this.btnBrowseProfilesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProfilesDir.Location = new System.Drawing.Point(431, 73);
            this.btnBrowseProfilesDir.Name = "btnBrowseProfilesDir";
            this.btnBrowseProfilesDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseProfilesDir.TabIndex = 2;
            this.btnBrowseProfilesDir.Text = "Browse";
            this.btnBrowseProfilesDir.UseVisualStyleBackColor = true;
            this.btnBrowseProfilesDir.Click += new System.EventHandler(this.btnBrowseProfilesDir_Click);
            // 
            // btnBrowseSavefileDir
            // 
            this.btnBrowseSavefileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSavefileDir.Location = new System.Drawing.Point(431, 30);
            this.btnBrowseSavefileDir.Name = "btnBrowseSavefileDir";
            this.btnBrowseSavefileDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSavefileDir.TabIndex = 4;
            this.btnBrowseSavefileDir.Text = "Browse";
            this.btnBrowseSavefileDir.UseVisualStyleBackColor = true;
            this.btnBrowseSavefileDir.Click += new System.EventHandler(this.btnBrowseSavefileDir_Click);
            // 
            // txtSavefileDir
            // 
            this.txtSavefileDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavefileDir.Location = new System.Drawing.Point(9, 32);
            this.txtSavefileDir.Name = "txtSavefileDir";
            this.txtSavefileDir.ReadOnly = true;
            this.txtSavefileDir.Size = new System.Drawing.Size(416, 20);
            this.txtSavefileDir.TabIndex = 3;
            // 
            // lblSavefileDir
            // 
            this.lblSavefileDir.AutoSize = true;
            this.lblSavefileDir.Location = new System.Drawing.Point(6, 16);
            this.lblSavefileDir.Name = "lblSavefileDir";
            this.lblSavefileDir.Size = new System.Drawing.Size(93, 13);
            this.lblSavefileDir.TabIndex = 3;
            this.lblSavefileDir.Text = "Savefile Directory:";
            // 
            // grbSetup
            // 
            this.grbSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSetup.Controls.Add(this.lblProfilesDir);
            this.grbSetup.Controls.Add(this.txtProfilesDir);
            this.grbSetup.Controls.Add(this.btnBrowseProfilesDir);
            this.grbSetup.Controls.Add(this.txtSavefileDir);
            this.grbSetup.Controls.Add(this.btnBrowseSavefileDir);
            this.grbSetup.Controls.Add(this.lblSavefileDir);
            this.grbSetup.Location = new System.Drawing.Point(12, 12);
            this.grbSetup.Name = "grbSetup";
            this.grbSetup.Size = new System.Drawing.Size(512, 103);
            this.grbSetup.TabIndex = 0;
            this.grbSetup.TabStop = false;
            this.grbSetup.Text = "Setup";
            // 
            // grbProfiles
            // 
            this.grbProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbProfiles.Controls.Add(this.tsProfiles);
            this.grbProfiles.Controls.Add(this.lstProfiles);
            this.grbProfiles.Location = new System.Drawing.Point(12, 121);
            this.grbProfiles.Name = "grbProfiles";
            this.grbProfiles.Size = new System.Drawing.Size(160, 242);
            this.grbProfiles.TabIndex = 5;
            this.grbProfiles.TabStop = false;
            this.grbProfiles.Text = "Profiles";
            // 
            // tsProfiles
            // 
            this.tsProfiles.AutoSize = false;
            this.tsProfiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddProfile,
            this.tsbDeleteProfile,
            this.tsbEditProfile});
            this.tsProfiles.Location = new System.Drawing.Point(3, 16);
            this.tsProfiles.Name = "tsProfiles";
            this.tsProfiles.Size = new System.Drawing.Size(154, 25);
            this.tsProfiles.TabIndex = 8;
            this.tsProfiles.Text = "toolStrip1";
            // 
            // tsbAddProfile
            // 
            this.tsbAddProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddProfile.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddProfile.Image")));
            this.tsbAddProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddProfile.Name = "tsbAddProfile";
            this.tsbAddProfile.Size = new System.Drawing.Size(23, 22);
            this.tsbAddProfile.Text = "New Profile";
            this.tsbAddProfile.Click += new System.EventHandler(this.tsbAddProfile_Click);
            // 
            // tsbDeleteProfile
            // 
            this.tsbDeleteProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteProfile.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.minus_circle;
            this.tsbDeleteProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteProfile.Name = "tsbDeleteProfile";
            this.tsbDeleteProfile.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteProfile.Text = "Delete Profile";
            this.tsbDeleteProfile.Click += new System.EventHandler(this.tsbDeleteProfile_Click);
            // 
            // tsbEditProfile
            // 
            this.tsbEditProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditProfile.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.pencil;
            this.tsbEditProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditProfile.Name = "tsbEditProfile";
            this.tsbEditProfile.Size = new System.Drawing.Size(23, 22);
            this.tsbEditProfile.Text = "Edit Profile";
            this.tsbEditProfile.Click += new System.EventHandler(this.tsbEditProfile_Click);
            // 
            // lstProfiles
            // 
            this.lstProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.IntegralHeight = false;
            this.lstProfiles.Location = new System.Drawing.Point(6, 44);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(148, 192);
            this.lstProfiles.Sorted = true;
            this.lstProfiles.TabIndex = 7;
            this.lstProfiles.SelectedIndexChanged += new System.EventHandler(this.lstProfiles_SelectedIndexChanged);
            this.lstProfiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstProfiles_MouseUp);
            // 
            // grbSavestates
            // 
            this.grbSavestates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSavestates.Controls.Add(this.toolStrip1);
            this.grbSavestates.Controls.Add(this.trvSavestates);
            this.grbSavestates.Location = new System.Drawing.Point(178, 121);
            this.grbSavestates.Name = "grbSavestates";
            this.grbSavestates.Size = new System.Drawing.Size(346, 242);
            this.grbSavestates.TabIndex = 8;
            this.grbSavestates.TabStop = false;
            this.grbSavestates.Text = "Savestates";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImportSavestate,
            this.tsbLoadSavestate});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(340, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "tsSavestate";
            // 
            // tsbImportSavestate
            // 
            this.tsbImportSavestate.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.import;
            this.tsbImportSavestate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImportSavestate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.tsbImportSavestate.Name = "tsbImportSavestate";
            this.tsbImportSavestate.Size = new System.Drawing.Size(115, 22);
            this.tsbImportSavestate.Text = "Import Savestate";
            this.tsbImportSavestate.Click += new System.EventHandler(this.tsbImportSavestate_Click);
            // 
            // tsbLoadSavestate
            // 
            this.tsbLoadSavestate.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.load;
            this.tsbLoadSavestate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadSavestate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.tsbLoadSavestate.Name = "tsbLoadSavestate";
            this.tsbLoadSavestate.Size = new System.Drawing.Size(105, 22);
            this.tsbLoadSavestate.Text = "Load Savestate";
            this.tsbLoadSavestate.Click += new System.EventHandler(this.tsbLoadSavestate_Click);
            // 
            // trvSavestates
            // 
            this.trvSavestates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvSavestates.FullRowSelect = true;
            this.trvSavestates.HideSelection = false;
            this.trvSavestates.Location = new System.Drawing.Point(6, 44);
            this.trvSavestates.Name = "trvSavestates";
            this.trvSavestates.ShowLines = false;
            this.trvSavestates.ShowRootLines = false;
            this.trvSavestates.Size = new System.Drawing.Size(334, 192);
            this.trvSavestates.TabIndex = 11;
            this.trvSavestates.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trvSavestates_MouseUp);
            // 
            // cmsSavestates
            // 
            this.cmsSavestates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRenameSavestate,
            this.tsmiDeleteSavestate});
            this.cmsSavestates.Name = "cmsSavestates";
            this.cmsSavestates.Size = new System.Drawing.Size(137, 48);
            this.cmsSavestates.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSavestates_ItemClicked);
            // 
            // tsmiRenameSavestate
            // 
            this.tsmiRenameSavestate.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.pencil;
            this.tsmiRenameSavestate.Name = "tsmiRenameSavestate";
            this.tsmiRenameSavestate.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmiRenameSavestate.Size = new System.Drawing.Size(136, 22);
            this.tsmiRenameSavestate.Text = "Rename";
            // 
            // tsmiDeleteSavestate
            // 
            this.tsmiDeleteSavestate.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.minus_circle;
            this.tsmiDeleteSavestate.Name = "tsmiDeleteSavestate";
            this.tsmiDeleteSavestate.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDeleteSavestate.Size = new System.Drawing.Size(136, 22);
            this.tsmiDeleteSavestate.Text = "Delete";
            // 
            // cmsProfiles
            // 
            this.cmsProfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRenameProfile,
            this.tsmiDeleteProfile});
            this.cmsProfiles.Name = "cmsSavestates";
            this.cmsProfiles.Size = new System.Drawing.Size(181, 70);
            this.cmsProfiles.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.csmProfiles_ItemClicked);
            // 
            // tsmiRenameProfile
            // 
            this.tsmiRenameProfile.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.pencil;
            this.tsmiRenameProfile.Name = "tsmiRenameProfile";
            this.tsmiRenameProfile.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmiRenameProfile.Size = new System.Drawing.Size(180, 22);
            this.tsmiRenameProfile.Text = "Rename";
            // 
            // tsmiDeleteProfile
            // 
            this.tsmiDeleteProfile.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.minus_circle;
            this.tsmiDeleteProfile.Name = "tsmiDeleteProfile";
            this.tsmiDeleteProfile.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDeleteProfile.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeleteProfile.Text = "Delete";
            // 
            // cmsSettings
            // 
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiHelp});
            this.cmsSettings.Name = "cmsSettings";
            this.cmsSettings.Size = new System.Drawing.Size(119, 48);
            this.cmsSettings.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSettings_ItemClicked);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(118, 22);
            this.tsmiAbout.Text = "About";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiHelp.Size = new System.Drawing.Size(118, 22);
            this.tsmiHelp.Text = "Help";
            // 
            // picGear
            // 
            this.picGear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picGear.Image = ((System.Drawing.Image)(resources.GetObject("picGear.Image")));
            this.picGear.Location = new System.Drawing.Point(503, 364);
            this.picGear.Name = "picGear";
            this.picGear.Size = new System.Drawing.Size(28, 28);
            this.picGear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGear.TabIndex = 9;
            this.picGear.TabStop = false;
            this.picGear.MouseEnter += new System.EventHandler(this.picGear_MouseEnter);
            this.picGear.MouseLeave += new System.EventHandler(this.picGear_MouseLeave);
            this.picGear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGear_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 397);
            this.Controls.Add(this.picGear);
            this.Controls.Add(this.grbSavestates);
            this.Controls.Add(this.grbProfiles);
            this.Controls.Add(this.grbSetup);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(503, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demon\'s Souls Save Organizer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.grbSetup.ResumeLayout(false);
            this.grbSetup.PerformLayout();
            this.grbProfiles.ResumeLayout(false);
            this.tsProfiles.ResumeLayout(false);
            this.tsProfiles.PerformLayout();
            this.grbSavestates.ResumeLayout(false);
            this.grbSavestates.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsSavestates.ResumeLayout(false);
            this.cmsProfiles.ResumeLayout(false);
            this.cmsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProfilesDir;
        private System.Windows.Forms.TextBox txtProfilesDir;
        private System.Windows.Forms.Button btnBrowseProfilesDir;
        private System.Windows.Forms.Button btnBrowseSavefileDir;
        private System.Windows.Forms.TextBox txtSavefileDir;
        private System.Windows.Forms.Label lblSavefileDir;
        private System.Windows.Forms.GroupBox grbSetup;
        private System.Windows.Forms.GroupBox grbProfiles;
        private System.Windows.Forms.GroupBox grbSavestates;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.TreeView trvSavestates;
        private System.Windows.Forms.ContextMenuStrip cmsSavestates;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenameSavestate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSavestate;
        private System.Windows.Forms.ContextMenuStrip cmsProfiles;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenameProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteProfile;
        private System.Windows.Forms.PictureBox picGear;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStrip tsProfiles;
        private System.Windows.Forms.ToolStripButton tsbAddProfile;
        private System.Windows.Forms.ToolStripButton tsbDeleteProfile;
        private System.Windows.Forms.ToolStripButton tsbEditProfile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbImportSavestate;
        private System.Windows.Forms.ToolStripButton tsbLoadSavestate;
    }
}

