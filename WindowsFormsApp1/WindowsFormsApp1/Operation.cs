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

        public static void TimeKeeping()
        {

            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            var UserCfg = System.IO.Path.Combine(currentDirectory + "\\TimeKeeping.txt");

            foreach (string line in File.ReadLines(UserCfg))
            {
                if (line.Contains("IntOnlineTime"))
                {
                    string[] lines = line.Split('=');
                    ClassCfgData.IntOnlineTime = Convert.ToInt32(lines[1]);
                    MessageBox.Show(ClassCfgData.IntOnlineTime.ToString());

                }
            }


        }
    }
    class ExcelOperations
    {
        public static void Exit()
        {
            Excel.Application excel = new Excel.Application();
            var currentDirectory = Directory.GetCurrentDirectory();
            var excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            Excel.Workbook wb = excel.Workbooks.Open(excelFileLocation);
            wb.Save();
            wb.Close();
            excel.Quit();
        }
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

            ClassCfgData.STodayDate = sheet.Cells[16, 10].Value;
            if (ClassCfgData.STodayDate == DateTime.Today.ToString("dd / MM / yyyy"))
            { }
            else {
                ClassCfgData.STodayDate= DateTime.Today.ToString("dd / MM / yyyy");
                sheet.Cells[16, 10].Value = ClassCfgData.STodayDate;
                ClassCfgData.IntOnlineTime = 0;
                sheet.Cells[18, 10].Value = ClassCfgData.IntOnlineTime;
            }
               
            ClassCfgData.SCurrentTask = sheet.Cells[19, 10].Value;
            ClassCfgData.IntOnlineTime = Convert.ToInt32(sheet.Cells[18, 10].Value);

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



    }
}


