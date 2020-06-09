﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace DemonsSoulsSaveOrganizer {

    public partial class MainForm : Form {

        private readonly Properties.Settings settings = Properties.Settings.Default;

        private Profile currentlySelectedProfile;

        public MainForm() {
            InitializeComponent();

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

            RefreshProfilesList();
        }

        #region Event methods

        private void btnBrowseProfilesDir_Click(object sender, EventArgs e) {
            string profilesPath = PromptForDirectory();

            if (!string.IsNullOrWhiteSpace(profilesPath)) {
                SetProfilesDirectory(profilesPath, true);
                RefreshProfilesList();
            }
        }

        private void btnBrowseSavefileDir_Click(object sender, EventArgs e) {
            string savefilePath = PromptForDirectory();

            if (!string.IsNullOrWhiteSpace(savefilePath)) {
                SetSavefileDirectory(savefilePath, true);
            }
        }

        private void hlkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(settings.AboutLink);
        }

        private void btnAddProfile_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(settings.ProfilesDirectory)) {
                return;
            }

            using (ProfileEditForm profileEditForm = new ProfileEditForm("New Profile", string.Empty)) {
                if (profileEditForm.ShowDialog() == DialogResult.OK) {
                    CreateProfile(profileEditForm.ProfileName);
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1) {
                return;
            }

            EditProfile(currentlySelectedProfile);
            lstProfiles.Items[lstProfiles.SelectedIndex] = currentlySelectedProfile;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1) {
                return;
            }

            DeleteProfile(currentlySelectedProfile);
        }

        private void lstProfiles_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1 || currentlySelectedProfile == (Profile)lstProfiles.SelectedItem) {
                return;
            }

            currentlySelectedProfile = (Profile)lstProfiles.SelectedItem;
            FillSavestates(currentlySelectedProfile);
        }

        private void btnImportSavestate_Click(object sender, EventArgs e) {
            if (lstProfiles.SelectedIndex == -1) {
                return;
            }

            ImportSavestate(currentlySelectedProfile);
        }

        private void btnLoadSavestate_Click(object sender, EventArgs e) {
            if (trvSavestates.SelectedNode == null) {
                return;
            }

            LoadSavestate((Savestate)trvSavestates.SelectedNode.Tag);
        }

        #endregion

        private string PromptForDirectory() {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()) {
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

            if (lstProfiles.Items.Count > 0) {
                lstProfiles.SelectedIndex = 0;
            }
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

            string fullPath = $"{settings.ProfilesDirectory}/{profileName}";
            DirectoryInfo directoryInfo;

            try {
                directoryInfo = Directory.CreateDirectory(fullPath);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while creating the profile:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = lstProfiles.Items.Add(new Profile(directoryInfo.Name, fullPath));
            lstProfiles.SelectedIndex = index;
        }

        private void EditProfile(Profile profileToEdit) {
            using (ProfileEditForm profileEditForm = new ProfileEditForm($"Edit {profileToEdit.DisplayName}", profileToEdit.DisplayName)) {
                if (profileEditForm.ShowDialog() == DialogResult.OK) {
                    profileToEdit.ChangeName(profileEditForm.ProfileName);
                }
            }
        }

        private void DeleteProfile(Profile profileToDelete) {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete \"{profileToDelete.DisplayName}\" and all of its contents?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                try {
                    Directory.Delete(profileToDelete.FullPath, true);
                }
                catch (Exception e) {
                    MessageBox.Show($"An error occured while deleting the profile:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            RefreshProfilesList();
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

            if (trvSavestates.Nodes.Count > 0) {
                trvSavestates.Focus();
                trvSavestates.SelectedNode = trvSavestates.Nodes[0];
            }
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
            }

            Savestate save = new Savestate(saveName, savePath);
            profile.AddSavestate(save);

            TreeNode node = new TreeNode() {
                Text = save.DisplayName,
                Tag = save
            };

            trvSavestates.Nodes.Add(node);
            trvSavestates.Focus();
            trvSavestates.SelectedNode = node;
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
            }
        }
    }
}
