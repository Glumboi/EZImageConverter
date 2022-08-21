using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPictureConverter_Remake.Core
{
    internal class FileOpener
    {
        public static string FilePath{ get; set; } //Filepath
        
        public static string FileNameWithoutPath{ get; set; } //The name of the file without the path and extension
        
        public static void OpenIamge()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePath = ofd.FileName;
                FileNameWithoutPath = Path.GetFileNameWithoutExtension(FilePath);
            }
        }
    }
}
