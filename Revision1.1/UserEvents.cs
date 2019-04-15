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
                UtilityFunctions.Record("LOCK", ""); //LOCK event , no comment 
                ECD.bEnableBreakTime = true;
                ECD.bEnableOnlineTime = false;
                SCD.IntLockTimeStart = 0;


            }
            // Save times when Lock and Unlock event happens
            else if (e.Reason == SessionSwitchReason.SessionUnlock)

            {
                UtilityFunctions.Record("UNLOCK", SCD.IntLockTimeStart.ToString()+ " min break"); //LOCK event , time of the break
                ECD.bEnableBreakTime = false;
                ECD.bEnableOnlineTime = true;
            }

        }
    }
}
