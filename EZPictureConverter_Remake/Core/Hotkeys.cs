using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPictureConverter_Remake.Core
{
    internal class Hotkeys
    {
        //Extern methods used to manage hotkeys
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public enum HotkeyIDs
        {
            HotkeyID = 1,
            HotkeyID2 = 2,
            HotkeyID3 = 3
        }

        public static void LoadHotkeys(Control control)
        {   
            RegisterHotKey(control.Handle, (int)HotkeyIDs.HotkeyID, 2, (int)Keys.O);
            RegisterHotKey(control.Handle, (int)HotkeyIDs.HotkeyID2, 2, (int)Keys.S);
            RegisterHotKey(control.Handle, (int)HotkeyIDs.HotkeyID3, 2, (int)Keys.H);
        }

        public static void Unloadhotkeys(Control control)
        {
            foreach (HotkeyIDs hotkey in Enum.GetValues(typeof(HotkeyIDs)))
            {
                UnregisterHotKey(control.Handle, (int)hotkey);
            }
        }
    }
}
