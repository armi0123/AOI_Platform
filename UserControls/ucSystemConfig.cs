using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOI_Platform.Models;

namespace AOI_Platform.UserControls
{
    public partial class ucSystemConfig : UserControl
    {
        public event Action<ConfigParameter> OnSaveConfig;
        public ucSystemConfig()
        {
            InitializeComponent();
        }
        public void LoadConfig(ConfigParameter parameter)
        {
            txtPlcIP.Text = parameter.PlcIP;
            txtPlcPort.Text = parameter.PlcPort.ToString();
            txtCommandAddress.Text = parameter.CommandAddress;
            txtResultAddress.Text = parameter.ResultAddress;
            chkUseFakePLC.Checked = parameter.UseFakePLC;
        }
        private void txtCommandAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlcIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigParameter parameter = new ConfigParameter();

            parameter.PlcIP = txtPlcIP.Text;
            parameter.PlcPort = int.Parse(txtPlcPort.Text);
            parameter.CommandAddress = txtCommandAddress.Text;
            parameter.ResultAddress = txtResultAddress.Text;
            parameter.UseFakePLC = chkUseFakePLC.Checked;

            OnSaveConfig?.Invoke(parameter);

            MessageBox.Show("設定已儲存");
        }      
    }
}
