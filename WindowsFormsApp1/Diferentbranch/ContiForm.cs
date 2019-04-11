using Diferentbranch;
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

namespace Differentbranch
{
    public partial class ContiForm : Form
    {
        public ContiForm()
        {
            InitializeComponent();

            /* this code will update current form with loaded configuration from init */
            // Note the second parameter in SetState, 1 = normal(green); 2 = error(red); 3 = warning(yellow).
            ModifyProgressBarColor.SetState(ActiveTimeBar, 1);
         
            ModifyProgressBarColor.SetState(TaskTimeBar, 1);

            ActiveTimeBar.Maximum = StorageClassData.IntWorkingMinutes;
            
            TaskTimeBar.Maximum = StorageClassData.IntStoryPoints * 4 /* hours */ * 60/* minutes */ ;

            ActiveTimeBar.Step = 1;
            
            TaskTimeBar.Step = 1;

            if (StorageClassData.IntOnlineTime >= ActiveTimeBar.Maximum) { ActiveTimeBar.Maximum = StorageClassData.IntOnlineTime; } else { }
            ActiveTimeBar.Value = StorageClassData.IntOnlineTime;
            
            TaskTimeBar.Value = StorageClassData.IntStoryPointsLeft * 4 /* hours */ * 60/* minutes */ ;

            //MessageBox.Show("This application is developed by Adrian Naziru"); // provide information.
        

        }
       
        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { CommentBox.Visible = true; }
            else { CommentBox.Visible = false; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1minute.Enabled = false;
            ExcelDefine.Workbooks.Save();
            ExcelDefine.Workbooks.Close();
            ExcelDefine.Exit();
            CloseExcelProcess.CloseExcel();
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("This application is developed by Adrian Naziru"); // provide information about developer or about the app.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ContiForm_Load(object sender, EventArgs e)
        {

        }

        public void Timer1minute_Tick(object sender, EventArgs e)
        {
            OfflineTotalTime.Text = StorageClassData.TotalDayBreakTime.ToString();
            if (EnableClassData.bEnableOvertime)
            {
                EnableClassData.bEnableOnlineTime = false;
                ++StorageClassData.IntOnlineTime;

                Overtime_label.Visible = true;
                Overtime_label.BringToFront();
                Overtime_label.Text= (StorageClassData.IntOnlineTime - StorageClassData.IntWorkingMinutes).ToString() + "min";
                ExcelDefine.Sheet2.Cells[19, 10].Value = StorageClassData.IntOnlineTime;
            }

            if (EnableClassData.bEnableOnlineTime == true && EnableClassData.bEnableOvertime == false)
            {
                ++StorageClassData.IntOnlineTime;

                //Create a notify icon on the buttom right of the screen
                TimePassed.Visible = true;
                TimePassed.Text = StorageClassData.IntOnlineTime.ToString() + "min";


                if (StorageClassData.IntOnlineTime >= ActiveTimeBar.Maximum) { ActiveTimeBar.Maximum = StorageClassData.IntOnlineTime; } else { }
                ActiveTimeBar.Value = StorageClassData.IntOnlineTime;
                ExcelDefine.Sheet2.Cells[19, 10].Value = StorageClassData.IntOnlineTime;
                ActiveTimeProcent.Text = Math.Round(((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100), 1).ToString() + "%";
                if (((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100) > 35)
                {
                    if (((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100) < 65)
                    {
                        ModifyProgressBarColor.SetState(ActiveTimeBar, 3);
                    }
                    else
                    {
                        ModifyProgressBarColor.SetState(ActiveTimeBar, 2);
                    }
                }
                else
                { ModifyProgressBarColor.SetState(ActiveTimeBar, 1); }

                /* Enable overtime counting */
                if (StorageClassData.IntOnlineTime >= StorageClassData.IntWorkingMinutes)
                { EnableClassData.bEnableOvertime = true; }
                else { }

            }

        }

        private void TaskTime_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTime_Click(object sender, EventArgs e)
        {
            StorageClassData.IntWorkingMinutes = Convert.ToInt32(numericUpDown1.Value * 60 + numericUpDown2.Value);
            StorageClassData.IntBreakMinutes = Convert.ToInt32(numericUpDown3.Value * 60 + numericUpDown4.Value);
            ActiveTimeBar.Maximum = StorageClassData.IntWorkingMinutes;
            OfflineTotalTime.Text = StorageClassData.TotalDayBreakTime.ToString();
            //groupBox1.Visible = false;
            ExcelDefine.Sheet2.Cells[12, 10].Value=StorageClassData.IntWorkingMinutes;
            ExcelDefine.Sheet2.Cells[13, 10].Value= StorageClassData.IntBreakMinutes;
            ExcelDefine.Workbooks.Save();
            ActiveTimeBar.Value = StorageClassData.IntOnlineTime;
            ActiveTimeProcent.Text = Math.Round(((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100), 1).ToString() + "%";


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void timer5minutes(object sender, EventArgs e)
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

        private void Exit_Click(object sender, EventArgs e)
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

        private void OpenExcel_Click(object sender, EventArgs e)
        {
            timer1minute.Enabled = false;
            ExcelDefine.Workbooks.Save();
            ExcelDefine.Workbooks.Close();
            ExcelDefine.Exit();
            CloseExcelProcess.CloseExcel();
            Application.Exit();
            Process.Start(ExcelDefine.ExcelLocation());
        }

        public void RecordEvent_Click(object sender, EventArgs e)
        {
            ++StorageClassData.IntEntryNumber;
            ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 3] = StorageClassData.IntEntryNumber;
            ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 4] = DateTime.Now.ToString("HH:mm");
            ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 5] = DateTime.Today.ToString("dd / MM / yyyy");
            ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 7] = CommentBox.Text;
            ExcelDefine.Sheet2.Cells[11, 10].Value = StorageClassData.IntEntryNumber;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void CommentBox_Changed(object sender, EventArgs e)
        {
            ExcelDefine.Sheet.Cells[StorageClassData.IntEntryNumber + 4, 7] =CommentBox.Text;
        }

        private void ActiveTimeBar_Click(object sender, EventArgs e)
        {

        }

        private void InitiAppTimer(object sender, EventArgs e)
        {
            TaskTimeBar.Value = StorageClassData.IntStoryPointsLeft * 10;
            TaskTimeBar.Maximum = StorageClassData.IntStoryPoints * 10; 
            OfflineTotalTime.Text = StorageClassData.TotalDayBreakTime.ToString();
            StorageClassData.IntOnlineTime = Convert.ToInt32(ExcelDefine.Sheet2.Cells[19, 10].Value());
            if (EnableClassData.bEnableOvertime)
            {

                EnableClassData.bEnableOnlineTime = false;
                ++StorageClassData.IntOnlineTime;

                Overtime_label.Visible = true;
                Overtime_label.BringToFront();
                Overtime_label.Text = (StorageClassData.IntOnlineTime - StorageClassData.IntWorkingMinutes).ToString() + "min";
                ExcelDefine.Sheet2.Cells[19, 10].Value = StorageClassData.IntOnlineTime;
            }

            if (EnableClassData.bEnableOnlineTime == true && EnableClassData.bEnableOvertime == false)
            {
                ++StorageClassData.IntOnlineTime;
                TimePassed.Visible = true;
                TimePassed.Text = StorageClassData.IntOnlineTime.ToString() + "min";
                if (StorageClassData.IntOnlineTime >= ActiveTimeBar.Maximum) { ActiveTimeBar.Maximum = StorageClassData.IntOnlineTime; } else { }
                ActiveTimeBar.Value = StorageClassData.IntOnlineTime;
                ExcelDefine.Sheet2.Cells[19, 10].Value = StorageClassData.IntOnlineTime;
                ActiveTimeProcent.Text = Math.Round(((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100), 1).ToString() + "%";
                if (((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100) > 35)
                {
                    if (((Convert.ToDouble(ActiveTimeBar.Value) / Convert.ToDouble(ActiveTimeBar.Maximum)) * 100) < 65)
                    {
                        ModifyProgressBarColor.SetState(ActiveTimeBar, 3);
                    }
                    else
                    {
                        ModifyProgressBarColor.SetState(ActiveTimeBar, 2);
                    }
                }
                else
                { ModifyProgressBarColor.SetState(ActiveTimeBar, 1); }

                // Offline Total Time Value label
                OfflineTotalTime.Text = StorageClassData.TotalDayBreakTime + " min" ;

                /* Enable overtime counting */
                if (StorageClassData.IntOnlineTime >= StorageClassData.IntWorkingMinutes)
                { EnableClassData.bEnableOvertime = true; }
                else { }

            }
            InitiTimer.Enabled = false;
        }

        private void EventsTimer_Tick(object sender, EventArgs e)
        {

        }

        private void LockTimeBar_Click(object sender, EventArgs e)
        {

        }

        private void TimePassed_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

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

        private void OfflineTotalTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1minute2_Tick(object sender, EventArgs e)
        {
            StorageClassData.TotalDayBreakTime++;
            OfflineTotalTime.Text = StorageClassData.TotalDayBreakTime.ToString();

        }

        private void TaskTimeProcent_Click(object sender, EventArgs e)
        {

        }

        private void CurrentTaskLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/browse/HD-1660?filter=-1");
        }
    }
}
