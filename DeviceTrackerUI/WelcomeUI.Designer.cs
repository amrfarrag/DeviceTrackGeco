﻿namespace DeviceTrackerUI
{
    partial class WelcomeUI
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
            this.ProjectManbtn = new System.Windows.Forms.Button();
            this.EmpManage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectManbtn
            // 
            this.ProjectManbtn.Location = new System.Drawing.Point(233, 122);
            this.ProjectManbtn.Name = "ProjectManbtn";
            this.ProjectManbtn.Size = new System.Drawing.Size(140, 126);
            this.ProjectManbtn.TabIndex = 0;
            this.ProjectManbtn.Text = "button1";
            this.ProjectManbtn.UseVisualStyleBackColor = true;
            this.ProjectManbtn.Click += new System.EventHandler(this.ProjectManbtn_Click);
            // 
            // EmpManage
            // 
            this.EmpManage.Location = new System.Drawing.Point(388, 122);
            this.EmpManage.Name = "EmpManage";
            this.EmpManage.Size = new System.Drawing.Size(140, 126);
            this.EmpManage.TabIndex = 1;
            this.EmpManage.Text = "button2";
            this.EmpManage.UseVisualStyleBackColor = true;
            this.EmpManage.Click += new System.EventHandler(this.EmpManage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 126);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // WelcomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EmpManage);
            this.Controls.Add(this.ProjectManbtn);
            this.Name = "WelcomeUI";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProjectManbtn;
        private System.Windows.Forms.Button EmpManage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

