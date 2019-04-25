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
using Revision1._1;
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
            //DownloadPageHttpWebRequest.GetWebData();
            DownloadPageHttpWebRequest.GetWebDatatoXML();
            label2.Text = SCD.StrHtmlResult;


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
                UtilityFunctions.Save();
                ExcelDefine.Workbooks.Save();
                ExcelDefine.Workbooks.Close();
                ExcelDefine.Exit();
                CloseExcelProcess.CloseExcel();
                Application.Exit();
            }
            catch
            {
                //MessageBox.Show("Excel file is in used. Close Excel file first");
                
                Application.Exit();
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
            if (ECD.bClearPanel)
            {
                ActiveTimeNr.Text = SCD.IntOnlineTime.ToString();
                TotalTimeNr.Text = SCD.IntTotalTimeInDay.ToString();
                OfflineTotalTime.Text = SCD.IntTotalOfflineTime.ToString();
                progressBar1.Value = SCD.IntTotalOfflineTime;
                
                ModifyProgressBarColor.SetState(progressBar1, 1); //Green
                ECD.bEnableOvertime = false;
                OvertimeLabel.Visible = false;
                OvertimeLabel.Text = "Overtime: " + SCD.IntOvertime.ToString();
                SCD.IntOvertime = 0;
                ECD.bClearPanel = false;
            }
            else
            {

            }
        }

        private void timer1Watch_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= (progressBar1.Maximum - 3))
            {
                ECD.bEnableOvertime = true;
                OvertimeLabel.Visible = true;


                ModifyProgressBarColor.SetState(progressBar1, 2); //Red

            }
            if (ECD.bEnableOvertime != true)
            {
                try
                {
                    progressBar1.Value = SCD.IntTotalTimeInDay;
                }
                catch
                {
                    progressBar1.Value = progressBar1.Maximum;
                }

            }
            else if (ECD.bEnableOvertime == true)
            {
             
                ++SCD.IntOvertime;
                OvertimeLabel.Text = "Overtime: " + SCD.IntOvertime.ToString();
                ModifyProgressBarColor.SetState(progressBar1, 2); //Red
            }

            ++SCD.IntTotalTimeInDay;
            TotalTimeNr.Text = (SCD.IntTotalTimeInDay / 60) + " h :" + (SCD.IntTotalTimeInDay % 60) + " m";

            if (ECD.bEnableOnlineTime == true)
            {
                ++SCD.IntOnlineTime;
                ActiveTimeNr.Text =  (SCD.IntOnlineTime / 60) + " h :" + (SCD.IntOnlineTime % 60) + " m";

            }
            else if (ECD.bEnableBreakTime == true)
            {
                ++SCD.IntLockTimeStart;
                ++SCD.IntTotalOfflineTime;
                OfflineTotalTime.Text = (SCD.IntTotalOfflineTime / 60) + " h :" + (SCD.IntTotalOfflineTime % 60) + " m";

            }
        }

        private void BreakButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BreakButton.Checked == true)
            {
                UtilityFunctions.Record("LOCK", ""); //LOCK event , no comment 
                ECD.bEnableBreakTime = true;
                ECD.bEnableOnlineTime = false;
                SCD.IntLockTimeStart = 0;
            }
            else
            {
                UtilityFunctions.Record("UNLOCK", SCD.IntLockTimeStart.ToString() + " min break"); //LOCK event , time of the break
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

            ActiveTimeNr.Text =  (SCD.IntOnlineTime / 60) + " h :" + (SCD.IntOnlineTime % 60) + " m";

            OfflineTotalTime.Text = (SCD.IntTotalOfflineTime / 60) + " h :" + (SCD.IntTotalOfflineTime % 60) + " m";
            TaskIDStripTextBox1.Text = SCD.StrCurrentTaskID.ToString();
            TaskIDlabel.Text = SCD.StrCurrentTaskID.ToString();
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


        private void MainMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ExitStripMenuItem1_Click(object sender, EventArgs e)
        {
            UtilityFunctions.Exit();
        }

        private void ChangeLinkTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CurrentTaskLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ChangeLinkConfirmStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChangeLinkTextBox.Text == "" || ChangeLinkTextBox.Text == " ")
            {

            }
            else
            {
                SCD.StrCurrentTaskLink = ChangeLinkTextBox.Text;
                ExcelDefine.Sheet2.Cells[24, 4] = SCD.StrCurrentTaskLink;
            }
        }

        private void ChangeLinkConfirmStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ChangeLinkConfirmStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            ChangeLinkConfirmStripMenuItem.Image = Revision1._1.Properties.Resources.accept;

        }

        private void ChangeLinkConfirmStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ChangeLinkConfirmStripMenuItem.Image = null;
        }

        private void OpenExcelMenuItem_Click(object sender, EventArgs e)
        {
            ExcelDefine.Workbooks.Save();
            ExcelDefine.Workbooks.Close();
            ExcelDefine.Exit();
            CloseExcelProcess.CloseExcel();
            Process.Start(ExcelDefine.ExcelLocation());
            Application.Exit();

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityFunctions.Save();
        }

        private void To_do_MouseEnter(object sender, EventArgs e)
        {
            To_do.Image = Revision1._1.Properties.Resources.accept;
        }

        private void To_do_MouseLeave(object sender, EventArgs e)
        {
            if (TaskStatus.Text != "To do")
            { To_do.Image = null; }

        }

        private void In_progress_MouseEnter(object sender, EventArgs e)
        {
            In_progress.Image = Revision1._1.Properties.Resources.accept;
        }

        private void In_progress_MouseLeave(object sender, EventArgs e)
        {
            if (TaskStatus.Text != "In progress")
            { In_progress.Image = null; }
        }

        private void Commit_MouseEnter(object sender, EventArgs e)
        {
            Commit.Image = Revision1._1.Properties.Resources.accept;
        }

        private void Commit_MouseLeave(object sender, EventArgs e)
        {
            if (TaskStatus.Text != "Commit")
            { Commit.Image = null; }
        }

        private void Review_MouseEnter(object sender, EventArgs e)
        {
            Review.Image = Revision1._1.Properties.Resources.accept;
        }

        private void Review_MouseLeave(object sender, EventArgs e)
        {
            if (TaskStatus.Text != "Review")
            { Review.Image = null; }
        }

        private void Rework_MouseEnter(object sender, EventArgs e)
        {
            Rework.Image = Revision1._1.Properties.Resources.accept;
        }

        private void Rework_MouseLeave(object sender, EventArgs e)
        {
            if (TaskStatus.Text != "Rework")
            { Rework.Image = null; }
        }

        private void Done_MouseEnter(object sender, EventArgs e)
        {
            Done.Image = Revision1._1.Properties.Resources.accept;
        }

        private void Done_MouseLeave(object sender, EventArgs e)
        {
            if (TaskStatus.Text != "Done")
            { Done.Image = null; }

         
        }


        private void OpenExcelMenuItem_MouseEnter(object sender, EventArgs e)
        {
            OpenExcelMenuItem.Image = Revision1._1.Properties.Resources.accept;
        }

        private void OpenExcelMenuItem_MouseLeave(object sender, EventArgs e)
        {
            OpenExcelMenuItem.Image = null;
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            DeleteRecordMenuItem.Image = Revision1._1.Properties.Resources.accept;
        }

        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            DeleteRecordMenuItem.Image = null;
        }

        private void SaveToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            SaveToolStripMenuItem.Image = Revision1._1.Properties.Resources.accept;
        }

        private void SaveToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            SaveToolStripMenuItem.Image = null;
        }

        private void ExitStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            ExitStripMenuItem1.Image = Revision1._1.Properties.Resources.accept;
        }

        private void ExitStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            ExitStripMenuItem1.Image = null;
        }

        private void DeleteRecordMenuItem1_Click(object sender, EventArgs e)
        {
            UtilityFunctions.DeleteRecords();
        }

        private void ChangeTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                timer1Watch.Interval = Convert.ToInt32(ChangeTimeUpDown.Value);
            }
            catch {
                ChangeTimeUpDown.Value = 1000;
                timer1Watch.Interval = 1000;
            }
          
        }

        private void ContiApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            UtilityFunctions.Exit();
        }

        private void MExitStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityFunctions.Exit();
        }

        private void MSaveStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityFunctions.Save();
        }

        private void MdeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityFunctions.DeleteRecords();
        }

        private void MopenExcelMenuItem1_Click(object sender, EventArgs e)
        {
            ExcelDefine.Workbooks.Save();
            ExcelDefine.Workbooks.Close();
            ExcelDefine.Exit();
            CloseExcelProcess.CloseExcel();
            Process.Start(ExcelDefine.ExcelLocation());
            Application.Exit();

        }

        private void Current_TaskMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/issues/?filter=-1");
        }

        private void OpenTools_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void treeView1_MouseEnter(object sender, EventArgs e)
        {
      
        }

        private void CommentBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CommentBox.Text == "" || CommentBox.Text == " ")
            {

            }
            else
            {
                UtilityFunctions.Record("Comment", CommentBox.Text);
                CommentBox.Text = "";
            }

        }

        private void ConfirmTaskIDStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TaskIDStripTextBox1.Text != "" && TaskIDStripTextBox1.Text != " ")
            {
                SCD.StrCurrentTaskID = TaskIDStripTextBox1.Text;
                UtilityFunctions.Record("Task Changed", SCD.StrCurrentTaskID);
                MessageBox.Show("Task id changed successfully");
                ExcelDefine.Sheet2.Cells[27, 4] = SCD.StrCurrentTaskID;
                TaskIDlabel.Text = SCD.StrCurrentTaskID;
            }
            else
            { MessageBox.Show("Write new task id first"); }
        }


        private void OpenTools_MouseHover(object sender, EventArgs e)
        {

        }

        private void OpenTools_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void OpenTools_MouseLeave(object sender, EventArgs e)
        {
           // treeView1.Visible = false;

        }

        private void TimerConversionLabel_Click(object sender, EventArgs e)
        {
            TimerConversionLabel.Text = (SCD.IntOnlineTime/60) + " h :" + (SCD.IntOnlineTime%60) + " m";
        }

        private void ContiApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void ButtonTest1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void ChangeTools_Click(object sender, EventArgs e)
        {
            ToolsForm toolsform = new ToolsForm();
            toolsform.ShowDialog();
        }
    }
}
