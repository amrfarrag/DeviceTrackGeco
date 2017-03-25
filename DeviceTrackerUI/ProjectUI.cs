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
    public partial class ProjectUI : Form
    {
        public ProjectUI()
        {
            InitializeComponent();
        }
        public ProjectUI(Project pr)
        {
            InitializeComponent();
            this.temp = pr;
            Nametxt.Text = temp.Name;
            ProjectDateStart.Value = temp.StartDate;
            Locationtxt.Text = temp.Location;

        }
        private Project temp = null;

        private void AddEmployer_Click(object sender, EventArgs e)
        {

        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            ProjectMangment prmng = new ProjectMangment();
            if (temp == null)
            {
                temp  = new Project() { Name = Nametxt.Text, Location = Locationtxt.Text, StartDate = ProjectDateStart.Value };

            }
            else
            {
                temp.Name = Nametxt.Text;
                temp.Location = Locationtxt.Text;
                temp.StartDate = ProjectDateStart.Value;
            }
            prmng.Save(temp);
            this.Close();
        }

        private void ProjectUI_Load(object sender, EventArgs e)
        {

        }
    }
}
