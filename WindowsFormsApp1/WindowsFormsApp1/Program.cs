using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ClassForExcelFunction;
using ClassForPanelUtility;

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
        public static void ReadExcelCol(int Start, int Finish)
        {
            /* to be done*/
        }
        public static void WriteExcelCol(int Start, int Finish)
        {
            /* to be done*/
        }

#pragma warning disable 0649
        public struct ExcelCfgTemplate
        {

            public string sUserName;
            public int intEntryNumber;
            public int intWorkingMinutes;
            public int intBrakeTime;
            public int intDayOfTheWeek;
            /* to be continued */
        }
#pragma warning restore 0649
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

namespace ClassForCfg
{
    class ClassLoadCfg
    {

        public static string LoadCfg()
        {
           var currentDirectory = System.IO.Directory.GetCurrentDirectory();
           var UserCfg = System.IO.Path.Combine(currentDirectory + "\\UserConfiguration.txt");
           string allText = File.ReadAllText(UserCfg);

          //abandon
            return allText;
        }
    }


    static class  LoadExcelCfg
    {

        public static string LoadExcelCfgFunction ()
        {

                ClassForExcelFunction.ClassForExcelFunction.ExcelCfgTemplate ExcelConf;
                Excel.Application excel = new Excel.Application();
                var currentDirectory = Directory.GetCurrentDirectory();
                var excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
                Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
                Excel.Worksheet sheet = (Excel.Worksheet)wb.Sheets[2];

                //load Cfg in the folowing struct
                ExcelConf.sUserName = sheet.Cells[10, 10].Value.ToString();
                ExcelConf.intEntryNumber = Convert.ToInt32(sheet.Cells[11, 10].Value);
                ExcelConf.intWorkingMinutes = Convert.ToInt32(sheet.Cells[12, 10].Value);
                ExcelConf.intBrakeTime = Convert.ToInt32(sheet.Cells[13, 10].Value);
                ExcelConf.intDayOfTheWeek = Convert.ToInt32(sheet.Cells[14, 10].Value);

            //Update Cfg in Excel
            ExcelConf.intEntryNumber++;
            ((Excel.Range)sheet.Cells[11, 10]).Value = ExcelConf.intEntryNumber;
            //WorkingMinutes.
            MessageBox.Show(ExcelConf.sUserName + " " + ExcelConf.intEntryNumber);
            wb.Save();  
            wb.Close();
            excel.Quit();
            return "ok";
            }
        }
    }
