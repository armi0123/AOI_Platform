using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AOI_Platform
{
    public partial class ucPLCMonitor : UserControl
    {
        // 宣告一個事件，代表「PLC 有 Run 命令」
        // 目前先用 Fake Run 按鈕模擬，未來會改成讀取 PLC D4920
        public event Action OnRunCommand;
        public ucPLCMonitor()
        {
            InitializeComponent();
        }

        private void btnFakeRun_Click(object sender, EventArgs e)
        {
            // 觸發 Run 命令事件
            // 如果 MainForm 有把這個事件接到 ucInspection.RunInspection()
            // 那按下 Fake Run 後，就會開始執行檢測
            OnRunCommand?.Invoke();
        }
        //在ucPLCMonitor中新增一個方法，用來接收檢測結果並顯示在MessageBox中
        public void WriteResult(bool isOK)
        {
            string result = isOK ? "OK" : "NG";

            MessageBox.Show("PLC收到檢測結果：" + result);
            //之後會使用PlcManager來寫入PLC的D4922位址，寫入1代表OK，寫入0代表NG
            //PlcManager.WriteWord("D4922", isOK ? 1 : 0);
        }
    }
}
