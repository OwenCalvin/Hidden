using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace client
{
    class openCD
    {
        public openCD()
        {
            
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void getDrives(ref ComboBox cList)
        {
            //Clear list
            cList.Items.Clear();

            //Add only CD drives
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.CDRom)
                    cList.Items.Add(drive.RootDirectory);
            }
        }

        public void openDrive(string driveRoot)
        {
            string driveLetter = driveRoot[0].ToString();
            string returnString = string.Empty;

            //Set a name for the specified disk drive
            mciSendStringA("open " + driveLetter + ": type CDaudio alias drive" + driveLetter, returnString, 0, 0);

            //open the disk tray
            mciSendStringA("set drive" + driveLetter + " door open", returnString, 0, 0);
        }

        public void closeDrive(string driveRoot)
        {
            string driveLetter = driveRoot[0].ToString();
            string returnString = string.Empty;

            //Set a name for the specified disk drive
            mciSendStringA("open " + driveLetter + ": type CDaudio alias drive" + driveLetter, returnString, 0, 0);

            //close the disk tray
            mciSendStringA("set drive" + driveLetter + " door closed", returnString, 0, 0);
        }
    }
}
