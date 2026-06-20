namespace AOI_Platform.UserControls
{
    partial class ucSystemConfig
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlcIP = new System.Windows.Forms.TextBox();
            this.txtPlcPort = new System.Windows.Forms.TextBox();
            this.txtCommandAddress = new System.Windows.Forms.TextBox();
            this.txtResultAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkUseFakePLC = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPlcIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPlcPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCommandAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtResultAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkUseFakePLC, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 237);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLC Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Command Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Use Fake PLC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlcIP
            // 
            this.txtPlcIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlcIP.Location = new System.Drawing.Point(379, 3);
            this.txtPlcIP.Name = "txtPlcIP";
            this.txtPlcIP.Size = new System.Drawing.Size(371, 25);
            this.txtPlcIP.TabIndex = 5;
            this.txtPlcIP.Text = "192.168.1.10";
            this.txtPlcIP.TextChanged += new System.EventHandler(this.txtPlcIP_TextChanged);
            // 
            // txtPlcPort
            // 
            this.txtPlcPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlcPort.Location = new System.Drawing.Point(379, 41);
            this.txtPlcPort.Name = "txtPlcPort";
            this.txtPlcPort.Size = new System.Drawing.Size(371, 25);
            this.txtPlcPort.TabIndex = 6;
            this.txtPlcPort.Text = "10003";
            // 
            // txtCommandAddress
            // 
            this.txtCommandAddress.Location = new System.Drawing.Point(379, 77);
            this.txtCommandAddress.Name = "txtCommandAddress";
            this.txtCommandAddress.Size = new System.Drawing.Size(371, 25);
            this.txtCommandAddress.TabIndex = 7;
            this.txtCommandAddress.Text = "D4920";
            this.txtCommandAddress.TextChanged += new System.EventHandler(this.txtCommandAddress_TextChanged);
            // 
            // txtResultAddress
            // 
            this.txtResultAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultAddress.Location = new System.Drawing.Point(379, 113);
            this.txtResultAddress.Name = "txtResultAddress";
            this.txtResultAddress.Size = new System.Drawing.Size(371, 25);
            this.txtResultAddress.TabIndex = 8;
            this.txtResultAddress.Text = "D4922";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(379, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(371, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkUseFakePLC
            // 
            this.chkUseFakePLC.AutoSize = true;
            this.chkUseFakePLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUseFakePLC.Location = new System.Drawing.Point(379, 150);
            this.chkUseFakePLC.Name = "chkUseFakePLC";
            this.chkUseFakePLC.Size = new System.Drawing.Size(371, 28);
            this.chkUseFakePLC.TabIndex = 11;
            this.chkUseFakePLC.Text = "FakePLC";
            this.chkUseFakePLC.UseVisualStyleBackColor = true;
            // 
            // ucSystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSystemConfig";
            this.Size = new System.Drawing.Size(753, 573);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlcIP;
        private System.Windows.Forms.TextBox txtPlcPort;
        private System.Windows.Forms.TextBox txtCommandAddress;
        private System.Windows.Forms.TextBox txtResultAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkUseFakePLC;
    }
}
