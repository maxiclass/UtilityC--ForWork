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

namespace Check
{
    class Check
        {
        public static string vCheck()
        {
          var currentDirectory = Directory.GetCurrentDirectory();
          var excelFileLocation = Path.Combine(currentDirectory + "\\UtilityExcel.xlsx");
            return excelFileLocation;
        }
    }

}

namespace ExcelInit
{
    class ExcelOpen
    {
        public void Excel ()
        {
        }
        public static Excel.Application excel = new Excel.Application();
        public static Excel.Workbook Workbooks = excel.Workbooks.Open(Check.Check.vCheck());
        public static Excel.Worksheet Sheet = (Excel.Worksheet)Workbooks.Sheets[1];
        public static Excel.Worksheet Sheet2 = (Excel.Worksheet)Workbooks.Sheets[2];

    }

}