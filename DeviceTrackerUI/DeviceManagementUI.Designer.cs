namespace DeviceTrackerUI
{
    partial class DeviceManagementUI
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
            this.trackstatcmb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddDevicebtn = new System.Windows.Forms.Button();
            this.employerrb = new System.Windows.Forms.RadioButton();
            this.projectrb = new System.Windows.Forms.RadioButton();
            this.devicegrid = new System.Windows.Forms.DataGridView();
            this.projectemployercmb = new System.Windows.Forms.ComboBox();
            this.devicestatcmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.devicegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // trackstatcmb
            // 
            this.trackstatcmb.FormattingEnabled = true;
            this.trackstatcmb.Items.AddRange(new object[] {
            "All",
            "Owned"});
            this.trackstatcmb.Location = new System.Drawing.Point(423, 39);
            this.trackstatcmb.Name = "trackstatcmb";
            this.trackstatcmb.Size = new System.Drawing.Size(101, 21);
            this.trackstatcmb.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddDevicebtn
            // 
            this.AddDevicebtn.Location = new System.Drawing.Point(647, 37);
            this.AddDevicebtn.Name = "AddDevicebtn";
            this.AddDevicebtn.Size = new System.Drawing.Size(75, 23);
            this.AddDevicebtn.TabIndex = 17;
            this.AddDevicebtn.Text = "button1";
            this.AddDevicebtn.UseVisualStyleBackColor = true;
            this.AddDevicebtn.Click += new System.EventHandler(this.AddDevicebtn_Click);
            // 
            // employerrb
            // 
            this.employerrb.AutoSize = true;
            this.employerrb.Location = new System.Drawing.Point(162, 13);
            this.employerrb.Name = "employerrb";
            this.employerrb.Size = new System.Drawing.Size(87, 17);
            this.employerrb.TabIndex = 15;
            this.employerrb.Text = "radioButton2";
            this.employerrb.UseVisualStyleBackColor = true;
            // 
            // projectrb
            // 
            this.projectrb.AutoSize = true;
            this.projectrb.Checked = true;
            this.projectrb.Location = new System.Drawing.Point(16, 14);
            this.projectrb.Name = "projectrb";
            this.projectrb.Size = new System.Drawing.Size(87, 17);
            this.projectrb.TabIndex = 14;
            this.projectrb.TabStop = true;
            this.projectrb.Text = "radioButton1";
            this.projectrb.UseVisualStyleBackColor = true;
            // 
            // devicegrid
            // 
            this.devicegrid.AllowUserToAddRows = false;
            this.devicegrid.AllowUserToOrderColumns = true;
            this.devicegrid.AllowUserToResizeColumns = false;
            this.devicegrid.AllowUserToResizeRows = false;
            this.devicegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicegrid.Location = new System.Drawing.Point(9, 77);
            this.devicegrid.Name = "devicegrid";
            this.devicegrid.RowHeadersVisible = false;
            this.devicegrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devicegrid.Size = new System.Drawing.Size(788, 463);
            this.devicegrid.TabIndex = 13;
            this.devicegrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devicegrid_CellDoubleClick);
            // 
            // projectemployercmb
            // 
            this.projectemployercmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.projectemployercmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.projectemployercmb.FormattingEnabled = true;
            this.projectemployercmb.Location = new System.Drawing.Point(16, 39);
            this.projectemployercmb.Name = "projectemployercmb";
            this.projectemployercmb.Size = new System.Drawing.Size(401, 21);
            this.projectemployercmb.TabIndex = 20;
            // 
            // devicestatcmb
            // 
            this.devicestatcmb.FormattingEnabled = true;
            this.devicestatcmb.Location = new System.Drawing.Point(530, 39);
            this.devicestatcmb.Name = "devicestatcmb";
            this.devicestatcmb.Size = new System.Drawing.Size(101, 21);
            this.devicestatcmb.TabIndex = 21;
            // 
            // DeviceManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 553);
            this.Controls.Add(this.devicestatcmb);
            this.Controls.Add(this.projectemployercmb);
            this.Controls.Add(this.trackstatcmb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddDevicebtn);
            this.Controls.Add(this.employerrb);
            this.Controls.Add(this.projectrb);
            this.Controls.Add(this.devicegrid);
            this.Name = "DeviceManagementUI";
            this.Text = "DeviceManagementUI";
            this.Load += new System.EventHandler(this.DeviceManagementUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devicegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trackstatcmb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddDevicebtn;
        private System.Windows.Forms.RadioButton employerrb;
        private System.Windows.Forms.RadioButton projectrb;
        private System.Windows.Forms.DataGridView devicegrid;
        private System.Windows.Forms.ComboBox projectemployercmb;
        private System.Windows.Forms.ComboBox devicestatcmb;
    }
}