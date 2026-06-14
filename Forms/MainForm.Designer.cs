namespace AOI_Platform
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpInspection = new System.Windows.Forms.TabPage();
            this.tpToolEditor = new System.Windows.Forms.TabPage();
            this.tpPLCMonitor = new System.Windows.Forms.TabPage();
            this.tpSystemConfig = new System.Windows.Forms.TabPage();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tcMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpInspection);
            this.tcMain.Controls.Add(this.tpToolEditor);
            this.tcMain.Controls.Add(this.tpPLCMonitor);
            this.tcMain.Controls.Add(this.tpSystemConfig);
            this.tcMain.Controls.Add(this.tpLog);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(831, 439);
            this.tcMain.TabIndex = 1;
            // 
            // tpInspection
            // 
            this.tpInspection.Location = new System.Drawing.Point(4, 25);
            this.tpInspection.Name = "tpInspection";
            this.tpInspection.Padding = new System.Windows.Forms.Padding(3);
            this.tpInspection.Size = new System.Drawing.Size(823, 410);
            this.tpInspection.TabIndex = 0;
            this.tpInspection.Text = "Inspection";
            this.tpInspection.UseVisualStyleBackColor = true;
            // 
            // tpToolEditor
            // 
            this.tpToolEditor.Location = new System.Drawing.Point(4, 25);
            this.tpToolEditor.Name = "tpToolEditor";
            this.tpToolEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tpToolEditor.Size = new System.Drawing.Size(823, 410);
            this.tpToolEditor.TabIndex = 1;
            this.tpToolEditor.Text = "Tool Editor";
            this.tpToolEditor.UseVisualStyleBackColor = true;
            // 
            // tpPLCMonitor
            // 
            this.tpPLCMonitor.Location = new System.Drawing.Point(4, 25);
            this.tpPLCMonitor.Name = "tpPLCMonitor";
            this.tpPLCMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tpPLCMonitor.Size = new System.Drawing.Size(823, 410);
            this.tpPLCMonitor.TabIndex = 2;
            this.tpPLCMonitor.Text = "PLC Monitor";
            this.tpPLCMonitor.UseVisualStyleBackColor = true;
            // 
            // tpSystemConfig
            // 
            this.tpSystemConfig.Location = new System.Drawing.Point(4, 25);
            this.tpSystemConfig.Name = "tpSystemConfig";
            this.tpSystemConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpSystemConfig.Size = new System.Drawing.Size(823, 410);
            this.tpSystemConfig.TabIndex = 3;
            this.tpSystemConfig.Text = "System Config";
            this.tpSystemConfig.UseVisualStyleBackColor = true;
            // 
            // tpLog
            // 
            this.tpLog.Location = new System.Drawing.Point(4, 25);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(823, 410);
            this.tpLog.TabIndex = 4;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 466);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "要你命5000";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpInspection;
        private System.Windows.Forms.TabPage tpToolEditor;
        private System.Windows.Forms.TabPage tpPLCMonitor;
        private System.Windows.Forms.TabPage tpSystemConfig;
        private System.Windows.Forms.TabPage tpLog;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

