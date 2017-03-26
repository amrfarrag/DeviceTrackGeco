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
        }

        private void Addempbtn_Click(object sender, EventArgs e)
        {
            EmployerUI ui = new EmployerUI();
            ui.Show();
        }
    }
}
