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
    public partial class TransferUI : Form
    {
        public TransferUI()
        {
            InitializeComponent();
            LoadProjects();
            projectcmb.SelectedIndex = -1;
        }

        private void TransferUI_Load(object sender, EventArgs e)
        {

        }
        private void LoadProjects()
        {
            ProjectMangment pm = new ProjectMangment();
            projectcmb.DisplayMember = "Name";
            projectcmb.ValueMember = "ProjectID";
            projectcmb.DataSource = pm.GetProjects();
        }
        private void LoadEmployers(Project pr)
        {
            
            employercmb.DisplayMember = "Name";
            employercmb.ValueMember = "EmployerID";
            if(pr == null)
            {
                EmploymentManagement emng = new EmploymentManagement();
                employercmb.DataSource= emng.GetEmployers();
            }
                else employercmb.DataSource = pr.GetEmployers();
            employercmb.SelectedIndex = -1;
        }

        private void projectcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadEmployers((Project)projectcmb.SelectedItem);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
