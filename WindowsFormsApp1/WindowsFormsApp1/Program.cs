using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
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

        public static void ReadExcelCell(int row,int col,int sheetnr)
        {
            Excel.Application excel = new Excel.Application();
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            var excelFileLocation = System.IO.Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[sheetnr];
            var LastEntryNumber = ((Excel.Range)sheet.Cells[row, col]);
            string strLastEntryNumber;
            strLastEntryNumber = LastEntryNumber.Text;
           // wb.Save();
           // wb.Close();
            excel.Quit();
           // return strLastEntryNumber;
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

    }

}

namespace ClassForStorageContainers
{
    public class IntegerStorageClassExcel
    {
        int inttempvar;
            public int intTempvar { get => inttempvar; set => inttempvar = value; }
    }


    public class StringStorageClassExcel
    {
        string strtempvar;
        public string strTempvar { get => strtempvar; set => strtempvar = value; }
    }

    public static class VectorStorageClassExcel
    {
        /* to be done*/
    }

    public static class MatrixStorageClassExcel
    {
        /* to be done*/
    }
    public class ExcelDirectoryClass
    {
        static string currentDirectory = System.IO.Directory.GetCurrentDirectory();
        static string excelFileLocation = System.IO.Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
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

