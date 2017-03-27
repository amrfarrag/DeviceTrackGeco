using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTrackerUI
{
    public partial class DeviceManagementUI : Form
    {
        public DeviceManagementUI()
        {
            InitializeComponent();

        }

        private void AddDevicebtn_Click(object sender, EventArgs e)
        {
            TransferUI ui = new TransferUI();
            ui.Show();
        }

    }
}
