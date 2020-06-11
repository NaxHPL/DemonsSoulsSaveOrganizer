using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;

namespace DemonsSoulsSaveOrganizer {

    public partial class MainForm : Form {

        private const int DEFAULT_STATUS_MESSAGE_DURATION = 3000;

        private static readonly Properties.Settings settings = Properties.Settings.Default;

        private Profile currentlySelectedProfile;

        public MainForm() {
            InitializeComponent();

            InitializeDirectories();
            RefreshProfilesList();
            lblStatus.Visible = false;

            trvSavestates.Select();
        }

        #region Event methods

        private void btnBrowseProfilesDir_Click(object sender, EventArgs e) {
            string profilesPath = PromptForDirectory("Browse for profile directory.");

            if (!string.IsNullOrWhiteSpace(profilesPath)) {
                SetProfilesDirectory(profilesPath, true);
                RefreshProfilesList();
            }
        }

        private void btnBrowseSavefileDir_Click(object sender, EventArgs e) {
            string savefilePath = PromptForDirectory("Browse for savefile directory.");

            if (!string.IsNullOrWhiteSpace(savefilePath)) {
                SetSavefileDirectory(savefilePath, true);
            }
        }

        private void tsbAddProfile_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(settings.ProfilesDirectory)) {
                DialogResult result = MessageBox.Show("Please setup your profile directory before creating profiles.", "Setup Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                if (result == DialogResult.OK) {
                    btnBrowseProfilesDir.PerformClick();
                }
                
                return;
            }

