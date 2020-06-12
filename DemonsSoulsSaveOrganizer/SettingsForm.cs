using LowLevelHooking;
using System;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    public partial class SettingsForm : Form {

        private static readonly Properties.Settings settings = Properties.Settings.Default;

        private bool waitingForKeypress = false;
        private Label lastLabelClicked;

        public SettingsForm() {
            InitializeComponent();
            InitializeSettings();

            Program.GlobalKeyboardHook.KeyDownOrUp += GlobalKeyboardHook_KeyDownOrUp;
        }

        private void InitializeSettings() {
            chkGlobalHotkeysEnabled.Checked = settings.GlobalHotkeysEnabled;

            lblLoadSaveHotkey.Tag = settings.LoadSavestateHotkey;
            if ((int)lblLoadSaveHotkey.Tag == 0) {
                lblLoadSaveHotkey.Text = "Unbound";
            }
            else {
                lblLoadSaveHotkey.Text = ((VirtualKey)(int)lblLoadSaveHotkey.Tag).ToString();
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.GlobalKeyboardHook.KeyDownOrUp -= GlobalKeyboardHook_KeyDownOrUp;
        }

        private void GlobalKeyboardHook_KeyDownOrUp(object sender, GlobalKeyboardHookEventArgs e) {
            if (!waitingForKeypress) {
                return;
            }

            if (e.KeyCode == VirtualKey.Escape) {
                lastLabelClicked.Text = "Unbound";
                lastLabelClicked.Tag = 0;
            }
            else {
                lastLabelClicked.Text = e.KeyCode.ToString();
                lastLabelClicked.Tag = (int)e.KeyCode;
            }

            e.Handled = true;
            waitingForKeypress = false;
        }

        private void lblLoadSaveHotkey_Click(object sender, EventArgs e) {
            lblLoadSaveHotkey.Text = "Set hotkey...";
            lastLabelClicked = lblLoadSaveHotkey;
            waitingForKeypress = true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            settings.GlobalHotkeysEnabled = chkGlobalHotkeysEnabled.Checked;
            settings.LoadSavestateHotkey = (int)lblLoadSaveHotkey.Tag;
            settings.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
