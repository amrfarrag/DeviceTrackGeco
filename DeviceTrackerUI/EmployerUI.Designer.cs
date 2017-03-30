namespace DeviceTrackerUI
{
    partial class EmployerUI
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
            this.Savebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.Titlecb = new System.Windows.Forms.ComboBox();
            this.projectcb = new System.Windows.Forms.ComboBox();
            this.joinbtn = new System.Windows.Forms.RadioButton();
            this.transferbtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(219, 312);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "Add";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fired";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(190, 82);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(232, 20);
            this.nametxt.TabIndex = 2;
            // 
            // Titlecb
            // 
            this.Titlecb.FormattingEnabled = true;
            this.Titlecb.Location = new System.Drawing.Point(190, 168);
            this.Titlecb.Name = "Titlecb";
            this.Titlecb.Size = new System.Drawing.Size(232, 21);
            this.Titlecb.TabIndex = 4;
            // 
            // projectcb
            // 
            this.projectcb.FormattingEnabled = true;
            this.projectcb.Location = new System.Drawing.Point(190, 209);
            this.projectcb.Name = "projectcb";
            this.projectcb.Size = new System.Drawing.Size(232, 21);
            this.projectcb.TabIndex = 5;
            // 
            // joinbtn
            // 
            this.joinbtn.AutoSize = true;
            this.joinbtn.Checked = true;
            this.joinbtn.Location = new System.Drawing.Point(190, 260);
            this.joinbtn.Name = "joinbtn";
            this.joinbtn.Size = new System.Drawing.Size(44, 17);
            this.joinbtn.TabIndex = 6;
            this.joinbtn.TabStop = true;
            this.joinbtn.Text = "Join";
            this.joinbtn.UseVisualStyleBackColor = true;
            // 
            // transferbtn
            // 
            this.transferbtn.AutoSize = true;
            this.transferbtn.Location = new System.Drawing.Point(319, 260);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(66, 17);
            this.transferbtn.TabIndex = 7;
            this.transferbtn.Text = "Transfer";
            this.transferbtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // EmployerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 496);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.transferbtn);
            this.Controls.Add(this.joinbtn);
            this.Controls.Add(this.projectcb);
            this.Controls.Add(this.Titlecb);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Savebtn);
            this.Name = "EmployerUI";
            this.Text = "Employer";
            this.Load += new System.EventHandler(this.EmployerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox Titlecb;
        private System.Windows.Forms.ComboBox projectcb;
        private System.Windows.Forms.RadioButton joinbtn;
        private System.Windows.Forms.RadioButton transferbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}