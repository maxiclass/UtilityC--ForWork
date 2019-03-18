using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Differentbranch;
using System.Runtime.InteropServices;

namespace Differentbranch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EnableClassData.bEnableOnlineTime = false;

           FirstInitClass.FirstStepInit();
            FirstInitClass.SecondStepInit();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContiForm());
            

        }
    }
}

namespace Differentbranch
{
    class FirstInitClass
    {
        /* Read current configuration and store data in memory*/
        public static void FirstStepInit()
        {
            StorageClassData.SUserName = ExcelDefine.Sheet2.Cells[10, 10].Value.ToString();
            StorageClassData.IntEntryNumber = Convert.ToInt32(ExcelDefine.Sheet2.Cells[11, 10].Value());

            StorageClassData.IntWorkingMinutes = Convert.ToInt32(ExcelDefine.Sheet2.Cells[12, 10].Value());
            StorageClassData.IntBreakMinutes = Convert.ToInt32(ExcelDefine.Sheet2.Cells[13, 10].Value());

            StorageClassData.IntLogoffTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[18, 10].Value());
            StorageClassData.IntOnlineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[19, 10].Value());

            StorageClassData.SEntryTime = DateTime.Now.ToString("HH:mm");
            ExcelDefine.Sheet2.Cells[15, 10].Value = StorageClassData.SEntryTime;

            StorageClassData.STodayDate = ExcelDefine.Sheet2.Cells[16, 10].Value();
            /* check if it's a new day */
            if (StorageClassData.STodayDate != DateTime.Today.ToString("dd / MM / yyyy"))
            {
                StorageClassData.STodayDate = DateTime.Today.ToString("dd / MM / yyyy");
                ExcelDefine.Sheet2.Cells[16, 10].Value = StorageClassData.STodayDate;
                StorageClassData.IntOnlineTime = 0;
                ExcelDefine.Sheet2.Cells[19, 10].Value = StorageClassData.IntOnlineTime;
                StorageClassData.IntLogoffTime = 0;
                ExcelDefine.Sheet2.Cells[18, 10].Value = StorageClassData.IntLogoffTime;
            }
            else
            {
                /* do nothing*/
            }

            StorageClassData.IntStoryPoints = Convert.ToInt32(ExcelDefine.Sheet2.Cells[22, 10].Value());
            StorageClassData.IntStoryPointsLeft = Convert.ToInt32(ExcelDefine.Sheet2.Cells[23, 10].Value());

        }

        /* Enable some task accordingly with current configuration*/
        public static void SecondStepInit()
        {
            EnableClassData.bEnableOnlineTime = true;
        }

        /* This Step will load ContiForm with current configuration*/
        public static void ThirdStepInit()
        {
         //   TaskTime.
        }
    }
}
