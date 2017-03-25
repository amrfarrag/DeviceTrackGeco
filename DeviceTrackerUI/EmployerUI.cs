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
    public partial class EmployerUI : Form
    {
        public EmployerUI()
        {
            InitializeComponent();
        }
        private Employer temp = null;
        public EmployerUI(Employer emp)
        {
            InitializeComponent();
            this.temp = emp;
            nametxt.Text = emp.Name;
            Titlecb.SelectedValue = emp.EmployerTitleID;

        }

        private void EmployerUI_Load(object sender, EventArgs e)
        {
            LoadProjects();
            LoadTitles();

        }
        private void LoadProjects()
        {
            ProjectMangment pmng = new ProjectMangment();
            projectcb.DisplayMember = "Name";
            projectcb.ValueMember = "ProjectID";
            projectcb.DataSource = pmng.GetProjects();
            
        }
        private void LoadTitles()
        {
            EmploymentManagement emmanage = new EmploymentManagement();
            Titlecb.DisplayMember = "Title";
            Titlecb.ValueMember = "ID";
            Titlecb.DataSource = emmanage.GetTitles();


        }
    }
}
