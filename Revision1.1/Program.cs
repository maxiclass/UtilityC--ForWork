using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Net;
using System.Xml;

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

            InitFunctions.InitFunctionStep2();
            InitFunctions.InitFunctionStep3();
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(UserEvents.SystemEvents_SessionSwitch);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContiApp());
        }
    }
}



//Convert.ToDateTime("")






namespace UtilityApp
{
     class InitFunctions
    {
        /* Load all esential variables */
        public static void InitFunctionStep1()
        {
        SCD.IntRecordNumber = Convert.ToInt32(ExcelDefine.Sheet2.Cells[9, 4].Value());
        SCD.IntEntryNumber = Convert.ToInt32(ExcelDefine.Sheet2.Cells[10, 4].Value());

        //SCD.IntOnlineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[12, 4].Value());
        //SCD.IntOfflineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[13, 4].Value());

        SCD.IntTotalTimeInDay = Convert.ToInt32(ExcelDefine.Sheet2.Cells[15, 4].Value());
        SCD.IntTotalOfflineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[16, 4].Value());
        SCD.IntOnlineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[17, 4].Value());

        //SCD.StrTodayDate = ExcelDefine.Sheet2.Cells[18, 4].Value.ToString();
        //SCD.StrDayOfTheWeek = ExcelDefine.Sheet2.Cells[19, 4].Value.ToString();

            SCD.IntPlannedWorkingTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[21, 4].Value());
        SCD.IntPlannedBreakTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[22, 4].Value());

        SCD.StrCurrentTaskLink = ExcelDefine.Sheet2.Cells[24, 4].Value.ToString();
        SCD.StrCurrentTaskStatus = ExcelDefine.Sheet2.Cells[25, 4].Value.ToString();
        SCD.IntCurrentTaskPercent = Convert.ToInt32(ExcelDefine.Sheet2.Cells[26, 4].Value());

        }
        /* Set the active configuration */
        public static void InitFunctionStep2()
        {
            ECD.bEnableOnlineTime = true;
            ECD.bEnableBreakTime = false;
            ECD.bWinEventLock = false;
            ECD.bClearPanel = false;
        }

        public static void InitFunctionStep3()
        {
            SCD.StrHourNow = DateTime.Now.ToString("HH:mm");
            SCD.StrTodayDate = DateTime.Today.ToString("dd/MM/yyyy");
            string tempDate = ExcelDefine.Sheet2.Cells[18, 4].Value.ToString();
            //string tempDate = "test";
            if (tempDate != SCD.StrTodayDate)
            {
                ExcelDefine.Sheet2.Cells[18, 4] = SCD.StrTodayDate;
                UtilityFunctions.Record("New Day", " New Day");
                ExcelDefine.Sheet.Cells[SCD.IntRecordNumber + 5, 4] = SCD.StrTodayDate;
            }
            else
            {
                // do nothing
            }


           
        }

    }
     
}



namespace UtilityApp
{
    class UtilityFunctions
    {
        public static void Exit()
        {
            try
            {
                ExcelDefine.Workbooks.Save();
                ExcelDefine.Workbooks.Close();
                ExcelDefine.Exit();
                CloseExcelProcess.CloseExcel();
                Application.Exit();
            }
            catch
            {
                //MessageBox.Show("Excel file is in used. Close Excel file first");
                Application.Exit();
            }
        }
        public static void Save()
        {
            ExcelDefine.Sheet2.Cells[15, 4] = SCD.IntTotalTimeInDay;
            ExcelDefine.Sheet2.Cells[16, 4] = SCD.IntTotalOfflineTime;
            ExcelDefine.Sheet2.Cells[17, 4] = SCD.IntOnlineTime;

            ExcelDefine.Save();

        }
        public static void Record(string Event, string Comment)
        {
            SCD.IntRecordNumber++; // COUNTER FOR RECORD ENTRY NUMBER
            ExcelDefine.Sheet2.Cells[9, 4] = SCD.IntRecordNumber;// STORE NEW RECORD ENTRY NUMBER

            ExcelDefine.Sheet.Cells[SCD.IntRecordNumber + 5, 3] = SCD.IntRecordNumber; // RECORD NUMBER

            ExcelDefine.Sheet.Cells[SCD.IntRecordNumber + 5, 4] = "----";
           
            ExcelDefine.Sheet.Cells[SCD.IntRecordNumber + 5, 5] = SCD.StrHourNow; // TIME WHEN EVENT WAS RECORDED

            ExcelDefine.Sheet.Cells[SCD.IntRecordNumber + 5, 6] = Event; // NAME OF THE EVENT

            ExcelDefine.Sheet.Cells[SCD.IntRecordNumber + 5, 7] = Comment; // COMMENT
        }
        public static void DeleteRecords()
        {
            SCD.IntTotalTimeInDay = 0; ExcelDefine.Sheet2.Cells[15, 4] = 0;
            SCD.IntTotalOfflineTime = 0; ExcelDefine.Sheet2.Cells[16, 4] = 0;
            SCD.IntOnlineTime = 0; ExcelDefine.Sheet2.Cells[17, 4] = 0;
            SCD.IntOvertime = 0;
            ECD.bClearPanel = true;
        }
    }

    class DownloadPageHttpWebRequest
    {
        public static void GetWebData()
        {
            string html = string.Empty;
            string htmlline = string.Empty;
            string url = "http://www.wikipedia.com";

            try {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
               // htmlline = html.
            }
            SCD.StrHtmlResult = htmlline;
                //  return html; Console.WriteLine(html);
            }
            catch
            {
                SCD.StrHtmlResult = "Operation failed";
            }
        }
        public static void GetWebDatatoXML()
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load("http://buhev-jira.conti.de:7090/browse/BMF-2362");
                string allText = document.InnerText;
                SCD.StrHtmlResult = allText;
            }
            catch
            {
                SCD.StrHtmlResult = "Operation failed";
            }
        }
    }
}