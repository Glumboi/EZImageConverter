using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glumboi.UI;

namespace EZPictureConverter_Remake.HelpWindow
{
    public partial class HelpForm : Form
    {
        string[] socials =
        {
            //My github profile
            "https://github.com/Glumboi",
            //Project link
            "https://github.com/Glumboi/EZImageConverter"

        };

        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(Handle);
        }

        private void Linklabel_Github_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(socials[0]);
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            this.Hide();
        }

        private void Linklabel_Project_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(socials[1]);
        }
    }
}
