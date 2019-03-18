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
using ExcelInit;

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
            if (typeof(double) == ((Excel.Range)ExcelOpen.Sheet.Cells[row, col]).Value.Cells[row, col].Value.GetType())
            {
              StringReadValue = ((Excel.Range)ExcelOpen.Sheet.Cells[row, col]).Value.Cells[row, col].Value.ToString();
            }
            else
            {
                StringReadValue = ((Excel.Range)ExcelOpen.Sheet.Cells[row, col]).Value.Cells[row, col].Value;
            }
            object LastEntryNumber = ((Excel.Range)ExcelOpen.Sheet.Cells[row, col]).Value.Cells[row, col];
            //ClassForStorageContainers.StorageClassExcel.doubleEntryNumber = LastEntryNumber; //Int32.Parse(LastEntryNumber.text);
            ExcelOpen.Workbooks.Save();
            return StringReadValue;

        }
        public static void WriteExcelCell(int row, int col, int sheetnr, string data )
        {
            ((Excel.Range)ExcelOpen.Sheet.Cells[row, col]).Value = data;
            ExcelOpen.Workbooks.Save();

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


