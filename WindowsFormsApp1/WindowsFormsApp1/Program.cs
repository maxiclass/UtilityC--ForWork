using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ClassForExcelFunction;
using ClassForPanelUtility;
using DataManipulation;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Load Configuration
            Operations.ExcelOperations.LoadExcelCfgFunction();

            Operations.ExcelOperations.CheckExcel();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //ClassForExcelFunction.ClassForExcelFunction.ExcelCfgTemplate ExcelConf;

        }
    }
}

namespace ClassForPanelUtility
{
    /* Class used for panel connection and utility  */
    class ClassForPanelUtility
    {
       public static void ExitAplication ()
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}

namespace ClassForExcelFunction
{
    public static class ClassForExcelFunction
    {

        public static string ReadExcelCell(int row,int col,int sheetnr)
        {
            string StringReadValue;
            Excel.Application excel = new Excel.Application();
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            var excelFileLocation = System.IO.Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[sheetnr];
            if (typeof(double) == sheet.Cells[row, col].Value.GetType())
            {
              StringReadValue = sheet.Cells[row, col].Value.ToString();
            }
            else
            {
                StringReadValue = sheet.Cells[row, col].Value;
            }
            object LastEntryNumber = (Excel.Range)sheet.Cells[row, col];
            //ClassForStorageContainers.StorageClassExcel.doubleEntryNumber = LastEntryNumber; //Int32.Parse(LastEntryNumber.text);
            wb.Save();
            wb.Close();
            excel.Quit();
            return StringReadValue;

        }
        public static void WriteExcelCell(int row, int col, int sheetnr, string data )
        {
            Excel.Application excel = new Excel.Application();
            var currentDirectory = Directory.GetCurrentDirectory();
            var excelFileLocation = System.IO.Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[sheetnr];
            ((Excel.Range)sheet.Cells[row, col]).Value = data;
            wb.Save();
            wb.Close();
            excel.Quit();
        }

    }

}

namespace ClassForStorageContainers
{
    public class ExcelDirectoryClass
    {
        static string currentDirectory = System.IO.Directory.GetCurrentDirectory();
        static string excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
        public static string ExcelPath
        { get  
            {
                return excelFileLocation;
            }
        }
    }
}

namespace ClassforProgressBar
{
    public  class ClassforProgressBar
    {
        /* to be done*/
 
        public int testprogress = 50;

        public int Testprogress { get => testprogress; set => testprogress = value; }

    }
}

namespace Operations
{
    class ClassLoadCfg
    {

        public static string LoadCfg()
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            var UserCfg = System.IO.Path.Combine(currentDirectory + "\\UserConfiguration.txt");
            string allText = File.ReadAllText(UserCfg);

            //abandon -> this method was used to read configuration from .txt format
            return allText;
        }
    }
    class ExcelOperations
    {
        public static string LoadExcelCfgFunction()
        {

            Excel.Application excel = new Excel.Application();
            var currentDirectory = Directory.GetCurrentDirectory();
            var excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[2];

            //load Cfg in the folowing class members

            ClassCfgData.SEntryTime = sheet.Cells[10, 10].Value.ToString();

            ClassCfgData.IntEntryNumber = Convert.ToInt32(sheet.Cells[11, 10].Value);
            ClassCfgData.IntWorkingMinutesDay = Convert.ToInt32(sheet.Cells[12, 10].Value);
            ClassCfgData.IntBrakeTime = Convert.ToInt32(sheet.Cells[13, 10].Value);
            ClassCfgData.IntDayOfTheWeek = Convert.ToInt32(sheet.Cells[14, 10].Value);
            ClassCfgData.IntEntryDate = Convert.ToInt32(sheet.Cells[15, 10].Value);
            ClassCfgData.SEntryTime = DateTime.Now.ToString("HH:mm");
            sheet.Cells[15, 10].Value = ClassCfgData.SEntryTime;

            ClassCfgData.STodayDate = DateTime.Today.ToString("dd / MM / yyyy");
            sheet.Cells[16, 10].Value = ClassCfgData.STodayDate;

            ClassCfgData.SCompareTodayDate = DateTime.Today.ToString("dd / MM / yyyy");
            if (ClassCfgData.SCompareTodayDate == ClassCfgData.STodayDate)
            {
                ClassCfgData.IntOnlineTime = Convert.ToInt32(sheet.Cells[17, 10].Value);
            }
            else {
                ClassCfgData.IntOnlineTime = 0;
                sheet.Cells[16, 10].Value = ClassCfgData.IntOnlineTime;
            }

            wb.Save();
            wb.Close();
            excel.Quit();
            return "ok";
        }

        public static string RecordEntry()
        {

                Excel.Application excel = new Excel.Application();
                var currentDirectory = Directory.GetCurrentDirectory();
                var excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
                Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
                Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[1];
                Excel.Worksheet sheet2 = (Excel.Worksheet)wb.Sheets[2];


                ++ClassCfgData.IntEntryNumber;

                sheet.Cells[(ClassCfgData.IntEntryNumber + 6), 3].value = ClassCfgData.IntEntryNumber;

                sheet2.Cells[11, 10].value = ClassCfgData.IntEntryNumber;

                sheet.Cells[(ClassCfgData.IntEntryNumber + 6), 4].value = DateTime.Now.ToString("HH:mm");

                sheet.Cells[(ClassCfgData.IntEntryNumber + 6), 5].value = DateTime.Today.ToString("dd / MM / yyyy");
           
            wb.Save();
            wb.Close();
            excel.Quit();
           
            return ClassCfgData.IntEntryNumber.ToString();
        }

        public static string ResetData()
        {
            Excel.Application excel = new Excel.Application();
            var currentDirectory = Directory.GetCurrentDirectory();
            var excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[1];
            Excel.Worksheet sheet2 = (Excel.Worksheet)wb.Sheets[2];

            int i;
            for (i = 6; i <= ClassCfgData.IntEntryNumber + 6; i++)
            {
                sheet.Cells[i, 4].value = null;
                sheet.Cells[i, 5].value = null;
                sheet.Cells[i, 3].value = null;
                wb.Save();
            }
            ClassCfgData.IntEntryNumber = 0;
            sheet2.Cells[11, 10].value = ClassCfgData.IntEntryNumber;
            // wb.Save();
            wb.Close();
            excel.Quit();
            return "Records has been deleted successfully";
        }

        public static void CheckExcel()
        {
            ClassCfgData.SCompareTodayDate = DateTime.Today.ToString("dd / MM / yyyy");
            if (ClassCfgData.SCompareTodayDate == ClassCfgData.STodayDate)
            {
                ++ClassCfgData.IntEntryDate;
            }
            else
            {
               // do nothing
            }

            //  ClassCfgData.SCompareTodayDate - ClassCfgData.STodayDate // (EndDate - StartDate).TotalDays
        }


    }
}



namespace DataManipulation

{
    public class ClassCfgData
    {

        public static  string SUserName{ get; set; } 
        public static int IntEntryNumber { get; set; }
        public static string SEntryTime { get; set; }
        public static int IntWorkingMinutesDay { get; set; }
        public static int IntBrakeTime { get; set; }
        public static int IntDayOfTheWeek { get; set; }
        public static int IntTimeLeftDay { get; set; }
        public static int IntTimeLeftWeek { get; set; }
        public static int IntTimeLeftMonth { get; set; }
        public static string STodayDate { get; set; }
        public static string SCompareTodayDate { get; set; }
        public static int IntEntryDate { get; set; }
        public static int IntOnlineTime{ get; set; }
        /* to be continued */
    }
}