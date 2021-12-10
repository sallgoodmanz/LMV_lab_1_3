
namespace LMV_lab_1_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFILE = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHELP = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMsg = new System.Windows.Forms.ToolStripButton();
            this.toolStripCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEnterMsg = new System.Windows.Forms.Label();
            this.buttonShowMsg = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFILE,
            this.toolStripMenuHELP});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFILE
            // 
            this.toolStripMenuFILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuFILE.Name = "toolStripMenuFILE";
            this.toolStripMenuFILE.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuFILE.Text = "File";
            this.toolStripMenuFILE.Click += new System.EventHandler(this.toolStripMenuFILE_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Checked = true;
            this.checkToolStripMenuItem.CheckOnClick = true;
            this.checkToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.checkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuHELP
            // 
            this.toolStripMenuHELP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuHELP.Name = "toolStripMenuHELP";
            this.toolStripMenuHELP.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuHELP.Text = "Help";
            this.toolStripMenuHELP.Click += new System.EventHandler(this.toolStripMenuHELP_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMsg,
            this.toolStripCheck,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(5, 192);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(140, 42);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMsg
            // 
            this.toolStripMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMsg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMsg.Image")));
            this.toolStripMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMsg.Name = "toolStripMsg";
            this.toolStripMsg.Size = new System.Drawing.Size(39, 39);
            this.toolStripMsg.Text = "toolStripButton1";
            this.toolStripMsg.Click += new System.EventHandler(this.toolStripMsg_Click);
            // 
            // toolStripCheck
            // 
            this.toolStripCheck.CheckOnClick = true;
            this.toolStripCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCheck.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCheck.Image")));
            this.toolStripCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCheck.Name = "toolStripCheck";
            this.toolStripCheck.Size = new System.Drawing.Size(39, 39);
            this.toolStripCheck.Text = "toolStripButton2";
            this.toolStripCheck.Click += new System.EventHandler(this.toolStripCheck_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(39, 39);
            this.toolStripExit.Text = "toolStripButton3";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 57);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelEnterMsg
            // 
            this.labelEnterMsg.AutoSize = true;
            this.labelEnterMsg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterMsg.Location = new System.Drawing.Point(0, 100);
            this.labelEnterMsg.Name = "labelEnterMsg";
            this.labelEnterMsg.Size = new System.Drawing.Size(145, 20);
            this.labelEnterMsg.TabIndex = 3;
            this.labelEnterMsg.Text = "Enter your message: ";
            this.labelEnterMsg.Click += new System.EventHandler(this.labelEnterMsg_Click);
            // 
            // buttonShowMsg
            // 
            this.buttonShowMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowMsg.Location = new System.Drawing.Point(299, 163);
            this.buttonShowMsg.Name = "buttonShowMsg";
            this.buttonShowMsg.Size = new System.Drawing.Size(138, 51);
            this.buttonShowMsg.TabIndex = 4;
            this.buttonShowMsg.Text = "Show message";
            this.buttonShowMsg.UseVisualStyleBackColor = true;
            this.buttonShowMsg.Click += new System.EventHandler(this.buttonShowMsg_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCut,
            this.toolStripMenuCopy,
            this.toolStripMenuPaste});
            this.menuStrip2.Location = new System.Drawing.Point(357, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(260, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuCut
            // 
            this.toolStripMenuCut.Name = "toolStripMenuCut";
            this.toolStripMenuCut.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuCut.Text = "Cut";
            this.toolStripMenuCut.Click += new System.EventHandler(this.toolStripMenuCut_Click);
            // 
            // toolStripMenuCopy
            // 
            this.toolStripMenuCopy.Name = "toolStripMenuCopy";
            this.toolStripMenuCopy.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuCopy.Text = "Copy";
            this.toolStripMenuCopy.Click += new System.EventHandler(this.toolStripMenuCopy_Click);
            // 
            // toolStripMenuPaste
            // 
            this.toolStripMenuPaste.Name = "toolStripMenuPaste";
            this.toolStripMenuPaste.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuPaste.Text = "Paste";
            this.toolStripMenuPaste.Click += new System.EventHandler(this.toolStripMenuPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.buttonShowMsg);
            this.Controls.Add(this.labelEnterMsg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "laboratory1_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFILE;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHELP;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripMsg;
        private System.Windows.Forms.ToolStripButton toolStripCheck;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEnterMsg;
        private System.Windows.Forms.Button buttonShowMsg;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPaste;
    }
}