            using (NameEditForm nameEditForm = new NameEditForm("New Profile", "Profile Name:", string.Empty)) {
                if (nameEditForm.ShowDialog() == DialogResult.OK) {
                    CreateProfile(nameEditForm.Input);
                }
            }
        }

        private void tsbDeleteProfile_Click(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1) {
                return;
            }

            DeleteProfile(currentlySelectedProfile);
        }

        private void tsbEditProfile_Click(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1) {
                return;
            }

            RenameProfile(currentlySelectedProfile);
        }

        private void lstProfiles_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1 || currentlySelectedProfile == (Profile)lstProfiles.SelectedItem) {
                return;
            }

            currentlySelectedProfile = (Profile)lstProfiles.SelectedItem;
            FillSavestates(currentlySelectedProfile);
        }

        private void tsbImportSavestate_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(settings.SavefileDirectory)) {
                DialogResult result = MessageBox.Show("Please setup your savefile directory before importing savestates.", "Setup Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK) {
                    btnBrowseSavefileDir.PerformClick();
                }

                return;
            }

            if (lstProfiles.Items.Count == 0) {
                DialogResult result = MessageBox.Show("Please create a profile before importing savestates.", "Profile Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK) {
                    tsbAddProfile.PerformClick();
                }

                return;
            }

            if (lstProfiles.SelectedIndex == -1) {
                return;
            }

            ImportSavestate(currentlySelectedProfile);
        }

        private void tsbLoadSavestate_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(settings.SavefileDirectory)) {
                DialogResult result = MessageBox.Show("Please setup your savefile directory before loading savestates.", "Setup Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK) {
                    btnBrowseSavefileDir.PerformClick();
                }

                return;
            }

            if (trvSavestates.SelectedNode == null) {
                return;
            }

            LoadSavestate((Savestate)trvSavestates.SelectedNode.Tag);
        }

        private void cmsSavestates_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == tsmiRenameSavestate) {
                RenameSavestate((Savestate)trvSavestates.SelectedNode.Tag);
            }
            else if (e.ClickedItem == tsmiDeleteSavestate) {
                cmsSavestates.Close();
                DeleteSavestate((Savestate)trvSavestates.SelectedNode.Tag);
            }
        }

        private void csmProfiles_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == tsmiRenameProfile) {
                RenameProfile(currentlySelectedProfile);
            }
            else if (e.ClickedItem == tsmiDeleteProfile) {
                cmsProfiles.Close();
                DeleteProfile(currentlySelectedProfile);
            }
        }

        private void trvSavestates_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                TreeNode clickedNode = trvSavestates.GetNodeAt(e.X, e.Y);

                if (clickedNode == null) {
                    return;
                }

                trvSavestates.SelectedNode = clickedNode;

                if (trvSavestates.SelectedNode != null) {
                    cmsSavestates.Show(trvSavestates, e.Location);
                }
            }
        }

        private void lstProfiles_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                int clickedIndex = lstProfiles.IndexFromPoint(e.X, e.Y);

                if (clickedIndex == -1) {
                    return;
                }

                lstProfiles.SelectedIndex = clickedIndex;

                if (lstProfiles.SelectedIndex >= 0) {
                    cmsProfiles.Show(lstProfiles, e.Location);
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1) {
                Process.Start(settings.HelpLink);
            }

            if (trvSavestates.Focused) {
                HandleSavestateKeyShortcuts(e.KeyCode);
            }
            else if (lstProfiles.Focused) {
                HandleProfileKeyShortcuts(e.KeyCode);
            }
        }

        private void picGear_MouseEnter(object sender, EventArgs e) {
            picGear.BackColor = Color.LightBlue;
        }

        private void picGear_MouseLeave(object sender, EventArgs e) {
            picGear.BackColor = Color.Transparent;
        }

        private void picGear_MouseUp(object sender, MouseEventArgs e) {
            cmsSettings.Show(picGear, e.Location);
        }

        private void cmsSettings_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == tsmiAbout) {
                using (AboutForm aboutForm = new AboutForm()) {
                    aboutForm.ShowDialog();
                }
            }
            else if (e.ClickedItem == tsmiHelp) {
                Process.Start(settings.HelpLink);
            }
        }

        private void timStatus_Tick(object sender, EventArgs e) {
            lblStatus.Visible = false;
            timStatus.Stop();
        }

        #endregion

        private void InitializeDirectories() {
            if (Directory.Exists(settings.ProfilesDirectory)) {
                SetProfilesDirectory(settings.ProfilesDirectory);
            }
            else {
                SetProfilesDirectory(string.Empty, true);
            }

            if (Directory.Exists(settings.SavefileDirectory)) {
                SetSavefileDirectory(settings.SavefileDirectory);
            }
            else {
                SetSavefileDirectory(string.Empty, true);
            }
        }

        private string PromptForDirectory(string description) {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()) {
                folderBrowserDialog.Description = description;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                    return folderBrowserDialog.SelectedPath;
                }

                return string.Empty;
            }
        }

        private void SetProfilesDirectory(string dir, bool saveSettings = false) {
            txtProfilesDir.Text = dir;

            if (saveSettings) {
                settings.ProfilesDirectory = dir;
                settings.Save();
            }
        }
        
        private void SetSavefileDirectory(string dir, bool saveSettings = false) {
            txtSavefileDir.Text = dir;

            if (saveSettings) {
                settings.SavefileDirectory = dir;
                settings.Save();
            }
        }

        private void RefreshProfilesList() {
            if (string.IsNullOrWhiteSpace(settings.ProfilesDirectory)) {
                return;
            }
            
            lstProfiles.BeginUpdate();
            lstProfiles.Items.Clear();

            foreach (string directory in Directory.EnumerateDirectories(settings.ProfilesDirectory)) {
                lstProfiles.Items.Add(new Profile(
                    new DirectoryInfo(directory).Name,
                    directory,
                    GetSavestatesInDirectory(directory)
                ));
            }

            lstProfiles.EndUpdate();
            lstProfiles.SelectedIndex = lstProfiles.Items.Count > 0 ? 0 : -1;
        }

        private List<Savestate> GetSavestatesInDirectory(string directory) {
            List<Savestate> savestates = new List<Savestate>();

            foreach (string dir in Directory.EnumerateDirectories(directory)) {
                savestates.Add(new Savestate(
                    new DirectoryInfo(dir).Name,
                    dir
                ));
            }

            return savestates;
        }

        private void CreateProfile(string profileName) {
            if (string.IsNullOrWhiteSpace(profileName)) {
                return;
            }

            if (Profile.Exists(profileName)) {
                MessageBox.Show($"A profile named \"{profileName}\" already exists!", "Profile Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //btnAddProfile.PerformClick();
                return;
            }

            string fullPath = Path.Combine(settings.ProfilesDirectory, profileName);
            DirectoryInfo directoryInfo;

            try {
                directoryInfo = Directory.CreateDirectory(fullPath);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while creating the profile directory:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = lstProfiles.Items.Add(new Profile(directoryInfo.Name, fullPath));
            lstProfiles.SelectedIndex = index;
        }

        private void RenameProfile(Profile profile) {
            using (NameEditForm nameEditForm = new NameEditForm($"Edit {profile.DisplayName}", "Profile Name:", profile.DisplayName)) {
                if (nameEditForm.ShowDialog() == DialogResult.OK) {
                    if (profile.DisplayName.Equals(nameEditForm.Input)) {
                        return;
                    }

                    if (Profile.Exists(nameEditForm.Input) && !profile.DisplayName.Equals(nameEditForm.Input, StringComparison.OrdinalIgnoreCase)) {
                        MessageBox.Show($"A profile named \"{nameEditForm.Input}\" already exists!", "Profile Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RenameProfile(currentlySelectedProfile);
                        return;
                    }

                    profile.ChangeName(nameEditForm.Input);
                    RefreshProfilesList();

                    lstProfiles.SelectedIndex = lstProfiles.Items.IndexOf(profile);
                }
            }
        }

        private void DeleteProfile(Profile profileToDelete) {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete \"{profileToDelete.DisplayName}\" and all of its contents?", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                try {
                    Directory.Delete(profileToDelete.FullPath, true);
                    RefreshProfilesList();

                    if (lstProfiles.Items.Count == 0) {
                        ClearSavestates();
                    }
                }
                catch (Exception e) {
                    MessageBox.Show($"An error occured while deleting the profile:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void FillSavestates(Profile profile) {
            trvSavestates.BeginUpdate();
            trvSavestates.Nodes.Clear();

            foreach (Savestate save in profile.Savestates) {
                TreeNode node = new TreeNode() {
                    Text = save.DisplayName,
                    Tag = save
                };
                trvSavestates.Nodes.Add(node);
            }

            trvSavestates.EndUpdate();

            trvSavestates.Sort();

            if (trvSavestates.Nodes.Count > 0) {
                trvSavestates.SelectedNode = trvSavestates.Nodes[0];
            }
        }

        private void ClearSavestates() {
            trvSavestates.Nodes.Clear();
        }

        private void ImportSavestate(Profile profile) {
            string saveName = GetNewSavestateName(profile.FullPath);
            string savePath = Path.Combine(profile.FullPath, saveName);

            try {
                Directory.CreateDirectory(savePath);
                CopySaveFolderAndContents(settings.SavefileDirectory, savePath);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while importing the savestate:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Savestate save = new Savestate(saveName, savePath);
            profile.AddSavestate(save);

            TreeNode node = new TreeNode() {
                Text = save.DisplayName,
                Tag = save
            };

            trvSavestates.Nodes.Add(node);
            trvSavestates.Select();
            trvSavestates.SelectedNode = node;

            SetStatusText("Import Successful!", Color.RoyalBlue);
        }

        private string GetNewSavestateName(string path) {
            string newSavestateName = "New Savestate";
            
            if (!Directory.Exists(Path.Combine(path, newSavestateName))) {
                return newSavestateName;
            }

            int i = 1;

            while (Directory.Exists(Path.Combine(path, $"{newSavestateName} {i}"))) {
                i++;
            }

            return $"{newSavestateName} {i}";
        }

        private void CopySaveFolderAndContents(string sourcePath, string destinationPath) {
            DirectoryInfo sourceDir = new DirectoryInfo(sourcePath);

            if (!sourceDir.Exists) {
                throw new DirectoryNotFoundException($"Savefile directory does not exist or could not be found:\n{sourceDir.FullName}");
            }

            DirectoryInfo newDir = Directory.CreateDirectory(Path.Combine(destinationPath, sourceDir.Name));

            foreach (FileInfo file in sourceDir.GetFiles()) {
                file.CopyTo(Path.Combine(newDir.FullName, file.Name), true);
            }
        }

        private void LoadSavestate(Savestate savestate) {
            try {
                Directory.Delete(settings.SavefileDirectory, true);
                Directory.CreateDirectory(settings.SavefileDirectory);
                CopySaveFolderAndContents(Path.Combine(savestate.FullPath, new DirectoryInfo(settings.SavefileDirectory).Name), new DirectoryInfo(settings.SavefileDirectory).Parent.FullName);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while loading the savestate:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetStatusText("Load Successful!", Color.Green);
        }

        private void RenameSavestate(Savestate savestate) {
            using (NameEditForm nameEditForm = new NameEditForm($"Edit {savestate.DisplayName}", "Savestate Name:", savestate.DisplayName)) {
                if (nameEditForm.ShowDialog() == DialogResult.OK) {
                    if (savestate.DisplayName.Equals(nameEditForm.Input)) {
                        return;
                    }

                    if (Savestate.ExistsInProfile(nameEditForm.Input, currentlySelectedProfile) && !savestate.DisplayName.Equals(nameEditForm.Input, StringComparison.OrdinalIgnoreCase)) {
                        MessageBox.Show($"A savestate named \"{nameEditForm.Input}\" already exists!", "Savestate Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RenameSavestate(savestate);
                        return;
                    }

                    savestate.ChangeName(nameEditForm.Input);
                    trvSavestates.SelectedNode.Text = nameEditForm.Input;

                    TreeNode nodeToSelect = trvSavestates.SelectedNode;
                    trvSavestates.Sort();
                    trvSavestates.SelectedNode = nodeToSelect;
                }
            }
        }

        private void DeleteSavestate(Savestate savestate) {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete \"{savestate.DisplayName}\"?", "Delete Savestate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                try {
                    Directory.Delete(savestate.FullPath, true);
                    currentlySelectedProfile.RemoveSavestate(savestate);
                    FillSavestates(currentlySelectedProfile);
                    trvSavestates.Select();
                }
                catch (Exception e) {
                    MessageBox.Show($"An error occured while deleting the savestate:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetStatusText("Delete Successful!", Color.Red);
            }
        }

        private void HandleProfileKeyShortcuts(Keys key) {
            if (key == Keys.F2 && lstProfiles.SelectedIndex >= 0) {
                RenameProfile(currentlySelectedProfile);
            }
            else if (key == Keys.Delete && lstProfiles.SelectedIndex >= 0) {
                DeleteProfile(currentlySelectedProfile);
            }
        }

        private void HandleSavestateKeyShortcuts(Keys key) {
            if (key == Keys.F2 && trvSavestates.SelectedNode != null) {
                RenameSavestate((Savestate)trvSavestates.SelectedNode.Tag);
            }
            else if (key == Keys.Delete && trvSavestates.SelectedNode != null) {
                DeleteSavestate((Savestate)trvSavestates.SelectedNode.Tag);
            }
        }

        private void SetStatusText(string text, Color textColour, int duration = DEFAULT_STATUS_MESSAGE_DURATION) {
            timStatus.Stop();
            timStatus.Interval = duration;

            lblStatus.Text = text;
            lblStatus.ForeColor = textColour;
            lblStatus.Visible = true;

            timStatus.Start();
        }
    }
}
