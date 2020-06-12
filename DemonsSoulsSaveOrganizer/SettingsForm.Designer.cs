namespace DemonsSoulsSaveOrganizer {
    partial class SettingsForm {
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
            System.Windows.Forms.GroupBox grbHotkeys;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblLoadSaveHotkey = new System.Windows.Forms.Label();
            this.chkGlobalHotkeysEnabled = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            grbHotkeys = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            grbHotkeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHotkeys
            // 
            grbHotkeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            grbHotkeys.Controls.Add(label1);
            grbHotkeys.Controls.Add(label2);
            grbHotkeys.Controls.Add(this.lblLoadSaveHotkey);
            grbHotkeys.Controls.Add(this.chkGlobalHotkeysEnabled);
            grbHotkeys.Location = new System.Drawing.Point(12, 12);
            grbHotkeys.Name = "grbHotkeys";
            grbHotkeys.Size = new System.Drawing.Size(304, 99);
            grbHotkeys.TabIndex = 0;
            grbHotkeys.TabStop = false;
            grbHotkeys.Text = "Hotkeys";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 75);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 13);
            label1.TabIndex = 0;
            label1.Text = "Load Selected Savestate:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(233, 13);
            label2.TabIndex = 3;
            label2.Text = "Click the box to rebind. Press Escape to unbind.";
            // 
            // lblLoadSaveHotkey
            // 
            this.lblLoadSaveHotkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoadSaveHotkey.Location = new System.Drawing.Point(142, 71);
            this.lblLoadSaveHotkey.Name = "lblLoadSaveHotkey";
            this.lblLoadSaveHotkey.Size = new System.Drawing.Size(156, 20);
            this.lblLoadSaveHotkey.TabIndex = 1;
            this.lblLoadSaveHotkey.Text = "Unbound";
            this.lblLoadSaveHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoadSaveHotkey.Click += new System.EventHandler(this.lblLoadSaveHotkey_Click);
            // 
            // chkGlobalHotkeysEnabled
            // 
            this.chkGlobalHotkeysEnabled.AutoSize = true;
            this.chkGlobalHotkeysEnabled.Location = new System.Drawing.Point(6, 19);
            this.chkGlobalHotkeysEnabled.Name = "chkGlobalHotkeysEnabled";
            this.chkGlobalHotkeysEnabled.Size = new System.Drawing.Size(134, 17);
            this.chkGlobalHotkeysEnabled.TabIndex = 0;
            this.chkGlobalHotkeysEnabled.Text = "Enable Global Hotkeys";
            this.chkGlobalHotkeysEnabled.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(241, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(160, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 155);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(grbHotkeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            grbHotkeys.ResumeLayout(false);
            grbHotkeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkGlobalHotkeysEnabled;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLoadSaveHotkey;
    }
}