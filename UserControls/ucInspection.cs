using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AOI_Platform.UserControls
{
    public partial class ucInspection : UserControl
    {
        // 宣告一個事件，用來通知外部顯示 Log
        public event Action<string> OnLogMessage;
        // 宣告一個事件，用來通知外部檢測結果
        // bool = true 代表 OK，false 代表 NG
        public event Action<bool> OnInspectionFinished;

        public ucInspection()
        {
            InitializeComponent();
        }

        public async void RunInspection()
        {
            // 通知 Log 頁面：檢測開始
            OnLogMessage?.Invoke("[INFO] Inspection Start");
            // 模擬檢測花費 1 秒
            await Task.Delay(1000);
            // 模擬檢測結果，目前固定為 OK
            bool result = true;
            // 通知 Log 頁面：檢測完成
            OnLogMessage?.Invoke("[INFO] Inspection Finished: OK");
            // 通知外部：檢測完成，並傳出 OK / NG 結果
            OnInspectionFinished?.Invoke(result);
        }
    }
}