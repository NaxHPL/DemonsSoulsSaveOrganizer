using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    public partial class AboutForm : Form {

        private Properties.Settings settings = Properties.Settings.Default;

        public AboutForm() {
            InitializeComponent();
            InitializeVersion();
        }

        private void InitializeVersion() {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text = $"{version.Major}.{version.Minor}";
        }

        private void hlkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(settings.TwitterLink);
        }

        private void hlkGithubRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(settings.GithubRepository);
        }

        private void picTwitter_Click(object sender, EventArgs e) {
            Process.Start(settings.TwitterLink);
        }

        private void picGithub_Click(object sender, EventArgs e) {
            Process.Start(settings.GithubRepository);
        }
    }
}
