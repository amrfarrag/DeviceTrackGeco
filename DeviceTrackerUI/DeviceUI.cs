using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
namespace DeviceTrackerUI
{
    public partial class DeviceUI : Form
    {
        Device temp = null;
        public DeviceUI(Device dv)
        {
            InitializeComponent();
            this.temp = dv;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            TransferUI ui = new TransferUI(temp);
            ui.Show();
        }

        private void DeviceUI_Load(object sender, EventArgs e)
        {
            destxt.Text = temp.Description;
            label1.Text = temp.ID.ToString();


        }
    }
}
