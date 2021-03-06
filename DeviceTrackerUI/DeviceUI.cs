﻿using System;
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
            DeviceMangment dmn = new DeviceMangment();
            var x = dmn.GetAllTracking(temp)
                ?.Select(p => new DeviceTrackProjection
                {
                    ID = p.DeviceID
                                                        ,
                    ProjectName = p?.GetProject()?.Name
                                                        ,
                    EmployerName = p?.GetEmployer()?.Name
                                                        ,
                    Descripation = p.Description
                                                        ,
                    Date = p.AssignedDate,
                    IsOwned = p.IsOwned
                }).ToList();

            devicegrid.DataSource = x;
        }

        private void devicegrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
