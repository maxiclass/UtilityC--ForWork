using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Load Configuration
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //bar4
        private void progressBar4_Click(object sender, EventArgs e)
        {

        }
        
        //read
        private void button3_Click(object sender, EventArgs e)
        {
            ClassForExcelFunction.ClassForExcelFunction.ReadExcelCell(1, 1, 1);
        }

        //Write 
        private void button4_Click(object sender, EventArgs e)
        {
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(5 ,5 ,1, DateTime.Now.ToString("h:mm:ss tt"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(6, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(7, 5, 1, DateTime.Now.ToString("hh:mm tt"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(8, 5, 1, DateTime.Now.ToString("H:mm")); 
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
            // provide information.
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
        
          //  MessageBox.Show(currentDirectory);
        }

        private void button4_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
