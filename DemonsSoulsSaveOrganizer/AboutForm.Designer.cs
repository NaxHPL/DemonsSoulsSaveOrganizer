namespace DemonsSoulsSaveOrganizer {
    partial class AboutForm {
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblVersion = new System.Windows.Forms.Label();
            this.hlkDeveloper = new System.Windows.Forms.LinkLabel();
            this.hlkGithubRepository = new System.Windows.Forms.LinkLabel();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(153, 13);
            label1.TabIndex = 0;
            label1.Text = "Demon\'s Souls Save Organizer";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 1;
            label2.Text = "Version:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(12, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 13);
            label3.TabIndex = 3;
            label3.Text = "Developed by:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(12, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 13);
            label4.TabIndex = 6;
            label4.Text = "Source code:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 51);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(22, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "0.0";
            // 
            // hlkDeveloper
            // 
            this.hlkDeveloper.AutoSize = true;
            this.hlkDeveloper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hlkDeveloper.Location = new System.Drawing.Point(39, 92);
            this.hlkDeveloper.Name = "hlkDeveloper";
            this.hlkDeveloper.Size = new System.Drawing.Size(47, 13);
            this.hlkDeveloper.TabIndex = 4;
            this.hlkDeveloper.TabStop = true;
            this.hlkDeveloper.Text = "NaxHPL";
            this.hlkDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hlkDeveloper_LinkClicked);
            // 
            // hlkGithubRepository
            // 
            this.hlkGithubRepository.AutoSize = true;
            this.hlkGithubRepository.Location = new System.Drawing.Point(39, 142);
            this.hlkGithubRepository.Name = "hlkGithubRepository";
            this.hlkGithubRepository.Size = new System.Drawing.Size(86, 13);
            this.hlkGithubRepository.TabIndex = 5;
            this.hlkGithubRepository.TabStop = true;
            this.hlkGithubRepository.Text = "Github repository";
            this.hlkGithubRepository.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hlkGithubRepository_LinkClicked);
            // 
            // picTwitter
            // 
            this.picTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTwitter.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.twitter_logo;
            this.picTwitter.Location = new System.Drawing.Point(15, 87);
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.Size = new System.Drawing.Size(24, 24);
            this.picTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwitter.TabIndex = 7;
            this.picTwitter.TabStop = false;
            this.picTwitter.Click += new System.EventHandler(this.picTwitter_Click);
            // 
            // picGithub
            // 
            this.picGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGithub.Image = global::DemonsSoulsSaveOrganizer.Properties.Resources.github_logo;
            this.picGithub.Location = new System.Drawing.Point(15, 137);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(24, 24);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGithub.TabIndex = 8;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(125, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(212, 211);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picGithub);
            this.Controls.Add(this.picTwitter);
            this.Controls.Add(label4);
            this.Controls.Add(this.hlkGithubRepository);
            this.Controls.Add(this.hlkDeveloper);
            this.Controls.Add(label3);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel hlkDeveloper;
        private System.Windows.Forms.LinkLabel hlkGithubRepository;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.Button btnClose;
    }
}