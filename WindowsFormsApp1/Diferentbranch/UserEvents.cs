using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Differentbranch;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Diferentbranch
{
    // Class used to define behavior in user event situations
    public class UserEvents
    {
        // Save times when Lock and Unlock event happens
        public static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)

        {

            if (e.Reason == SessionSwitchReason.SessionLock)

            {
                ++StorageClassData.IntEntryNumber;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 3] = StorageClassData.IntEntryNumber;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 4] = DateTime.Now.ToString("HH:mm");
                StorageClassData.LockTimeStart = DateTime.Now;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 5] = DateTime.Today.ToString("dd / MM / yyyy");
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 6] = "LOCK";
                ExcelDefine.Sheet2.Cells[11, 10].Value = StorageClassData.IntEntryNumber;
                

            }
            // Save times when Lock and Unlock event happens
            else if (e.Reason == SessionSwitchReason.SessionUnlock)

            {
                ++StorageClassData.IntEntryNumber;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 3] = StorageClassData.IntEntryNumber;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 4] = DateTime.Now.ToString("HH:mm");
                StorageClassData.LockTimeFinish = DateTime.Now;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 5] = DateTime.Today.ToString("dd / MM / yyyy");
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 6] = "UNLOCK";

                //Comment column
                string BreakTotalTime = (StorageClassData.LockTimeFinish - StorageClassData.LockTimeStart).ToString("mm");
                StorageClassData.TotalDayBreakTime = (StorageClassData.LockTimeFinish - StorageClassData.LockTimeStart).ToString("mm");
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 8] = StorageClassData.TotalDayBreakTime + " min Offline";
                ExcelDefine.Sheet2.Cells[25, 10].Value = StorageClassData.TotalDayBreakTime;
                ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 7] = BreakTotalTime + " min break";
                ExcelDefine.Sheet2.Cells[11, 10].Value = StorageClassData.IntEntryNumber;
            }

        }
    }
}
