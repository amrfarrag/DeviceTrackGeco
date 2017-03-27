namespace DeviceTrackerUI
{
    partial class TransferUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.descipationtxt = new System.Windows.Forms.TextBox();
            this.projectcmb = new System.Windows.Forms.ComboBox();
            this.employercmb = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.Endbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // descipationtxt
            // 
            this.descipationtxt.Location = new System.Drawing.Point(79, 38);
            this.descipationtxt.Multiline = true;
            this.descipationtxt.Name = "descipationtxt";
            this.descipationtxt.Size = new System.Drawing.Size(203, 70);
            this.descipationtxt.TabIndex = 1;
            // 
            // projectcmb
            // 
            this.projectcmb.FormattingEnabled = true;
            this.projectcmb.Location = new System.Drawing.Point(82, 164);
            this.projectcmb.Name = "projectcmb";
            this.projectcmb.Size = new System.Drawing.Size(200, 21);
            this.projectcmb.TabIndex = 2;
            this.projectcmb.SelectedIndexChanged += new System.EventHandler(this.projectcmb_SelectedIndexChanged);
            // 
            // employercmb
            // 
            this.employercmb.FormattingEnabled = true;
            this.employercmb.Location = new System.Drawing.Point(82, 192);
            this.employercmb.Name = "employercmb";
            this.employercmb.Size = new System.Drawing.Size(200, 21);
            this.employercmb.TabIndex = 3;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(92, 229);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 38);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "button1";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Endbtn
            // 
            this.Endbtn.Location = new System.Drawing.Point(194, 229);
            this.Endbtn.Name = "Endbtn";
            this.Endbtn.Size = new System.Drawing.Size(75, 38);
            this.Endbtn.TabIndex = 5;
            this.Endbtn.Text = "button2";
            this.Endbtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // TransferUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Endbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.employercmb);
            this.Controls.Add(this.projectcmb);
            this.Controls.Add(this.descipationtxt);
            this.Controls.Add(this.label1);
            this.Name = "TransferUI";
            this.Text = "TransferUI";
            this.Load += new System.EventHandler(this.TransferUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descipationtxt;
        private System.Windows.Forms.ComboBox projectcmb;
        private System.Windows.Forms.ComboBox employercmb;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button Endbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}