using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            var excelFileLocation = System.IO.Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[sheetnr];
            ((Excel.Range)sheet.Cells[row, col]).Value = data;
            wb.Save();
            wb.Close();
            excel.Quit();
        }
        public static void ReadExcelCol(int Start, int Finish)
        {
            /* to be done*/
        }
        public static void WriteExcelCol(int Start, int Finish)
        {
            /* to be done*/
        }

        struct ExcelConfigurationTemplate
        {
            public char cUserName;
            public int intEntryNumber;
            public int intWorkingHours;
            public int intDayOfTheWeek;
             /* to be continued */ 
        }
    }

}

namespace ClassForStorageContainers
{
    public class StorageClassExcel
    {
        //int inttempvar;
            public static int intEntryNumber { get => intEntryNumber; set => intEntryNumber = value; }
            public int intWorkDayTime { get => intWorkDayTime; set => intWorkDayTime = value; }
            public static double doubleEntryNumber{ get => doubleEntryNumber; set => doubleEntryNumber = value; }
}

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

