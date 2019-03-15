namespace WindowsFormsApp1
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
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingElseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Onehour = new System.Windows.Forms.Timer(this.components);
            this.minute1 = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minute5 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.classforProgressBarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classforProgressBarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(395, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.classforProgressBarBindingSource, "Testprogress", true));
            this.progressBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classforProgressBarBindingSource, "Testprogress", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.progressBar1.Location = new System.Drawing.Point(313, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(136, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Tag = "testprogress";
            this.progressBar1.Value = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.SystemColorsChanged += new System.EventHandler(this.progressBar1_SystemColorsChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(313, 71);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(136, 23);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 30;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(313, 104);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(136, 23);
            this.progressBar3.TabIndex = 7;
            this.progressBar3.Value = 70;
            this.progressBar3.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.Red;
            this.progressBar4.Location = new System.Drawing.Point(313, 136);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(136, 23);
            this.progressBar4.Step = 1;
            this.progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar4.TabIndex = 8;
            this.progressBar4.Value = 45;
            this.progressBar4.Click += new System.EventHandler(this.progressBar4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem,
            this.somethingElseToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.generateReportToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.toolStripMenuItem20,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.somethingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripMenuItem2,
            this.loadUserToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.somethingToolStripMenuItem.Text = "Menu";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem2.Text = "New User";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // loadUserToolStripMenuItem
            // 
            this.loadUserToolStripMenuItem.Name = "loadUserToolStripMenuItem";
            this.loadUserToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadUserToolStripMenuItem.Text = "Load User";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem4.Text = "Save All";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem3.Text = "Reset Data";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // somethingElseToolStripMenuItem
            // 
            this.somethingElseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.somethingElseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1});
            this.somethingElseToolStripMenuItem.Name = "somethingElseToolStripMenuItem";
            this.somethingElseToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.somethingElseToolStripMenuItem.Text = "  Edit   ";
            this.somethingElseToolStripMenuItem.Click += new System.EventHandler(this.somethingElseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.AutoSize = false;
            this.searchToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.generateReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.generateReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.AutoSize = false;
            this.toolStripMenuItem20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem20.Text = "Help";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem7.Text = "Info";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(12, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 21);
            this.button6.TabIndex = 13;
            this.button6.Text = "Test";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(146, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 21);
            this.button7.TabIndex = 14;
            this.button7.Text = "Open Excel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ContiClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(12, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 21);
            this.button8.TabIndex = 16;
            this.button8.Text = "Break";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuText;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(12, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 21);
            this.button9.TabIndex = 17;
            this.button9.Text = "Load Conf";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.MenuText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Location = new System.Drawing.Point(12, 70);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 21);
            this.button10.TabIndex = 18;
            this.button10.Text = "RecordEvent";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Onehour
            // 
            this.Onehour.Enabled = true;
            this.Onehour.Interval = 360000;
            this.Onehour.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minute1
            // 
            this.minute1.Enabled = true;
            this.minute1.Interval = 60000;
            this.minute1.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AllowDrop = true;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(17, 28);
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
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(75, 28);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.ThousandsSeparator = true;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(18, 188);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Current task";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "http://buhev-jira.conti.de:7090/browse/"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.textBox1.Location = new System.Drawing.Point(109, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.Visible = false;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBox1.Location = new System.Drawing.Point(88, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 125);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(17, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 27);
            this.button2.TabIndex = 29;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.AllowDrop = true;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.numericUpDown4.Location = new System.Drawing.Point(75, 56);
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
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.AllowDrop = true;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.numericUpDown3.Location = new System.Drawing.Point(17, 56);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown3.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Location = new System.Drawing.Point(179, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 125);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // minute5
            // 
            this.minute5.Interval = 36000;
            this.minute5.Tick += new System.EventHandler(this.minute5_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(455, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = " x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(455, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = " x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(455, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = " x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(455, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = " x";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classforProgressBarBindingSource
            // 
            this.classforProgressBarBindingSource.DataSource = typeof(ClassforProgressBar.ClassforProgressBar);
            this.classforProgressBarBindingSource.CurrentChanged += new System.EventHandler(this.classforProgressBarBindingSource_CurrentChanged);
            // 
            // ContiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(488, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar4);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContiApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classforProgressBarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem somethingElseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource classforProgressBarBindingSource;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem loadUserToolStripMenuItem;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Timer Onehour;
        private System.Windows.Forms.Timer minute1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer minute5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

