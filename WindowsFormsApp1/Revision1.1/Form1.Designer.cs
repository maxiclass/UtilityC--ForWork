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
            this.ActiveTimeNr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimePassed = new System.Windows.Forms.NotifyIcon(this.components);
            this.CurrentTaskLink = new System.Windows.Forms.LinkLabel();
            this.CurrentTaskMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Debug = new System.Windows.Forms.Label();
            this.timer1_minute1 = new System.Windows.Forms.Timer(this.components);
            this.timer1offline = new System.Windows.Forms.Timer(this.components);
            this.timer1Watch = new System.Windows.Forms.Timer(this.components);
            this.TotalTime = new System.Windows.Forms.Label();
            this.TotalTimeNr = new System.Windows.Forms.Label();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.BreakButton = new System.Windows.Forms.CheckBox();
            this.Overtime = new System.Windows.Forms.Label();
            this.Autosave = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.InitTimer = new System.Windows.Forms.Timer(this.components);
            this.Record = new System.Windows.Forms.Button();
            this.OpenToolsMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolsListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CurrentTaskMenuStrip1.SuspendLayout();
            this.OpenToolsMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 170);
            this.progressBar1.Maximum = 480;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 10);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // OfflineTotalTime
            // 
            this.OfflineTotalTime.AutoSize = true;
            this.OfflineTotalTime.Location = new System.Drawing.Point(110, 40);
            this.OfflineTotalTime.Name = "OfflineTotalTime";
            this.OfflineTotalTime.Size = new System.Drawing.Size(22, 13);
            this.OfflineTotalTime.TabIndex = 7;
            this.OfflineTotalTime.Text = "OT";
            this.OfflineTotalTime.Click += new System.EventHandler(this.OfflineTotalTime_Click_1);
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
            this.OpenTools.ContextMenuStrip = this.OpenToolsMenuStrip1;
            this.OpenTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTools.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenTools.Location = new System.Drawing.Point(134, 90);
            this.OpenTools.Name = "OpenTools";
            this.OpenTools.Size = new System.Drawing.Size(104, 21);
            this.OpenTools.TabIndex = 34;
            this.OpenTools.Text = "Open Tools";
            this.OpenTools.UseVisualStyleBackColor = false;
            this.OpenTools.Click += new System.EventHandler(this.OpenTools_Click);
            this.OpenTools.MouseEnter += new System.EventHandler(this.OpenTools_MouseEnter);
            // 
            // CommentBox
            // 
            this.CommentBox.AutoWordSelection = true;
            this.CommentBox.Location = new System.Drawing.Point(12, 115);
            this.CommentBox.Multiline = false;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CommentBox.Size = new System.Drawing.Size(237, 22);
            this.CommentBox.TabIndex = 39;
            this.CommentBox.Text = "";
            this.CommentBox.Validated += new System.EventHandler(this.CommentBox_Validated);
            // 
            // ActiveTimeNr
            // 
            this.ActiveTimeNr.AutoSize = true;
            this.ActiveTimeNr.BackColor = System.Drawing.Color.Transparent;
            this.ActiveTimeNr.Location = new System.Drawing.Point(111, 15);
            this.ActiveTimeNr.Name = "ActiveTimeNr";
            this.ActiveTimeNr.Size = new System.Drawing.Size(21, 13);
            this.ActiveTimeNr.TabIndex = 43;
            this.ActiveTimeNr.Text = "AT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 40);
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
            this.label7.Location = new System.Drawing.Point(19, 15);
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
            this.groupBox1.Controls.Add(this.TaskStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OfflineTotalTime);
            this.groupBox1.Controls.Add(this.ActiveTimeNr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(255, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 112);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Task Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TaskStatus
            // 
            this.TaskStatus.AutoSize = true;
            this.TaskStatus.Location = new System.Drawing.Point(108, 65);
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.Size = new System.Drawing.Size(35, 13);
            this.TaskStatus.TabIndex = 62;
            this.TaskStatus.Text = "label1";
            this.TaskStatus.ContextMenuStripChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.TaskStatus.Click += new System.EventHandler(this.label1_Click);
            this.TaskStatus.MouseHover += new System.EventHandler(this.TaskStatus_MouseHover);
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
            this.CurrentTaskLink.AllowDrop = true;
            this.CurrentTaskLink.AutoEllipsis = true;
            this.CurrentTaskLink.AutoSize = true;
            this.CurrentTaskLink.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentTaskLink.ContextMenuStrip = this.CurrentTaskMenuStrip1;
            this.CurrentTaskLink.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentTaskLink.LinkColor = System.Drawing.Color.White;
            this.CurrentTaskLink.Location = new System.Drawing.Point(17, 149);
            this.CurrentTaskLink.Name = "CurrentTaskLink";
            this.CurrentTaskLink.Size = new System.Drawing.Size(64, 13);
            this.CurrentTaskLink.TabIndex = 56;
            this.CurrentTaskLink.TabStop = true;
            this.CurrentTaskLink.Text = "Current task";
            this.CurrentTaskLink.DoubleClick += new System.EventHandler(this.linkLabel1_LinkClicked);
            // 
            // CurrentTaskMenuStrip1
            // 
            this.CurrentTaskMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLinkToolStripMenuItem});
            this.CurrentTaskMenuStrip1.Name = "CurrentTaskMenuStrip1";
            this.CurrentTaskMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // changeLinkToolStripMenuItem
            // 
            this.changeLinkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeLinkTextBox});
            this.changeLinkToolStripMenuItem.Name = "changeLinkToolStripMenuItem";
            this.changeLinkToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.changeLinkToolStripMenuItem.Text = "Change Link";
            // 
            // ChangeLinkTextBox
            // 
            this.ChangeLinkTextBox.Name = "ChangeLinkTextBox";
            this.ChangeLinkTextBox.Size = new System.Drawing.Size(100, 23);
            this.ChangeLinkTextBox.Validated += new System.EventHandler(this.ChangeLinkTextBox_Validated);
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
            // Autosave
            // 
            this.Autosave.Enabled = true;
            this.Autosave.Interval = 300000;
            this.Autosave.Tick += new System.EventHandler(this.Autosave_Tick);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "To Do",
            "In Progress",
            "Commit",
            "Review",
            "Rework",
            "Done"});
            this.listBox1.Location = new System.Drawing.Point(407, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(70, 43);
            this.listBox1.TabIndex = 52;
            this.listBox1.Tag = "StrCurrentTaskStatus";
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.TabIndexChanged += new System.EventHandler(this.listBox1_TabIndexChanged);
            this.listBox1.TabStopChanged += new System.EventHandler(this.listBox1_TabStopChanged);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // InitTimer
            // 
            this.InitTimer.Enabled = true;
            this.InitTimer.Tick += new System.EventHandler(this.InitTimer_Tick);
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.SystemColors.MenuText;
            this.Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Record.Location = new System.Drawing.Point(13, 90);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(89, 21);
            this.Record.TabIndex = 62;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = false;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // OpenToolsMenuStrip1
            // 
            this.OpenToolsMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.OpenToolsMenuStrip1.Name = "OpenToolsMenuStrip1";
            this.OpenToolsMenuStrip1.Size = new System.Drawing.Size(182, 59);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Tool1 ",
            "Tool2",
            "Tool3",
            "Tool4"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // SelectToolsListBox1
            // 
            this.SelectToolsListBox1.AllowDrop = true;
            this.SelectToolsListBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectToolsListBox1.CheckOnClick = true;
            this.SelectToolsListBox1.FormattingEnabled = true;
            this.SelectToolsListBox1.IntegralHeight = false;
            this.SelectToolsListBox1.Items.AddRange(new object[] {
            "Tool1",
            "Tool2",
            "Tool3",
            "Tool4",
            "Tool5",
            "Tool6"});
            this.SelectToolsListBox1.Location = new System.Drawing.Point(219, 93);
            this.SelectToolsListBox1.Name = "SelectToolsListBox1";
            this.SelectToolsListBox1.ScrollAlwaysVisible = true;
            this.SelectToolsListBox1.Size = new System.Drawing.Size(120, 53);
            this.SelectToolsListBox1.TabIndex = 64;
            this.SelectToolsListBox1.Visible = false;
            this.SelectToolsListBox1.MouseEnter += new System.EventHandler(this.SelectToolsListBox1_MouseEnter);
            this.SelectToolsListBox1.MouseLeave += new System.EventHandler(this.SelectToolsListBox1_MouseLeave);
            // 
            // ContiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(478, 179);
            this.Controls.Add(this.SelectToolsListBox1);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.listBox1);
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
            this.Controls.Add(this.Testbutton);
            this.Controls.Add(this.OpenExcel);
            this.Controls.Add(this.OpenTools);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ContiApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CurrentTaskMenuStrip1.ResumeLayout(false);
            this.OpenToolsMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Label ActiveTimeNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon TimePassed;
        private System.Windows.Forms.Label Debug;
        private System.Windows.Forms.Timer timer1_minute1;
        private System.Windows.Forms.Timer timer1offline;
        private System.Windows.Forms.Timer timer1Watch;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label TotalTimeNr;
        private System.Windows.Forms.Timer CheckTimer;
        private System.Windows.Forms.CheckBox BreakButton;
        private System.Windows.Forms.Label Overtime;
        private System.Windows.Forms.Timer Autosave;
        private System.Windows.Forms.Label TaskStatus;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer InitTimer;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.ContextMenuStrip CurrentTaskMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ChangeLinkTextBox;
        public System.Windows.Forms.LinkLabel CurrentTaskLink;
        private System.Windows.Forms.ContextMenuStrip OpenToolsMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.CheckedListBox SelectToolsListBox1;
    }
}

