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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectDateStart
            // 
            this.ProjectDateStart.Location = new System.Drawing.Point(184, 130);
            this.ProjectDateStart.Name = "ProjectDateStart";
            this.ProjectDateStart.Size = new System.Drawing.Size(200, 20);
            this.ProjectDateStart.TabIndex = 0;
            // 
            // Locationtxt
            // 
            this.Locationtxt.Location = new System.Drawing.Point(184, 81);
            this.Locationtxt.Name = "Locationtxt";
            this.Locationtxt.Size = new System.Drawing.Size(200, 20);
            this.Locationtxt.TabIndex = 1;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(184, 30);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(200, 20);
            this.Nametxt.TabIndex = 3;
            // 
            // SaveProject
            // 
            this.SaveProject.Location = new System.Drawing.Point(245, 184);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(75, 58);
            this.SaveProject.TabIndex = 6;
            this.SaveProject.Text = "Save";
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // ProjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}