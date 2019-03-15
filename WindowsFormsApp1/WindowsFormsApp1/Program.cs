using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ClassForExcelFunction;
using ClassForPanelUtility;
using DataManipulation;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

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
            ClassCfgData.IntBrakeTimeEnable = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContiApp());
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
