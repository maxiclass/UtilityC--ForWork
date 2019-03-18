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
            ModifyProgressBarColor.SetState(BreakTimeBar, 1);
            ModifyProgressBarColor.SetState(TaskTimeBar, 1);

            ActiveTimeBar.Maximum = StorageClassData.IntWorkingMinutes;
            BreakTimeBar.Maximum = StorageClassData.IntBreakMinutes;
            TaskTimeBar.Maximum = StorageClassData.IntStoryPoints * 4 /* hours */ * 60/* minutes */ ;

            ActiveTimeBar.Step = 1;
            BreakTimeBar.Step = 1;
            TaskTimeBar.Step = 1;

            ActiveTimeBar.Value = StorageClassData.IntOnlineTime;
            BreakTimeBar.Value = StorageClassData.IntLogoffTime;
            TaskTimeBar.Value = StorageClassData.IntStoryPointsLeft * 4 /* hours */ * 60/* minutes */ ;

            MessageBox.Show("This application is developed by Adrian Naziru"); // provide information.


        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "http://buhev-jira.conti.de:7090/browse/HD-1660?filter=-1");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { textBox1.Visible = true; }
            else { textBox1.Visible = false; }
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

        }

        private void button8_Click(object sender, EventArgs e)
        {

            ExcelDefine.Exit();
            System.Diagnostics.Process.Start(ExcelDefine.ExcelLocation());
           
        }

        private void ContiForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1minute_Tick(object sender, EventArgs e)
        {
            if (EnableClassData.bEnableOnlineTime)
            {
                ++StorageClassData.IntOnlineTime;
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

            }
           // label3.Text = Math.Round(((Convert.ToDouble(progressBar3.Value) / Convert.ToDouble(progressBar3.Maximum)) * 100), 1).ToString() + "%";
        }

        private void TaskTime_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTime_Click(object sender, EventArgs e)
        {
            StorageClassData.IntWorkingMinutes = Convert.ToInt32(numericUpDown1.Value * 60 + numericUpDown2.Value);
            StorageClassData.IntBreakMinutes = Convert.ToInt32(numericUpDown3.Value * 60 + numericUpDown4.Value);
            groupBox1.Visible = false;

            pictureBox1.Visible = true;
        }
    }
}
