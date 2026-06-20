using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AOI_Platform.Core;
using AOI_Platform.Models;
using AOI_Platform.UserControls;


namespace AOI_Platform
{
    public partial class MainForm : Form
    {
        private ucInspection _ucInspection;
        private ucToolEditor _ucToolEditor;
        private ucPLCMonitor _ucPLCMonitor;
        private ucSystemConfig _ucSystemConfig;
        private ucLog _ucLog;

        private ConfigParameter _config;
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void InitializeModules()
        {
            _ucInspection = new ucInspection();
            _ucToolEditor = new ucToolEditor();
            _ucPLCMonitor = new ucPLCMonitor();
            _ucSystemConfig = new ucSystemConfig();
            _ucLog = new ucLog();

            AddUserControl(tpInspection, _ucInspection);
            AddUserControl(tpToolEditor, _ucToolEditor);
            AddUserControl(tpPLCMonitor, _ucPLCMonitor);
            AddUserControl(tpSystemConfig, _ucSystemConfig);
            AddUserControl(tpLog, _ucLog);
        }
        private void AddUserControl(TabPage tabPage, UserControl control)
        {
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();
            tabPage.Controls.Add(control);
        }
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void SaveConfig(ConfigParameter config)
        {
            _config = config;

            ConfigManager.Save(_config);

            LogManager.Info("Config Saved");
            _ucLog.AddMessage("[INFO] Config Saved");
        }
        private void ConnectModules()
        {
            // PLC Monitor 發出 Run 命令時
            // 交給 Inspection 模組執行檢測
            _ucPLCMonitor.OnRunCommand += _ucInspection.RunInspection;
            // Inspection 檢測完成後
            // 把 OK / NG 結果交回 PLC Monitor
            _ucInspection.OnInspectionFinished += _ucPLCMonitor.WriteResult;
            // Inspection 過程中的訊息
            // 顯示到 Log 頁面
            _ucInspection.OnLogMessage += _ucLog.AddMessage;
            
            _ucSystemConfig.OnSaveConfig += SaveConfig;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LogManager.Initialize();

            _config = ConfigManager.Load();

            InitializeModules();

            ConnectModules();

            _ucSystemConfig.LoadConfig(_config);

            LogManager.Info("MainForm Load");
            _ucLog.AddMessage("[INFO] MainForm Load");

        }
    }
}
