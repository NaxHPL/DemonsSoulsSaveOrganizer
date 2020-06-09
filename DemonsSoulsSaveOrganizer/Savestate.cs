using System;
using System.IO;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    public class Savestate {

        public string DisplayName { get; set; }
        public string FullPath { get; set; }

        public Savestate(string displayName, string fullPath) {
            DisplayName = displayName;
            FullPath = fullPath;
        }

        public void ChangeName(string newName) {
            string newPath;

            try {
                newPath = Path.Combine(Directory.GetParent(FullPath).FullName, newName);
                Directory.Move(FullPath, newPath);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while renaming the savestate:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayName = newName;
            FullPath = newPath;
        }
    }
}
