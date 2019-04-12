using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace UtilityApp
{
    // Class used to define behavior in user event situations
    public class UserEvents
    {
        // Save times when Lock and Unlock event happens
        public static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)

        {

            if (e.Reason == SessionSwitchReason.SessionLock)

            {
                ///  Form1.ContiApp

                ECD.bEnableBreakTime = true;
                ECD.bEnableOnlineTime = false;
                SCD.IntRecordNumber++;


            }
            // Save times when Lock and Unlock event happens
            else if (e.Reason == SessionSwitchReason.SessionUnlock)

            {
                ECD.bEnableBreakTime = false;
                ECD.bEnableOnlineTime = true;
            }

        }
    }
}
