using System.Windows.Forms;
using System.IO;

namespace DemonsSoulsSaveOrganizer {

    public partial class ProfileEditForm : Form {

        private static readonly char[] invalidCharacters = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
        private static readonly Properties.Settings settings = Properties.Settings.Default;

        public string ProfileName { get; set; }

        public ProfileEditForm(string formTitle, string textBoxText) {
            InitializeComponent();

            Text = formTitle;
            txtProfileName.Text = textBoxText;
        }

        private void btnOk_Click(object sender, System.EventArgs e) {
            if (ContainsInvalidChars(txtProfileName.Text)) {
                string invalidChars = string.Join(", ", invalidCharacters);
                MessageBox.Show($"Invalid characters are not allowed!\n\nInvalid characters: {invalidChars}", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProfileName.Focus();
                return;
            }

            if (Directory.Exists($"{settings.ProfilesDirectory}/{txtProfileName.Text}")) {
                MessageBox.Show("This profile already exists!", "Profile Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProfileName.Focus();
                return;
            }

            ProfileName = txtProfileName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ContainsInvalidChars(string str) {
            return str.IndexOfAny(invalidCharacters) >= 0;
        }
    }
}
