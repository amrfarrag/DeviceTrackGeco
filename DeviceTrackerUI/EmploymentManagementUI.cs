using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Windows.Forms;

namespace DeviceTrackerUI
{
    public partial class EmploymentManagementUI : Form
    {
        public EmploymentManagementUI()
        {
            InitializeComponent();
        }
        Project tproject =null;
        public EmploymentManagementUI(Project pr)
        {
            InitializeComponent();
            this.tproject = pr; 
        }

        private void EmploymentManagementUI_Load(object sender, EventArgs e)
        {
            EmploymentManagement mm = new EmploymentManagement();
            EmployerGrid.DataSource = mm.GetEmployers();
            projectrb.CheckedChanged += Projectrb_CheckedChanged;
            projectempcb.SelectedIndexChanged += Projectempcb_SelectedIndexChanged;
        }

        private void Projectempcb_SelectedIndexChanged(object sender, EventArgs e)
        {

            EmployerGrid.DataSource = ((Project)projectempcb.SelectedItem).GetEmployers();
        }

        private void Projectrb_CheckedChanged(object sender, EventArgs e)
        {
            if (projectrb.Checked)
            {
                projectempcb.SelectedIndexChanged -= Projectempcb_SelectedIndexChanged;
                ProjectMangment pm = new ProjectMangment();
                projectempcb.DataSource = pm.GetProjects();
                projectempcb.DisplayMember = "Name";
                projectempcb.ValueMember = "ProjectID";
                projectempcb.SelectedIndex = -1;
                projectempcb.SelectedIndexChanged += Projectempcb_SelectedIndexChanged;

            }
        }

        private void Addempbtn_Click(object sender, EventArgs e)
        {
            EmployerUI ui = new EmployerUI();
            ui.Show();
        }

        private void EmployerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                Employer emp = (Employer)EmployerGrid.SelectedRows[0].DataBoundItem;
                EmployerUI ui = new EmployerUI(emp);
                ui.Show();
            
        
        }


    }
}
