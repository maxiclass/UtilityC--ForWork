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
            this.Minimizebutton = new System.Windows.Forms.Button();
            this.OpenExcel = new System.Windows.Forms.Button();
            this.OpenTools = new System.Windows.Forms.Button();
            this.OpenToolsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
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
            this.TaskStatusMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.To_do = new System.Windows.Forms.ToolStripMenuItem();
            this.In_progress = new System.Windows.Forms.ToolStripMenuItem();
            this.Commit = new System.Windows.Forms.ToolStripMenuItem();
            this.Review = new System.Windows.Forms.ToolStripMenuItem();
            this.Rework = new System.Windows.Forms.ToolStripMenuItem();
            this.Done = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.TimePassed = new System.Windows.Forms.NotifyIcon(this.components);
            this.CurrentTaskLink = new System.Windows.Forms.LinkLabel();
            this.ChangeListMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ChangeLinkConfirmStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1_minute1 = new System.Windows.Forms.Timer(this.components);
            this.timer1offline = new System.Windows.Forms.Timer(this.components);
            this.timer1Watch = new System.Windows.Forms.Timer(this.components);
            this.TotalTime = new System.Windows.Forms.Label();
            this.TotalTimeNr = new System.Windows.Forms.Label();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.BreakButton = new System.Windows.Forms.CheckBox();
            this.Overtime = new System.Windows.Forms.Label();
            this.Autosave = new System.Windows.Forms.Timer(this.components);
            this.InitTimer = new System.Windows.Forms.Timer(this.components);
            this.Record = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Main1MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRecordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.OpenToolsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TaskStatusMenuStrip.SuspendLayout();
            this.ChangeListMenuStrip.SuspendLayout();
            this.Main1MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeTimeUpDown)).BeginInit();
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
            // Minimizebutton
            // 
            this.Minimizebutton.BackColor = System.Drawing.SystemColors.MenuText;
            this.Minimizebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Minimizebutton.Location = new System.Drawing.Point(134, 40);
            this.Minimizebutton.Name = "Minimizebutton";
            this.Minimizebutton.Size = new System.Drawing.Size(104, 21);
            this.Minimizebutton.TabIndex = 32;
            this.Minimizebutton.Text = "Minimze";
            this.Minimizebutton.UseVisualStyleBackColor = false;
            this.Minimizebutton.Click += new System.EventHandler(this.Minimize_Click);
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
            this.OpenTools.ContextMenuStrip = this.OpenToolsMenuStrip;
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
            // OpenToolsMenuStrip
            // 
            this.OpenToolsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox});
            this.OpenToolsMenuStrip.Name = "OpenToolsMenuStrip";
            this.OpenToolsMenuStrip.Size = new System.Drawing.Size(182, 31);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.Items.AddRange(new object[] {
            "tool1",
            "tool2",
            "tool3"});
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(121, 23);
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
            this.TaskStatus.ContextMenuStrip = this.TaskStatusMenuStrip;
            this.TaskStatus.Location = new System.Drawing.Point(108, 65);
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.Size = new System.Drawing.Size(35, 13);
            this.TaskStatus.TabIndex = 62;
            this.TaskStatus.Text = "label1";
            // 
            // TaskStatusMenuStrip
            // 
            this.TaskStatusMenuStrip.AllowDrop = true;
            this.TaskStatusMenuStrip.AutoSize = false;
            this.TaskStatusMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TaskStatusMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.To_do,
            this.In_progress,
            this.Commit,
            this.Review,
            this.Rework,
            this.Done});
            this.TaskStatusMenuStrip.Name = "TaskStatusMenuStrip";
            this.TaskStatusMenuStrip.Size = new System.Drawing.Size(120, 135);
            // 
            // To_do
            // 
            this.To_do.AutoSize = false;
            this.To_do.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.To_do.Name = "To_do";
            this.To_do.Size = new System.Drawing.Size(130, 22);
            this.To_do.Text = "To do";
            this.To_do.ToolTipText = "Change current task status in : To Do";
            this.To_do.Click += new System.EventHandler(this.To_do_Click);
            this.To_do.MouseEnter += new System.EventHandler(this.To_do_MouseEnter);
            this.To_do.MouseLeave += new System.EventHandler(this.To_do_MouseLeave);
            // 
            // In_progress
            // 
            this.In_progress.AutoSize = false;
            this.In_progress.Name = "In_progress";
            this.In_progress.Size = new System.Drawing.Size(130, 22);
            this.In_progress.Text = "In progress";
            this.In_progress.ToolTipText = "Change current task status in : In Progress";
            this.In_progress.Click += new System.EventHandler(this.In_progress_Click);
            this.In_progress.MouseEnter += new System.EventHandler(this.In_progress_MouseEnter);
            this.In_progress.MouseLeave += new System.EventHandler(this.In_progress_MouseLeave);
            // 
            // Commit
            // 
            this.Commit.AutoSize = false;
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(130, 22);
            this.Commit.Text = "Commit";
            this.Commit.ToolTipText = "Change current task status in : Commit\r\n";
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            this.Commit.MouseEnter += new System.EventHandler(this.Commit_MouseEnter);
            this.Commit.MouseLeave += new System.EventHandler(this.Commit_MouseLeave);
            // 
            // Review
            // 
            this.Review.AutoSize = false;
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(130, 22);
            this.Review.Text = "Review";
            this.Review.ToolTipText = "Change current task status in : Review\r\n";
            this.Review.Click += new System.EventHandler(this.Review_Click);
            this.Review.MouseEnter += new System.EventHandler(this.Review_MouseEnter);
            this.Review.MouseLeave += new System.EventHandler(this.Review_MouseLeave);
            // 
            // Rework
            // 
            this.Rework.AutoSize = false;
            this.Rework.Name = "Rework";
            this.Rework.Size = new System.Drawing.Size(130, 22);
            this.Rework.Text = "Rework";
            this.Rework.ToolTipText = "Change current task status in : Rework\r\n";
            this.Rework.Click += new System.EventHandler(this.Rework_Click);
            this.Rework.MouseEnter += new System.EventHandler(this.Rework_MouseEnter);
            this.Rework.MouseLeave += new System.EventHandler(this.Rework_MouseLeave);
            // 
            // Done
            // 
            this.Done.AutoSize = false;
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(130, 22);
            this.Done.Text = "Done";
            this.Done.ToolTipText = "Change current task status in : Done\r\n";
            this.Done.Click += new System.EventHandler(this.Done_Click);
            this.Done.MouseEnter += new System.EventHandler(this.Done_MouseEnter);
            this.Done.MouseLeave += new System.EventHandler(this.Done_MouseLeave);
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
            this.CurrentTaskLink.ContextMenuStrip = this.ChangeListMenuStrip;
            this.CurrentTaskLink.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentTaskLink.LinkColor = System.Drawing.Color.White;
            this.CurrentTaskLink.Location = new System.Drawing.Point(17, 149);
            this.CurrentTaskLink.Name = "CurrentTaskLink";
            this.CurrentTaskLink.Size = new System.Drawing.Size(64, 13);
            this.CurrentTaskLink.TabIndex = 56;
            this.CurrentTaskLink.TabStop = true;
            this.CurrentTaskLink.Text = "Current task";
            this.CurrentTaskLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CurrentTaskLink_LinkClicked_1);
            this.CurrentTaskLink.DoubleClick += new System.EventHandler(this.linkLabel1_LinkClicked);
            // 
            // ChangeListMenuStrip
            // 
            this.ChangeListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLinkToolStripMenuItem});
            this.ChangeListMenuStrip.Name = "CurrentTaskMenuStrip1";
            this.ChangeListMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // changeLinkToolStripMenuItem
            // 
            this.changeLinkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeLinkTextBox,
            this.ChangeLinkConfirmStripMenuItem});
            this.changeLinkToolStripMenuItem.Name = "changeLinkToolStripMenuItem";
            this.changeLinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeLinkToolStripMenuItem.Text = "Change Link";
            this.changeLinkToolStripMenuItem.ToolTipText = "Change current task link";
            // 
            // ChangeLinkTextBox
            // 
            this.ChangeLinkTextBox.Name = "ChangeLinkTextBox";
            this.ChangeLinkTextBox.Size = new System.Drawing.Size(100, 23);
            this.ChangeLinkTextBox.ToolTipText = "Insert a new link for the current task";
            this.ChangeLinkTextBox.Validated += new System.EventHandler(this.ChangeLinkTextBox_Validated);
            this.ChangeLinkTextBox.Click += new System.EventHandler(this.ChangeLinkTextBox_Click);
            // 
            // ChangeLinkConfirmStripMenuItem
            // 
            this.ChangeLinkConfirmStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ChangeLinkConfirmStripMenuItem.Name = "ChangeLinkConfirmStripMenuItem";
            this.ChangeLinkConfirmStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeLinkConfirmStripMenuItem.Text = "   Confirm";
            this.ChangeLinkConfirmStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ChangeLinkConfirmStripMenuItem.ToolTipText = "Confirm new link";
            this.ChangeLinkConfirmStripMenuItem.Click += new System.EventHandler(this.ChangeLinkConfirmStripMenuItem_Click);
            this.ChangeLinkConfirmStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeLinkConfirmStripMenuItem_MouseEnter);
            this.ChangeLinkConfirmStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeLinkConfirmStripMenuItem_MouseLeave);
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
            // Main1MenuStrip
            // 
            this.Main1MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.OpenExcelMenuItem,
            this.DeleteRecordMenuItem,
            this.toolStripSeparator2,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitStripMenuItem1});
            this.Main1MenuStrip.Name = "MainMenuStrip";
            this.Main1MenuStrip.Size = new System.Drawing.Size(153, 110);
            this.Main1MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MainMenuStrip_Opening);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // OpenExcelMenuItem
            // 
            this.OpenExcelMenuItem.Name = "OpenExcelMenuItem";
            this.OpenExcelMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenExcelMenuItem.Text = "Open Excel file";
            this.OpenExcelMenuItem.ToolTipText = "Open Excel file and close application";
            this.OpenExcelMenuItem.Click += new System.EventHandler(this.OpenExcelMenuItem_Click);
            this.OpenExcelMenuItem.MouseEnter += new System.EventHandler(this.OpenExcelMenuItem_MouseEnter);
            this.OpenExcelMenuItem.MouseLeave += new System.EventHandler(this.OpenExcelMenuItem_MouseLeave);
            // 
            // DeleteRecordMenuItem
            // 
            this.DeleteRecordMenuItem.Name = "DeleteRecordMenuItem";
            this.DeleteRecordMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteRecordMenuItem.Text = "Delete Records";
            this.DeleteRecordMenuItem.Click += new System.EventHandler(this.DeleteRecordMenuItem1_Click);
            this.DeleteRecordMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem1_MouseEnter);
            this.DeleteRecordMenuItem.MouseLeave += new System.EventHandler(this.toolStripMenuItem1_MouseLeave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.ToolTipText = "Save all data in excel file";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            this.SaveToolStripMenuItem.MouseEnter += new System.EventHandler(this.SaveToolStripMenuItem_MouseEnter);
            this.SaveToolStripMenuItem.MouseLeave += new System.EventHandler(this.SaveToolStripMenuItem_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitStripMenuItem1
            // 
            this.ExitStripMenuItem1.Name = "ExitStripMenuItem1";
            this.ExitStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ExitStripMenuItem1.Text = "Exit";
            this.ExitStripMenuItem1.ToolTipText = "Close and exit application";
            this.ExitStripMenuItem1.Click += new System.EventHandler(this.ExitStripMenuItem1_Click);
            this.ExitStripMenuItem1.MouseEnter += new System.EventHandler(this.ExitStripMenuItem1_MouseEnter);
            this.ExitStripMenuItem1.MouseLeave += new System.EventHandler(this.ExitStripMenuItem1_MouseLeave);
            // 
            // ChangeTimeUpDown
            // 
            this.ChangeTimeUpDown.AllowDrop = true;
            this.ChangeTimeUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTimeUpDown.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.ChangeTimeUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChangeTimeUpDown.Location = new System.Drawing.Point(20, 9);
            this.ChangeTimeUpDown.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.ChangeTimeUpDown.Name = "ChangeTimeUpDown";
            this.ChangeTimeUpDown.Size = new System.Drawing.Size(82, 22);
            this.ChangeTimeUpDown.TabIndex = 63;
            this.ChangeTimeUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChangeTimeUpDown.ValueChanged += new System.EventHandler(this.ChangeTimeUpDown_ValueChanged);
            // 
            // ContiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 179);
            this.ContextMenuStrip = this.Main1MenuStrip;
            this.Controls.Add(this.ChangeTimeUpDown);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Overtime);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.TotalTimeNr);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.CurrentTaskLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.Minimizebutton);
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
            this.OpenToolsMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TaskStatusMenuStrip.ResumeLayout(false);
            this.ChangeListMenuStrip.ResumeLayout(false);
            this.Main1MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeTimeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label OfflineTotalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Minimizebutton;
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
        private System.Windows.Forms.Timer InitTimer;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.ContextMenuStrip ChangeListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem changeLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ChangeLinkTextBox;
        public System.Windows.Forms.LinkLabel CurrentTaskLink;
        private System.Windows.Forms.ContextMenuStrip OpenToolsMenuStrip;
        private System.Windows.Forms.ContextMenuStrip TaskStatusMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem To_do;
        private System.Windows.Forms.ToolStripMenuItem In_progress;
        private System.Windows.Forms.ToolStripMenuItem Commit;
        private System.Windows.Forms.ToolStripMenuItem Review;
        private System.Windows.Forms.ToolStripMenuItem Rework;
        private System.Windows.Forms.ToolStripMenuItem Done;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip Main1MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChangeLinkConfirmStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenExcelMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecordMenuItem;
        private System.Windows.Forms.NumericUpDown ChangeTimeUpDown;
    }
}

