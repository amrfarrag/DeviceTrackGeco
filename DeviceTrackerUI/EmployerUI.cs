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
        private Employer temp = new Employer();
        public EmployerUI(Employer emp)
        {
            InitializeComponent();
            LoadProjects();
            LoadTitles();
            this.temp = emp;
            nametxt.Text = emp.Name;
            Titlecb.SelectedValue = emp.EmployerTitleID;
            projectcb.SelectedValue = emp.GetCurrentProject() == null ? -1 : emp.GetCurrentProject().ProjectID;
        }

        private void EmployerUI_Load(object sender, EventArgs e)
        {


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
            EmploymentManagement emmanage = null;
            temp .EmployerTitleID = (int)Titlecb.SelectedValue ;
            temp.Name = nametxt.Text;
            if (temp==null)
            {
                emmanage = new EmploymentManagement();
                emmanage.Save(temp);
                emmanage.Join((int)projectcb.SelectedValue,dateTimePicker1.Value);
            }
            else
            {
                emmanage = new EmploymentManagement(temp);
                emmanage.Save(temp);
                if (joinbtn.Checked) emmanage.Join((int)projectcb.SelectedValue, dateTimePicker1.Value);
                else emmanage.Transfer((int)projectcb.SelectedValue, dateTimePicker1.Value);
                
            }
            this.Close();
        }
    }
}
