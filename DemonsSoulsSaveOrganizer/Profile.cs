using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    public class Profile {

        public string DisplayName { get; set; }
        public string FullPath { get; set; }
        public Savestate[] Savestates => savestates.ToArray();

        private List<Savestate> savestates;

        public override string ToString() => DisplayName;

        public Profile(string displayName, string fullPath) : this(displayName, fullPath, new List<Savestate>()) { }

        public Profile(string displayName, string fullPath, List<Savestate> savestates) {
            DisplayName = displayName;
            FullPath = fullPath;
            this.savestates = savestates;
        }

        public void ChangeName(string newName) {
            string newPath;

            try {
                newPath = Path.Combine(Directory.GetParent(FullPath).FullName, newName);
                Directory.Move(FullPath, newPath);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while renaming the profile:\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayName = newName;
            FullPath = newPath;
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
    }
}