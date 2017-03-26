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
            projectcb.SelectedValue = emp.GetCurrentProject() == null ? -1 : emp.GetCurrentProject().ProjectID;

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

        private void Savebtn_Click(object sender, EventArgs e)
        {
            EmploymentManagement emmanage = new EmploymentManagement();

            if (temp==null)
            {
                temp = new Employer() { Name = nametxt.Text ,EmployerTitleID=(int)Titlecb.SelectedValue };
                emmanage.Save(temp);
                emmanage.Join((int)projectcb.SelectedValue,dateTimePicker1.Value);
            }
            else
            {
                if (joinbtn.Checked) emmanage.Join((int)projectcb.SelectedValue, dateTimePicker1.Value);
                else emmanage.Transfer((int)projectcb.SelectedValue, dateTimePicker1.Value);
                
            }
        }
    }
}
