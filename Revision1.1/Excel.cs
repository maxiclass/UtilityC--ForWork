using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace UtilityApp
{
    class ExcelDefine
    {
        public static string ExcelLocation()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var excelFileLocation = Path.Combine(currentDirectory + "\\Revision.xlsx");
            return excelFileLocation;
        }
        public static Excel.Application excel = new Excel.Application();
        public static Excel.Workbook Workbooks = excel.Workbooks.Open(ExcelDefine.ExcelLocation());
        public static Excel.Worksheet Sheet = (Excel.Worksheet)Workbooks.Sheets[1];
        public static Excel.Worksheet Sheet2 = (Excel.Worksheet)Workbooks.Sheets[2];
        public static Excel.Worksheet Sheet3 = (Excel.Worksheet)Workbooks.Sheets[3];
        public static void Exit()
        {
            excel.Quit();
        }

        public static string ReadExcelCell(int row, int col, int sheetnr)
        {
            string StringReadValue;
            if (typeof(double) == (Sheet.Cells[row, col]).Value.Cells[row, col].Value.GetType())
            {
                StringReadValue = (Sheet.Cells[row, col]).Value.Cells[row, col].Value.ToString();
            }
            else
            {
                StringReadValue = (Sheet.Cells[row, col]).Value.Cells[row, col].Value;
            }
            object LastEntryNumber = (Sheet.Cells[row, col]).Value.Cells[row, col];
            return StringReadValue;
        }

        public static void WriteExcelCell(int row, int col, int sheetnr, string data)
        {
            Sheet.Cells[row, col].Value = data;
            Workbooks.Save();

        }
        public static void Save()
        {
            try {
                Workbooks.Save();
            }

            catch {
                //do nothing for 
            }
        }

    }
}

namespace UtilityApp
{
    static class CloseExcelProcess
    {
        public static void CloseExcel()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("EXCEL.EXE *32"))
                {
                    proc.Kill();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}