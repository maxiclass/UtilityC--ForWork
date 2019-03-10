using DataManipulation;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exit button
        private void button5_Click(object sender, EventArgs e) 
        {
            ClassForPanelUtility.ClassForPanelUtility.ExitAplication();
        }

        //record Data&Time
        private void button2_Click(object sender, EventArgs e) 
        {

        }

        //Load Cfg
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //bar4
        private void progressBar4_Click(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;
            DateTime StartTime = DateTime.Parse(ClassCfgData.SEntryTime);
            TimeSpan timeDifference = NowTime.Subtract(StartTime);

            progressBar4.Maximum = ClassCfgData.IntWorkingMinutesDay;
            progressBar4.Step = 1;
            progressBar4.Value = Convert.ToInt32(timeDifference.TotalMinutes);

            MessageBox.Show("Time Difference (minutes): " + Math.Round(timeDifference.TotalMinutes));
        }
        
        //read
        private void button3_Click(object sender, EventArgs e)
        {
           string message = ClassForExcelFunction.ClassForExcelFunction.ReadExcelCell(6, 5, 2);
            MessageBox.Show(message);
        }

        //Write 
        private void button4_Click(object sender, EventArgs e)
        {
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(8, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(8, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(9, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(9, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(10, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(10, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(11, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(11, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(12, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(12, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));

            MessageBox.Show("Your message was write successfuly");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_SystemColorsChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is developed by Adrian Naziru"); // provide information.
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void somethingElseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 5;
            MessageBox.Show(Operations.ClassLoadCfg.LoadCfg());
            //ClassForCfg.ClassLoadConfiguraiton.LoadCfg();
        }

        private void button4_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //button used for opening Excel file
        {
            System.Diagnostics.Process.Start(ClassForStorageContainers.ExcelDirectoryClass.ExcelPath);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 480;
            progressBar1.Step = 1;
            progressBar1.Value = 5; // final time - current time - pause;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // Operations.ClassLoadCfg.LoadCfg();
            MessageBox.Show(Operations.ExcelOperations.LoadExcelCfgFunction());
            MessageBox.Show(ClassCfgData.IntEntryNumber.ToString());
            MessageBox.Show(DateTime.Now.ToString("HH:mm"));
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Operations.ExcelOperations.RecordEntry());
                
        }
    }
}
