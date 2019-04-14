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
    public partial class ContiApp : Form
    {
        public ContiApp()
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
            try
            {
                Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/browse/HD-1660?filter=-1");
                Process.Start("chrome.exe", "http://gerrit-p-eu:8080/#/q/status:open");
                Process.Start("chrome.exe", "http://collab-p:4500/ui#");
                Process.Start("outlook.exe");
                Process.Start("lync.exe");
            }
            catch
            {
            }

        }

        private void OpenExcel_Click(object sender, EventArgs e)
        {
            ExcelDefine.Workbooks.Save();
            ExcelDefine.Workbooks.Close();
            ExcelDefine.Exit();
            CloseExcelProcess.CloseExcel();
            Process.Start(ExcelDefine.ExcelLocation());
            Application.Exit();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void Debug_Click(object sender, EventArgs e)
        {
            Debug.Text = "debug = " + SCD.IntRecordNumber + SCD.IntEntryNumber + SCD.IntOnlineTime + SCD.IntPlannedWorkingTime + " ";

        }

        private void timer1_minute1_Tick(object sender, EventArgs e)
        {
            ++SCD.IntTotalTimeInDay;
            TotalTimeNr.Text = SCD.IntTotalTimeInDay.ToString();
        }

        private void timer1offline_Tick(object sender, EventArgs e)
        {

        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {

        }

        private void timer1Watch_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= (progressBar1.Maximum - 1))
            {
                ECD.bEnableOvertime = true;
                ModifyProgressBarColor.SetState(progressBar1, 2); //Red

            }
            if (ECD.bEnableOvertime != true)
            {
                progressBar1.Value = SCD.IntTotalTimeInDay;
            }
            else if (ECD.bEnableOvertime == true)
            {

                ++SCD.IntOvertime;
                Overtime.Text = "Overtime: " + SCD.IntOvertime.ToString();
            }

            ++SCD.IntTotalTimeInDay;
            TotalTimeNr.Text = SCD.IntTotalTimeInDay.ToString();

            if (ECD.bEnableOnlineTime == true)
            {
                ++SCD.IntOnlineTime;
                ActiveTimeNr.Text = SCD.IntOnlineTime.ToString();
            }
            else if (ECD.bEnableBreakTime == true)
            {
                ++SCD.IntLockTimeStart;
                ++SCD.IntTotalOfflineTime;
                OfflineTotalTime.Text = SCD.IntTotalOfflineTime.ToString();
            }
        }

        private void BreakButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BreakButton.Checked == true)
            {

                ECD.bEnableBreakTime = true;
                ECD.bEnableOnlineTime = false;
            }
            else
            {
                ECD.bEnableBreakTime = false;
                ECD.bEnableOnlineTime = true;
            }
        }

        private void TimePassed_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void TimePassed_Click(object sender, EventArgs e)
        {
            //Make form visible again
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SCD.IntPlannedWorkingTime = Convert.ToInt32(numericUpDown5.Value * 60) + Convert.ToInt32(numericUpDown6.Value);
            ExcelDefine.Sheet2.Cells[21, 4] = SCD.IntPlannedWorkingTime.ToString();
            progressBar1.Maximum = SCD.IntPlannedWorkingTime;
        }

        private void Autosave_Tick(object sender, EventArgs e)
        {
            UtilityFunctions.Save();
        }




        private void listBox1_Click(object sender, EventArgs e)
        {
            //label1.Text = listBox1.SelectedItem.ToString();
        }



        private void listBox1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void InitTimer_Tick(object sender, EventArgs e)
        {
            TaskStatus.Text = SCD.StrCurrentTaskStatus.ToString();
            ActiveTimeNr.Text = "0";
            OfflineTotalTime.Text = "0";
            InitTimer.Enabled = false;
        }




        private void Record_Click(object sender, EventArgs e)
        {
            UtilityFunctions.Record(" Manual Record", "Button"); // no event // no comment

        }



        private void CommentBox_Validated(object sender, EventArgs e)
        {
            if(CommentBox.Text == "" || CommentBox.Text == " ")
            {

            }
            else
            {
                UtilityFunctions.Record("Comment", CommentBox.Text);
                CommentBox.Text = "";
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void OfflineTotalTime_Click_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/issues/?filter=-1");
        }

        private void ChangeLinkTextBox_Validated(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskLink = ChangeLinkTextBox.Text;
            ExcelDefine.Sheet2.Cells[24, 4] = ChangeLinkTextBox.Text;
        }

        private void To_do_Click(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskStatus = To_do.Text;
            ExcelDefine.Sheet2.Cells[25, 4] = SCD.StrCurrentTaskStatus;
            TaskStatus.Text = SCD.StrCurrentTaskStatus;
            UtilityFunctions.Record(" Task Status Changed", SCD.StrCurrentTaskStatus); // Task Status Changed //  new status
        }

        private void In_progress_Click(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskStatus = In_progress.Text;
            ExcelDefine.Sheet2.Cells[25, 4] = SCD.StrCurrentTaskStatus;
            TaskStatus.Text = SCD.StrCurrentTaskStatus;
            UtilityFunctions.Record(" Task Status Changed", SCD.StrCurrentTaskStatus); // Task Status Changed //  new status
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskStatus = Commit.Text;
            ExcelDefine.Sheet2.Cells[25, 4] = SCD.StrCurrentTaskStatus;
            TaskStatus.Text = SCD.StrCurrentTaskStatus;
            UtilityFunctions.Record(" Task Status Changed", SCD.StrCurrentTaskStatus); // Task Status Changed //  new status
        }

        private void Review_Click(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskStatus = Review.Text;
            ExcelDefine.Sheet2.Cells[25, 4] = SCD.StrCurrentTaskStatus;
            TaskStatus.Text = SCD.StrCurrentTaskStatus;
            UtilityFunctions.Record(" Task Status Changed", SCD.StrCurrentTaskStatus); // Task Status Changed //  new status
        }

        private void Rework_Click(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskStatus = Rework.Text;
            ExcelDefine.Sheet2.Cells[25, 4] = SCD.StrCurrentTaskStatus;
            TaskStatus.Text = SCD.StrCurrentTaskStatus;
            UtilityFunctions.Record(" Task Status Changed", SCD.StrCurrentTaskStatus); // Task Status Changed //  new status
        }

        private void Done_Click(object sender, EventArgs e)
        {
            SCD.StrCurrentTaskStatus = Done.Text;
            ExcelDefine.Sheet2.Cells[25, 4] = SCD.StrCurrentTaskStatus;
            TaskStatus.Text = SCD.StrCurrentTaskStatus;
            UtilityFunctions.Record(" Task Status Changed", SCD.StrCurrentTaskStatus); // Task Status Changed //  new status
        }

        private void CurrentTaskLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/issues/?filter=-1");
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ExitStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}
