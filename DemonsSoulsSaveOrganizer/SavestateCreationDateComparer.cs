using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace DemonsSoulsSaveOrganizer {

    class SavestateCreationDateComparer : IComparer {

        public int Compare(object x, object y) {
            TreeNode node1 = x as TreeNode;
            TreeNode node2 = y as TreeNode;

            if (node1 == null && node2 == null) {
                return 0;
            }

            Savestate save1 = node1.Tag as Savestate;
            Savestate save2 = node2.Tag as Savestate;

            if (save1 == null || save2 == null) {
                return 0;
            }

            DateTime save1CreationTime = Directory.GetCreationTimeUtc(save1.FullPath);
            DateTime save2CreationTime = Directory.GetCreationTimeUtc(save2.FullPath);

            return DateTime.Compare(save1CreationTime, save2CreationTime);
        }
    }
}
