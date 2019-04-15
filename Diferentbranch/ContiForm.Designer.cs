namespace Differentbranch
{
    partial class ContiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContiForm));
            this.TaskTimeBar = new System.Windows.Forms.ProgressBar();
            this.ActiveTimeBar = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActiveTimeProcent = new System.Windows.Forms.Label();
            this.OfflineTotalTime = new System.Windows.Forms.Label();
            this.TaskTimeProcent = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateTime = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RecordEvent = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.OpenExcel = new System.Windows.Forms.Button();
            this.OpenTools = new System.Windows.Forms.Button();
            this.timer1minute = new System.Windows.Forms.Timer(this.components);
            this.Overtime_label = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.TimePassed = new System.Windows.Forms.NotifyIcon(this.components);
            this.InitiTimer = new System.Windows.Forms.Timer(this.components);
            this.EventsTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1minute2 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskTimeBar
            // 
            this.TaskTimeBar.Location = new System.Drawing.Point(315, 109);
            this.TaskTimeBar.Name = "TaskTimeBar";
            this.TaskTimeBar.Size = new System.Drawing.Size(147, 21);
            this.TaskTimeBar.TabIndex = 0;
            this.TaskTimeBar.Click += new System.EventHandler(this.LockTimeBar_Click);
            // 
            // ActiveTimeBar
            // 
            this.ActiveTimeBar.Location = new System.Drawing.Point(315, 22);
            this.ActiveTimeBar.Name = "ActiveTimeBar";
            this.ActiveTimeBar.Size = new System.Drawing.Size(147, 23);
            this.ActiveTimeBar.TabIndex = 2;
            this.ActiveTimeBar.Click += new System.EventHandler(this.ActiveTimeBar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(14, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Current task";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CurrentTaskLinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(312, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Task ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(314, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Offline Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(312, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Active Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ActiveTimeProcent
            // 
            this.ActiveTimeProcent.AutoSize = true;
            this.ActiveTimeProcent.BackColor = System.Drawing.Color.Transparent;
            this.ActiveTimeProcent.Location = new System.Drawing.Point(427, 8);
            this.ActiveTimeProcent.Name = "ActiveTimeProcent";
            this.ActiveTimeProcent.Size = new System.Drawing.Size(43, 13);
            this.ActiveTimeProcent.TabIndex = 29;
            this.ActiveTimeProcent.Text = "procent";
            this.ActiveTimeProcent.Click += new System.EventHandler(this.ActiveTimeProcent_Click);
            // 
            // OfflineTotalTime
            // 
            this.OfflineTotalTime.AutoSize = true;
            this.OfflineTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.OfflineTotalTime.Location = new System.Drawing.Point(427, 58);
            this.OfflineTotalTime.Name = "OfflineTotalTime";
            this.OfflineTotalTime.Size = new System.Drawing.Size(43, 13);
            this.OfflineTotalTime.TabIndex = 28;
            this.OfflineTotalTime.Text = "procent";
            this.OfflineTotalTime.Click += new System.EventHandler(this.OfflineTotalTime_Click);
            // 
            // TaskTimeProcent
            // 
            this.TaskTimeProcent.AutoSize = true;
            this.TaskTimeProcent.BackColor = System.Drawing.Color.Transparent;
            this.TaskTimeProcent.Location = new System.Drawing.Point(427, 92);
            this.TaskTimeProcent.Name = "TaskTimeProcent";
            this.TaskTimeProcent.Size = new System.Drawing.Size(43, 13);
            this.TaskTimeProcent.TabIndex = 27;
            this.TaskTimeProcent.Text = "procent";
            this.TaskTimeProcent.Click += new System.EventHandler(this.TaskTimeProcent_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateTime);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 136);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // UpdateTime
            // 
            this.UpdateTime.BackColor = System.Drawing.SystemColors.MenuText;
            this.UpdateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateTime.Location = new System.Drawing.Point(17, 97);
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Size = new System.Drawing.Size(116, 27);
            this.UpdateTime.TabIndex = 29;
            this.UpdateTime.Text = "Update";
            this.UpdateTime.UseVisualStyleBackColor = false;
            this.UpdateTime.Click += new System.EventHandler(this.UpdateTime_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.AllowDrop = true;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.numericUpDown4.Location = new System.Drawing.Point(81, 68);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown4.TabIndex = 27;
            this.numericUpDown4.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.AllowDrop = true;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.numericUpDown3.Location = new System.Drawing.Point(17, 68);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown3.TabIndex = 26;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AllowDrop = true;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(17, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(81, 40);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(381, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(335, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Info";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RecordEvent);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.OpenExcel);
            this.groupBox2.Controls.Add(this.OpenTools);
            this.groupBox2.Location = new System.Drawing.Point(168, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 136);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // RecordEvent
            // 
            this.RecordEvent.BackColor = System.Drawing.SystemColors.MenuText;
            this.RecordEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RecordEvent.Location = new System.Drawing.Point(12, 76);
            this.RecordEvent.Name = "RecordEvent";
            this.RecordEvent.Size = new System.Drawing.Size(104, 21);
            this.RecordEvent.TabIndex = 18;
            this.RecordEvent.Text = "RecordEvent";
            this.RecordEvent.UseVisualStyleBackColor = false;
            this.RecordEvent.Click += new System.EventHandler(this.RecordEvent_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(12, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 21);
            this.button6.TabIndex = 13;
            this.button6.Text = "Test";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // OpenExcel
            // 
            this.OpenExcel.BackColor = System.Drawing.Color.Black;
            this.OpenExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenExcel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenExcel.Location = new System.Drawing.Point(12, 49);
            this.OpenExcel.Name = "OpenExcel";
            this.OpenExcel.Size = new System.Drawing.Size(104, 21);
            this.OpenExcel.TabIndex = 16;
            this.OpenExcel.Text = "Open Excel";
            this.OpenExcel.UseVisualStyleBackColor = false;
            this.OpenExcel.Click += new System.EventHandler(this.OpenExcel_Click);
            // 
            // OpenTools
            // 
            this.OpenTools.BackColor = System.Drawing.SystemColors.MenuText;
            this.OpenTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTools.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenTools.Location = new System.Drawing.Point(12, 103);
            this.OpenTools.Name = "OpenTools";
            this.OpenTools.Size = new System.Drawing.Size(104, 21);
            this.OpenTools.TabIndex = 17;
            this.OpenTools.Text = "Open Tools";
            this.OpenTools.UseVisualStyleBackColor = false;
            this.OpenTools.Click += new System.EventHandler(this.OpenTools_Click);
            // 
            // timer1minute
            // 
            this.timer1minute.Enabled = true;
            this.timer1minute.Interval = 60000;
            this.timer1minute.Tick += new System.EventHandler(this.Timer1minute_Tick);
            // 
            // Overtime_label
            // 
            this.Overtime_label.AutoSize = true;
            this.Overtime_label.BackColor = System.Drawing.Color.Transparent;
            this.Overtime_label.Location = new System.Drawing.Point(365, 28);
            this.Overtime_label.Name = "Overtime_label";
            this.Overtime_label.Size = new System.Drawing.Size(49, 13);
            this.Overtime_label.TabIndex = 37;
            this.Overtime_label.Text = "Overtime";
            this.Overtime_label.Visible = false;
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(105, 148);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(192, 22);
            this.CommentBox.TabIndex = 38;
            this.CommentBox.Text = "";
            this.CommentBox.TextChanged += new System.EventHandler(this.CommentBox_Changed);
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
            // InitiTimer
            // 
            this.InitiTimer.Enabled = true;
            this.InitiTimer.Tick += new System.EventHandler(this.InitiAppTimer);
            // 
            // EventsTimer
            // 
            this.EventsTimer.Enabled = true;
            this.EventsTimer.Interval = 300000;
            this.EventsTimer.Tick += new System.EventHandler(this.EventsTimer_Tick);
            // 
            // timer1minute2
            // 
            this.timer1minute2.Enabled = true;
            this.timer1minute2.Interval = 60000;
            this.timer1minute2.Tick += new System.EventHandler(this.timer1minute2_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(476, 8);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(19, 127);
            this.trackBar1.TabIndex = 30;
            // 
            // ContiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(507, 178);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ActiveTimeProcent);
            this.Controls.Add(this.OfflineTotalTime);
            this.Controls.Add(this.TaskTimeProcent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TaskTimeBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Overtime_label);
            this.Controls.Add(this.ActiveTimeBar);
            this.Controls.Add(this.label3);
            this.Name = "ContiForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ContiForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar TaskTimeBar;
        private System.Windows.Forms.ProgressBar ActiveTimeBar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ActiveTimeProcent;
        private System.Windows.Forms.Label OfflineTotalTime;
        private System.Windows.Forms.Label TaskTimeProcent;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateTime;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button OpenExcel;
        private System.Windows.Forms.Button OpenTools;
        private System.Windows.Forms.Label Overtime_label;
        private System.Windows.Forms.NotifyIcon TimePassed;
        public System.Windows.Forms.Timer timer1minute;
        private System.Windows.Forms.Timer InitiTimer;
        private System.Windows.Forms.Timer EventsTimer;
        public System.Windows.Forms.Button RecordEvent;
        public System.Windows.Forms.RichTextBox CommentBox;
        private System.Windows.Forms.Timer timer1minute2;
        public System.Windows.Forms.TrackBar trackBar1;
    }
}