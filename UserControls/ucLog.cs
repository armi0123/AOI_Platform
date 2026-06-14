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
    public partial class ucLog : UserControl
    {
        public ucLog()
        {
            InitializeComponent();
        }
        
        public void AddMessage(string message)
        {
            
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddMessage), message);
                return;
            }
            
            if (lsbLog.Items.Count > 1000)
            {
                lsbLog.Items.Clear();
            }
            
            lsbLog.Items.Insert(
                0,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "  " + message
            );
        }
    }
}
