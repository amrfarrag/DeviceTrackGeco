namespace DeviceTrackerUI
{
    partial class ProjectUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjectDateStart = new System.Windows.Forms.DateTimePicker();
            this.Locationtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.SaveProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectDateStart
            // 
            this.ProjectDateStart.Location = new System.Drawing.Point(157, 82);
            this.ProjectDateStart.Name = "ProjectDateStart";
            this.ProjectDateStart.Size = new System.Drawing.Size(200, 20);
            this.ProjectDateStart.TabIndex = 0;
            // 
            // Locationtxt
            // 
            this.Locationtxt.Location = new System.Drawing.Point(157, 129);
            this.Locationtxt.Name = "Locationtxt";
            this.Locationtxt.Size = new System.Drawing.Size(200, 20);
            this.Locationtxt.TabIndex = 1;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(157, 28);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(200, 20);
            this.Nametxt.TabIndex = 3;
            // 
            // SaveProject
            // 
            this.SaveProject.Location = new System.Drawing.Point(157, 165);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(75, 108);
            this.SaveProject.TabIndex = 6;
            this.SaveProject.Text = "Save";
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // ProjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 354);
            this.Controls.Add(this.SaveProject);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Locationtxt);
            this.Controls.Add(this.ProjectDateStart);
            this.Name = "ProjectUI";
            this.Text = "ProjectUI";
            this.Load += new System.EventHandler(this.ProjectUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ProjectDateStart;
        private System.Windows.Forms.TextBox Locationtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Button SaveProject;
    }
}