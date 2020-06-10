using System.Windows.Forms;
using System.IO;

namespace DemonsSoulsSaveOrganizer {

    public partial class NameEditForm : Form {

        private static readonly char[] invalidCharacters = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
        private static readonly Properties.Settings settings = Properties.Settings.Default;

        public string Input { get; set; }

        public NameEditForm(string formTitle, string label, string textBoxText) {
            InitializeComponent();

            Text = formTitle;
            lblName.Text = label;
            txtName.Text = textBoxText;
        }

        private void btnOk_Click(object sender, System.EventArgs e) {
            Input = txtName.Text.Trim();

            if (ContainsInvalidChars(Input)) {
                string invalidChars = string.Join(", ", invalidCharacters);
                MessageBox.Show($"Invalid characters are not allowed!\n\nInvalid characters: {invalidChars}", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

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
