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

        private void DeviceManagementUI_Load(object sender, EventArgs e)
        {
            
            //DeviceMangment dmn = new DeviceMangment();
            //devicegrid.DataSource= dmn.GetAllWorking().Select(p => new {ID=p.DeviceID
            //                                                   ,ProjectName=p.Project.Name
            //                                                   ,EmployerName=p.Employer.Name
            //                                                   ,Descripation =p.Description
            //                                                   ,Date=p.AssignedDate
            //                                                    });
        }
    }
}
