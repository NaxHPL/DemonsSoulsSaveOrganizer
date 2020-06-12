using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    public class Profile {
        
        private static readonly Properties.Settings settings = Properties.Settings.Default;

        public static bool Exists(string profileName) => Directory.Exists(Path.Combine(settings.ProfilesDirectory, profileName));

        public string DisplayName { get; private set; }
        public string FullPath { get; private set; }
        public Savestate[] Savestates => savestates.ToArray();

        private List<Savestate> savestates;

        public Profile(string displayName, string fullPath) : this(displayName, fullPath, new List<Savestate>()) { }

        public Profile(string displayName, string fullPath, List<Savestate> savestates) {
            DisplayName = displayName;
            FullPath = fullPath;
            this.savestates = savestates;
        }

        public void ChangeName(string newName) {
            try {
                /* If the new name is the same but with different capitalization,
                 * change its name to a temporary name first. If this is not done,
                 * Directory.Move() will fail due to the destination directory and
                 * source directory being the same. */
                if (newName.Equals(DisplayName, StringComparison.OrdinalIgnoreCase)) {
                    ChangeName($"{DisplayName}_{Guid.NewGuid()}");
                }

                string newPath = Path.Combine(settings.ProfilesDirectory, newName);
                Directory.Move(FullPath, newPath);

                DisplayName = newName;
                FullPath = newPath;
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while renaming the profile:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddSavestate(Savestate savestate) {
            if (!savestates.Contains(savestate)) {
                savestates.Add(savestate);
            }
        }

        public void RemoveSavestate(Savestate savestate) {
            if (savestates.Contains(savestate)) {
                savestates.Remove(savestate);
            }
        }
        
        public override string ToString() => DisplayName;

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj) {
            if (obj == null || !GetType().Equals(obj.GetType())) {
                return false;
            }
            else {
                Profile profile = obj as Profile;
                return DisplayName.Equals(profile.DisplayName) && FullPath.Equals(profile.FullPath);
            }
        }
    }
}