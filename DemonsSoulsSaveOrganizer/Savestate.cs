using System;
using System.IO;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    public class Savestate {
        
        public static bool ExistsInProfile(string savestateName, Profile profile) => Directory.Exists(Path.Combine(profile.FullPath, savestateName));

        public string DisplayName { get; private set; }
        public string FullPath { get; private set; }

        public Savestate(string displayName, string fullPath) {
            DisplayName = displayName;
            FullPath = fullPath;
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

                string newPath = Path.Combine(Directory.GetParent(FullPath).FullName, newName);
                Directory.Move(FullPath, newPath);

                DisplayName = newName;
                FullPath = newPath;
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while renaming the savestate:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
