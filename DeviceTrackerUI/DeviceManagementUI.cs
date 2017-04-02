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
        List<DeviceTrackProjection> projection = null;
        public DeviceManagementUI()
        {
            InitializeComponent();
            this.projection = new List<DeviceTrackProjection>();

        }

        private void AddDevicebtn_Click(object sender, EventArgs e)
        {
            TransferUI ui = new TransferUI();
            ui.Show();
        }

        private void DeviceManagementUI_Load(object sender, EventArgs e)
        {


            this.devicestatcmb.DataSource = Enum.GetValues(typeof(State)).Cast<State>()
                                            .Select(x => new { Value = x, Text = x.ToString() })
                                            .ToList();
            this.devicestatcmb.ValueMember = "Value";
            this.devicestatcmb.DisplayMember = "Text";
            devicestatcmb.SelectedIndex = -1;
            LoadProjects();
            LoadGrid();
            devicegrid.DataSource = projection;
            devicestatcmb.SelectedIndexChanged += Devicestatcmb_SelectedIndexChanged;
            projectrb.CheckedChanged += Projectrb_CheckedChanged;
            projectemployercmb.SelectedIndexChanged += Projectemployercmb_SelectedIndexChanged;
            devicestatcmb.SelectedIndexChanged += Devicestatcmb_SelectedIndexChanged1;
        }

        private void Devicestatcmb_SelectedIndexChanged1(object sender, EventArgs e)
        {
            DeviceMangment dm = new DeviceMangment();
            if (devicestatcmb.SelectedIndex == 2) LoadGrid();
            
            else {
                devicegrid.DataSource = dm.GetDeviceByState((int)devicestatcmb.SelectedValue);
            }
        }

        private void Projectemployercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceMangment dmn = new DeviceMangment();
            if (projectrb.Checked)
            {

                devicegrid.DataSource = dmn.GetAllWorking((Project)projectemployercmb.SelectedItem == null ? new Project() : (Project)projectemployercmb.SelectedItem)
                    ?.Select(p => new DeviceTrackProjection
                    {
                        ID = p.DeviceID
                                                                   ,
                        ProjectName = p?.GetProject()?.Name
                                                                   ,
                        EmployerName = p?.GetEmployer()?.Name
                                                                   ,
                        Descripation = p?.Description
                                                                   ,
                        IsOwned = p.IsOwned                         ,
                        Date = p.AssignedDate
                    }).ToList();
            }
            else
            {

                devicegrid.DataSource = dmn.GetAllWorking((Employer)projectemployercmb.SelectedItem == null ? new Employer(): (Employer)projectemployercmb.SelectedItem)
                .Select(p => new DeviceTrackProjection
                {
                    ID = p.DeviceID
                                                        ,
                    ProjectName = p?.GetProject()?.Name
                                                        ,
                    EmployerName = p?.GetEmployer()?.Name
                                                        ,
                    Descripation = p?.Description
                                                        ,
                    Date = p.AssignedDate               ,
                    IsOwned = p.IsOwned
                }).ToList();
            }

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
            devicestatcmb.SelectedIndexChanged -= Devicestatcmb_SelectedIndexChanged;

            ProjectMangment pm = new ProjectMangment();
            projectemployercmb.DataSource = pm.GetProjects();
            projectemployercmb.DisplayMember = "Name";
            projectemployercmb.ValueMember = "ProjectID";
            projectemployercmb.SelectedIndex = -1;
            devicestatcmb.SelectedIndexChanged += Devicestatcmb_SelectedIndexChanged;


        }
        private void LoadEmployers()
        {
            devicestatcmb.SelectedIndexChanged -= Devicestatcmb_SelectedIndexChanged;
            EmploymentManagement emang = new EmploymentManagement();
            projectemployercmb.DataSource = emang.GetEmployers();
            projectemployercmb.DisplayMember = "Name";
            projectemployercmb.ValueMember = "EmployerID";
            projectemployercmb.SelectedIndex = -1;
            devicestatcmb.SelectedIndexChanged += Devicestatcmb_SelectedIndexChanged;

        }
        private void LoadGrid()
        {
            DeviceMangment dmn = new DeviceMangment();
            projection = dmn.GetAllWorking()
               ?.Select(p => new DeviceTrackProjection
               {
                   ID = p.DeviceID
                                                              ,
                   ProjectName = p.GetProject()?.Name
                                                              ,
                   EmployerName = p.GetEmployer()?.Name
                                                              ,
                   Descripation = p.Description
                                                              ,
                   IsOwned = p.IsOwned,
                   Date = p.AssignedDate
               }).ToList();
            devicegrid.DataSource = projection;
        }
    }
}
