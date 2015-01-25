namespace ElephantLogReader
{
    partial class MainForm
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.itmMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itmMainFileOpenManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itmMainFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenSavedVars = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmMainFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(284, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // itmMainFile
            // 
            this.itmMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmMainFileOpenManual,
            this.toolStripSeparator1,
            this.itmMainFileExit});
            this.itmMainFile.Name = "itmMainFile";
            this.itmMainFile.Size = new System.Drawing.Size(37, 20);
            this.itmMainFile.Text = "&File";
            // 
            // itmMainFileOpenManual
            // 
            this.itmMainFileOpenManual.Name = "itmMainFileOpenManual";
            this.itmMainFileOpenManual.Size = new System.Drawing.Size(214, 22);
            this.itmMainFileOpenManual.Text = "Open Saved&Variables File...";
            this.itmMainFileOpenManual.Click += new System.EventHandler(this.itmMainFileOpenManual_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // itmMainFileExit
            // 
            this.itmMainFileExit.Name = "itmMainFileExit";
            this.itmMainFileExit.Size = new System.Drawing.Size(214, 22);
            this.itmMainFileExit.Text = "E&xit";
            this.itmMainFileExit.Click += new System.EventHandler(this.itmMainFileExit_Click);
            // 
            // dlgOpenSavedVars
            // 
            this.dlgOpenSavedVars.DefaultExt = "lua";
            this.dlgOpenSavedVars.FileName = "Elephant.lua";
            this.dlgOpenSavedVars.Filter = "WoW SavedVariables File|*.lua|All files|*.*";
            this.dlgOpenSavedVars.InitialDirectory = "C:\\Program Files (x86)\\World of Warcraft\\WTF\\Account\\58477853#1\\Moon Guard\\Kruega" +
    "\\SavedVariables";
            this.dlgOpenSavedVars.ReadOnlyChecked = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "Elephant Log Reader";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem itmMainFile;
        private System.Windows.Forms.ToolStripMenuItem itmMainFileOpenManual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itmMainFileExit;
        private System.Windows.Forms.OpenFileDialog dlgOpenSavedVars;
    }
}

