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

            DeviceMangment dmn = new DeviceMangment();
            devicestatcmb.DataSource = Enum.GetNames(typeof(State));
            devicestatcmb.SelectedIndex = -1;
            LoadProjects();
            var x = dmn.GetAllWorking()
                .Select(p => new
                {
                    ID = p.DeviceID
                                                               ,
                    ProjectName = p.GetProject().Name
                                                               ,
                    EmployerName = p.GetEmployer().Name
                                                               ,
                    Descripation = p.Description
                                                               ,
                    Date = p.AssignedDate
                }).ToList();
            devicegrid.DataSource = x;
            devicestatcmb.SelectedIndexChanged += Devicestatcmb_SelectedIndexChanged;
            projectrb.CheckedChanged += Projectrb_CheckedChanged;
            projectemployercmb.SelectedIndexChanged += Projectemployercmb_SelectedIndexChanged;
        }

        private void Projectemployercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Projectrb_CheckedChanged(object sender, EventArgs e)
        {
            if (projectrb.Checked) LoadProjects();
            else LoadEmployers();
        }

        private void Devicestatcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void devicegrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeviceMangment dmng = new DeviceMangment();
            DeviceUI ui = new DeviceUI(dmng.GetDevice((int)devicegrid.SelectedRows[0].Cells[0].Value));
            ui.Show();
        }
        private void LoadProjects()
        {
            ProjectMangment pm = new ProjectMangment();
            projectemployercmb.DataSource = pm.GetProjects();
            projectemployercmb.DisplayMember = "Name";
            projectemployercmb.ValueMember = "ProjectID";
            projectemployercmb.SelectedIndex = -1;

        }
        private void LoadEmployers()
        {
            EmploymentManagement emang = new EmploymentManagement();
            projectemployercmb.DataSource = emang.GetEmployers();
            projectemployercmb.DisplayMember = "Name";
            projectemployercmb.ValueMember = "EmployerID";
            projectemployercmb.SelectedIndex = -1;
        }
    }
}
