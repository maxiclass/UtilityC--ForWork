namespace Revision1._1
{
    partial class ToolsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TD4 14.5(17.5 )");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TD4 14.2(17.2 )");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TD4", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Notepad++");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Skype");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Outlook");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Jira");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Total Commander");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.Color.DarkGray;
            this.treeView1.CheckBoxes = true;
            this.treeView1.HotTracking = true;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(-2, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "TD4.14.5";
            treeNode1.Text = "TD4 14.5(17.5 )";
            treeNode1.ToolTipText = "TD4 14.5 Eclipse 17.5";
            treeNode2.Name = "TD4.14.2";
            treeNode2.Text = "TD4 14.2(17.2 )";
            treeNode2.ToolTipText = "TD4 14.2 Eclipse 17.2";
            treeNode3.Name = "TD4Node";
            treeNode3.Text = "TD4";
            treeNode3.ToolTipText = "TD4";
            treeNode4.Name = "NotepadNode";
            treeNode4.Text = "Notepad++";
            treeNode4.ToolTipText = "Notepad++";
            treeNode5.Checked = true;
            treeNode5.Name = "SkypeNode";
            treeNode5.Text = "Skype";
            treeNode5.ToolTipText = "Skype";
            treeNode6.Checked = true;
            treeNode6.Name = "OutlookNode";
            treeNode6.Text = "Outlook";
            treeNode6.ToolTipText = "Outlook";
            treeNode7.Name = "JiraNode";
            treeNode7.Text = "Jira";
            treeNode8.Name = "TotalCommanderNode";
            treeNode8.Text = "Total Commander";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(378, 198);
            this.treeView1.TabIndex = 65;
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 195);
            this.Controls.Add(this.treeView1);
            this.Name = "ToolsForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ToolsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
    }
}