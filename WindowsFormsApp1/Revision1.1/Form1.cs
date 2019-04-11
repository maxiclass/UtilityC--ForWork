using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void OfflineTotalTime_Click(object sender, EventArgs e)
        {

        }

        private void TimePassed_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Excel file is in used. Close Excel file first");
                }
           }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OpenTools_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/browse/HD-1660?filter=-1");
            Process.Start("chrome.exe", "http://gerrit-p-eu:8080/#/q/status:open");
            Process.Start("chrome.exe", "http://collab-p:4500/ui#");
            Process.Start("outlook.exe");
            Process.Start("lync.exe");
            Process.Start("TOTALCMD64.EXE");
        }

        private void OpenExcel_Click(object sender, EventArgs e)
        {
            ExcelDefine.Workbooks.Save();
            ExcelDefine.Workbooks.Close();
            ExcelDefine.Exit();
            CloseExcelProcess.CloseExcel();
            Application.Exit();
            Process.Start(ExcelDefine.ExcelLocation());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/issues/?filter=-1");
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            Debug.Text = "debug = " + SCD.IntRecordNumber + SCD.IntEntryNumber + SCD.IntOnlineTime + SCD.IntPlannedWorkingTime + " " ;
        }
    }
}
