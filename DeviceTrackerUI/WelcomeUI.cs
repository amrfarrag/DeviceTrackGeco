﻿using System;
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
    public partial class WelcomeUI : Form
    {
        public WelcomeUI()
        {
            InitializeComponent();
        }

        private void ProjectManbtn_Click(object sender, EventArgs e)
        {
            ProjectMangmentUI prmui = new ProjectMangmentUI();
            prmui.Show();
        }

        private void EmpManage_Click(object sender, EventArgs e)
        {
            EmploymentManagementUI ui = new EmploymentManagementUI();
            ui.Show();
        }

        private void DeviceMangmentUI_Click(object sender, EventArgs e)
        {
            DeviceManagementUI ui = new DeviceManagementUI();
            ui.Show();
        }
    }
}
