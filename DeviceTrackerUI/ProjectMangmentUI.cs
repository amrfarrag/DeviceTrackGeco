﻿using System;
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
    public partial class ProjectMangmentUI : Form
    {
        public ProjectMangmentUI()
        {
            InitializeComponent();
        }
        ProjectMangment pm;
        private void ProjectMangmentUI_Load(object sender, EventArgs e)
        {
           pm = new ProjectMangment();
           ProjectsGrid.DataSource= pm.GetProjects();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ProjectUI pui = new ProjectUI();
            pui.Show();
        }

        private void ProjectsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Project pr = (Project)ProjectsGrid.SelectedRows[0].DataBoundItem;
                ProjectUI ui = new ProjectUI(pr);
                ui.Show();
            }
            catch { }
        }
    }
}
