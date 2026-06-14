namespace AOI_Platform.UserControls
{
    partial class ucLog
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbLog
            // 
            this.lsbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.ItemHeight = 15;
            this.lsbLog.Location = new System.Drawing.Point(0, 0);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.Size = new System.Drawing.Size(639, 531);
            this.lsbLog.TabIndex = 0;
            // 
            // ucLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsbLog);
            this.Name = "ucLog";
            this.Size = new System.Drawing.Size(639, 531);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbLog;
    }
}
