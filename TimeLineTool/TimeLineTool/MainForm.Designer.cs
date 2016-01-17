namespace TimeLineTool {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLine_panel = new System.Windows.Forms.Panel();
            this.nodeView_panel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1476, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu_exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(64, 36);
            this.fileMenu.Text = "File";
            // 
            // fileMenu_exit
            // 
            this.fileMenu_exit.Name = "fileMenu_exit";
            this.fileMenu_exit.Size = new System.Drawing.Size(269, 38);
            this.fileMenu_exit.Text = "Exit";
            this.fileMenu_exit.Click += new System.EventHandler(this.fileMenu_exit_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenu_About});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(77, 36);
            this.helpMenu.Text = "Help";
            // 
            // helpMenu_About
            // 
            this.helpMenu_About.Name = "helpMenu_About";
            this.helpMenu_About.Size = new System.Drawing.Size(269, 38);
            this.helpMenu_About.Text = "About";
            this.helpMenu_About.Click += new System.EventHandler(this.helpMenu_About_Click);
            // 
            // timeLine_panel
            // 
            this.timeLine_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timeLine_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timeLine_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLine_panel.Location = new System.Drawing.Point(0, 43);
            this.timeLine_panel.Name = "timeLine_panel";
            this.timeLine_panel.Size = new System.Drawing.Size(1011, 664);
            this.timeLine_panel.TabIndex = 1;
            // 
            // nodeView_panel
            // 
            this.nodeView_panel.Location = new System.Drawing.Point(1006, 43);
            this.nodeView_panel.Name = "nodeView_panel";
            this.nodeView_panel.Size = new System.Drawing.Size(484, 664);
            this.nodeView_panel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1109);
            this.Controls.Add(this.nodeView_panel);
            this.Controls.Add(this.timeLine_panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "LVG - Timeline Tool";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu_About;
        private System.Windows.Forms.ToolStripMenuItem fileMenu_exit;
        private System.Windows.Forms.Panel timeLine_panel;
        private System.Windows.Forms.Panel nodeView_panel;
    }
}

