using LowLevelHooking;
using System;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    static class Program {

        public static GlobalKeyboardHook GlobalKeyboardHook { get; private set; }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (GlobalKeyboardHook = new GlobalKeyboardHook()) {
                Application.Run(new MainForm());
            }
        }
    }
}
