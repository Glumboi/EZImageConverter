using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPictureConverter_Remake.Core
{
    internal class FileSaver
    {
        public static string FormatOfSaveFile{ get; set; } //Used to get the format the file is gonna be saved in like .png or .jpeg
        
        public static string FileName{ get; private set; } //Filepath
        
        public static string Action{ get; private set; } //Used to check if a user canceled the savedialog, not the best version of it but it works

        public static string SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = FormatOfSaveFile;
            sfd.FileName = FileOpener.FileNameWithoutPath;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileName = sfd.FileName;
                return sfd.FileName;
            }
            else
                return Action = "Canceled";
        }
    }
}
