namespace UtilityApp
{
    partial class ContiApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContiApp));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OfflineTotalTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Testbutton = new System.Windows.Forms.Button();
            this.OpenExcel = new System.Windows.Forms.Button();
            this.OpenTools = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.sadsa = new System.Windows.Forms.Label();
            this.ActiveTimeNr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimePassed = new System.Windows.Forms.NotifyIcon(this.components);
            this.CurrentTaskLink = new System.Windows.Forms.LinkLabel();
            this.Debug = new System.Windows.Forms.Label();
            this.timer1_minute1 = new System.Windows.Forms.Timer(this.components);
            this.timer1offline = new System.Windows.Forms.Timer(this.components);
            this.timer1Watch = new System.Windows.Forms.Timer(this.components);
            this.TotalTime = new System.Windows.Forms.Label();
            this.TotalTimeNr = new System.Windows.Forms.Label();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.BreakButton = new System.Windows.Forms.CheckBox();
            this.Overtime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 170);
            this.progressBar1.Maximum = 480;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // OfflineTotalTime
            // 
            this.OfflineTotalTime.AutoSize = true;
            this.OfflineTotalTime.Location = new System.Drawing.Point(110, 45);
            this.OfflineTotalTime.Name = "OfflineTotalTime";
            this.OfflineTotalTime.Size = new System.Drawing.Size(60, 13);
            this.OfflineTotalTime.TabIndex = 7;
            this.OfflineTotalTime.Text = "OfflineTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(116, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Testbutton
            // 
            this.Testbutton.BackColor = System.Drawing.SystemColors.MenuText;
            this.Testbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Testbutton.Location = new System.Drawing.Point(134, 40);
            this.Testbutton.Name = "Testbutton";
            this.Testbutton.Size = new System.Drawing.Size(104, 21);
            this.Testbutton.TabIndex = 32;
            this.Testbutton.Text = "Test";
            this.Testbutton.UseVisualStyleBackColor = false;
            this.Testbutton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // OpenExcel
            // 
            this.OpenExcel.BackColor = System.Drawing.Color.Black;
            this.OpenExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold);
            this.OpenExcel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenExcel.Location = new System.Drawing.Point(134, 65);
            this.OpenExcel.Name = "OpenExcel";
            this.OpenExcel.Size = new System.Drawing.Size(104, 22);
            this.OpenExcel.TabIndex = 33;
            this.OpenExcel.Text = "Open Excel";
            this.OpenExcel.UseVisualStyleBackColor = false;
            this.OpenExcel.Click += new System.EventHandler(this.OpenExcel_Click);
            // 
            // OpenTools
            // 
            this.OpenTools.BackColor = System.Drawing.SystemColors.MenuText;
            this.OpenTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTools.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenTools.Location = new System.Drawing.Point(134, 90);
            this.OpenTools.Name = "OpenTools";
            this.OpenTools.Size = new System.Drawing.Size(104, 21);
            this.OpenTools.TabIndex = 34;
            this.OpenTools.Text = "Open Tools";
            this.OpenTools.UseVisualStyleBackColor = false;
            this.OpenTools.Click += new System.EventHandler(this.OpenTools_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(12, 115);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(237, 22);
            this.CommentBox.TabIndex = 39;
            this.CommentBox.Text = "";
            // 
            // sadsa
            // 
            this.sadsa.AutoSize = true;
            this.sadsa.BackColor = System.Drawing.Color.Transparent;
            this.sadsa.Location = new System.Drawing.Point(109, 93);
            this.sadsa.Name = "sadsa";
            this.sadsa.Size = new System.Drawing.Size(37, 13);
            this.sadsa.TabIndex = 41;
            this.sadsa.Text = "Status";
            this.sadsa.Click += new System.EventHandler(this.OfflineTotalTime_Click);
            // 
            // ActiveTimeNr
            // 
            this.ActiveTimeNr.AutoSize = true;
            this.ActiveTimeNr.BackColor = System.Drawing.Color.Transparent;
            this.ActiveTimeNr.Location = new System.Drawing.Point(108, 20);
            this.ActiveTimeNr.Name = "ActiveTimeNr";
            this.ActiveTimeNr.Size = new System.Drawing.Size(60, 13);
            this.ActiveTimeNr.TabIndex = 43;
            this.ActiveTimeNr.Text = "ActiveTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Offline Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Active Time";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.AllowDrop = true;
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.numericUpDown5.Location = new System.Drawing.Point(17, 40);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(41, 22);
            this.numericUpDown5.TabIndex = 48;
            this.numericUpDown5.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.AllowDrop = true;
            this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.numericUpDown6.Location = new System.Drawing.Point(61, 40);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(41, 22);
            this.numericUpDown6.TabIndex = 47;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Task Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(345, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sadsa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OfflineTotalTime);
            this.groupBox1.Controls.Add(this.ActiveTimeNr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(255, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 109);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Task Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(108, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Status";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(13, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 21);
            this.button1.TabIndex = 55;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimePassed
            // 
            this.TimePassed.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TimePassed.BalloonTipText = "Info";
            this.TimePassed.BalloonTipTitle = "Info";
            this.TimePassed.Icon = ((System.Drawing.Icon)(resources.GetObject("TimePassed.Icon")));
            this.TimePassed.Visible = true;
            this.TimePassed.BalloonTipClicked += new System.EventHandler(this.TimePassed_BalloonTipClicked);
            this.TimePassed.Click += new System.EventHandler(this.TimePassed_Click);
            this.TimePassed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TimePassed_MouseDoubleClick);
            // 
            // CurrentTaskLink
            // 
            this.CurrentTaskLink.AutoSize = true;
            this.CurrentTaskLink.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentTaskLink.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentTaskLink.LinkColor = System.Drawing.Color.White;
            this.CurrentTaskLink.Location = new System.Drawing.Point(17, 149);
            this.CurrentTaskLink.Name = "CurrentTaskLink";
            this.CurrentTaskLink.Size = new System.Drawing.Size(64, 13);
            this.CurrentTaskLink.TabIndex = 56;
            this.CurrentTaskLink.TabStop = true;
            this.CurrentTaskLink.Text = "Current task";
            this.CurrentTaskLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.BackColor = System.Drawing.Color.Transparent;
            this.Debug.Location = new System.Drawing.Point(10, 9);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(39, 13);
            this.Debug.TabIndex = 57;
            this.Debug.Text = "Debug";
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // timer1_minute1
            // 
            this.timer1_minute1.Interval = 5000;
            this.timer1_minute1.Tick += new System.EventHandler(this.timer1_minute1_Tick);
            // 
            // timer1offline
            // 
            this.timer1offline.Enabled = true;
            this.timer1offline.Interval = 5000;
            this.timer1offline.Tick += new System.EventHandler(this.timer1offline_Tick);
            // 
            // timer1Watch
            // 
            this.timer1Watch.Enabled = true;
            this.timer1Watch.Tick += new System.EventHandler(this.timer1Watch_Tick);
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.BackColor = System.Drawing.Color.Transparent;
            this.TotalTime.Location = new System.Drawing.Point(262, 9);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(57, 13);
            this.TotalTime.TabIndex = 58;
            this.TotalTime.Text = "Total Time";
            // 
            // TotalTimeNr
            // 
            this.TotalTimeNr.AutoSize = true;
            this.TotalTimeNr.BackColor = System.Drawing.Color.Transparent;
            this.TotalTimeNr.Location = new System.Drawing.Point(363, 9);
            this.TotalTimeNr.Name = "TotalTimeNr";
            this.TotalTimeNr.Size = new System.Drawing.Size(54, 13);
            this.TotalTimeNr.TabIndex = 59;
            this.TotalTimeNr.Text = "TotalTime";
            // 
            // CheckTimer
            // 
            this.CheckTimer.Enabled = true;
            this.CheckTimer.Interval = 1000;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // BreakButton
            // 
            this.BreakButton.AutoSize = true;
            this.BreakButton.Location = new System.Drawing.Point(149, 11);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(85, 17);
            this.BreakButton.TabIndex = 60;
            this.BreakButton.Text = "BreakButton";
            this.BreakButton.UseVisualStyleBackColor = true;
            this.BreakButton.CheckedChanged += new System.EventHandler(this.BreakButton_CheckedChanged);
            // 
            // Overtime
            // 
            this.Overtime.AutoSize = true;
            this.Overtime.BackColor = System.Drawing.Color.Transparent;
            this.Overtime.Location = new System.Drawing.Point(252, 149);
            this.Overtime.Name = "Overtime";
            this.Overtime.Size = new System.Drawing.Size(0, 13);
            this.Overtime.TabIndex = 61;
            // 
            // ContiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(436, 180);
            this.Controls.Add(this.Overtime);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.TotalTimeNr);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.CurrentTaskLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.Testbutton);
            this.Controls.Add(this.OpenExcel);
            this.Controls.Add(this.OpenTools);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ContiApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label OfflineTotalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Testbutton;
        private System.Windows.Forms.Button OpenExcel;
        private System.Windows.Forms.Button OpenTools;
        public System.Windows.Forms.RichTextBox CommentBox;
        private System.Windows.Forms.Label sadsa;
        private System.Windows.Forms.Label ActiveTimeNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon TimePassed;
        private System.Windows.Forms.LinkLabel CurrentTaskLink;
        private System.Windows.Forms.Label Debug;
        private System.Windows.Forms.Timer timer1_minute1;
        private System.Windows.Forms.Timer timer1offline;
        private System.Windows.Forms.Timer timer1Watch;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label TotalTimeNr;
        private System.Windows.Forms.Timer CheckTimer;
        private System.Windows.Forms.CheckBox BreakButton;
        private System.Windows.Forms.Label Overtime;
    }
}

