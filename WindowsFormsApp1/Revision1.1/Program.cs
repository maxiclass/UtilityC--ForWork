using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace UtilityApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitFunctions.InitFunctionStep1();

            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(UserEvents.SystemEvents_SessionSwitch);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}










namespace UtilityApp
{
     class InitFunctions
    {
        public static void InitFunctionStep1()
        {
        SCD.IntRecordNumber = Convert.ToInt32(ExcelDefine.Sheet2.Cells[9, 4].Value());
        SCD.IntEntryNumber = Convert.ToInt32(ExcelDefine.Sheet2.Cells[10, 4].Value());

        SCD.IntOnlineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[12, 4].Value());
        SCD.IntOfflineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[13, 4].Value());

        SCD.IntTotalOnlineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[15, 4].Value());
        SCD.IntTotalOfflineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[16, 4].Value());

        //SCD.StrTodayDate = ExcelDefine.Sheet2.Cells[18, 4].Value.ToString();
        //SCD.StrDayOfTheWeek = ExcelDefine.Sheet2.Cells[19, 4].Value.ToString();

        SCD.IntPlannedWorkingTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[21, 4].Value());
        SCD.IntPlannedBreakTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[22, 4].Value());

        SCD.StrCurrentTaskLink = ExcelDefine.Sheet2.Cells[24, 4].Value.ToString();
        SCD.StrCurrentTaskStatus = ExcelDefine.Sheet2.Cells[25, 4].Value.ToString();
        SCD.IntCurrentTaskPercent = Convert.ToInt32(ExcelDefine.Sheet2.Cells[26, 4].Value());

        }

        public static void InitFunctionStep2()
        {

        }

        public static void InitFunctionStep3()
        {

        }

    }
     
}
