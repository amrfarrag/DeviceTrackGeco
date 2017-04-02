namespace DeviceTrackerUI
{
    partial class EmploymentManagementUI
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
            this.EmployerGrid = new System.Windows.Forms.DataGridView();
            this.empstatrb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Addempbtn = new System.Windows.Forms.Button();
            this.projectrb = new System.Windows.Forms.RadioButton();
            this.namerb = new System.Windows.Forms.RadioButton();
            this.projectempcb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployerGrid
            // 
            this.EmployerGrid.AllowUserToAddRows = false;
            this.EmployerGrid.AllowUserToDeleteRows = false;
            this.EmployerGrid.AllowUserToResizeColumns = false;
            this.EmployerGrid.AllowUserToResizeRows = false;
            this.EmployerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployerGrid.Location = new System.Drawing.Point(12, 78);
            this.EmployerGrid.Name = "EmployerGrid";
            this.EmployerGrid.RowHeadersVisible = false;
            this.EmployerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployerGrid.Size = new System.Drawing.Size(788, 463);
            this.EmployerGrid.TabIndex = 0;
            this.EmployerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployerGrid_CellDoubleClick);
            // 
            // empstatrb
            // 
            this.empstatrb.FormattingEnabled = true;
            this.empstatrb.Location = new System.Drawing.Point(423, 40);
            this.empstatrb.Name = "empstatrb";
            this.empstatrb.Size = new System.Drawing.Size(183, 21);
            this.empstatrb.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Addempbtn
            // 
            this.Addempbtn.Location = new System.Drawing.Point(650, 38);
            this.Addempbtn.Name = "Addempbtn";
            this.Addempbtn.Size = new System.Drawing.Size(75, 23);
            this.Addempbtn.TabIndex = 10;
            this.Addempbtn.Text = "Add";
            this.Addempbtn.UseVisualStyleBackColor = true;
            this.Addempbtn.Click += new System.EventHandler(this.Addempbtn_Click);
            // 
            // projectrb
            // 
            this.projectrb.AutoSize = true;
            this.projectrb.Checked = true;
            this.projectrb.Location = new System.Drawing.Point(19, 12);
            this.projectrb.Name = "projectrb";
            this.projectrb.Size = new System.Drawing.Size(59, 17);
            this.projectrb.TabIndex = 8;
            this.projectrb.TabStop = true;
            this.projectrb.Text = "Project";
            this.projectrb.UseVisualStyleBackColor = true;
            // 
            // namerb
            // 
            this.namerb.AutoSize = true;
            this.namerb.Location = new System.Drawing.Point(125, 12);
            this.namerb.Name = "namerb";
            this.namerb.Size = new System.Drawing.Size(52, 17);
            this.namerb.TabIndex = 7;
            this.namerb.Text = "Name";
            this.namerb.UseVisualStyleBackColor = true;
            // 
            // projectempcb
            // 
            this.projectempcb.FormattingEnabled = true;
            this.projectempcb.Location = new System.Drawing.Point(19, 40);
            this.projectempcb.Name = "projectempcb";
            this.projectempcb.Size = new System.Drawing.Size(386, 21);
            this.projectempcb.TabIndex = 13;
            // 
            // EmploymentManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 553);
            this.Controls.Add(this.projectempcb);
            this.Controls.Add(this.empstatrb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Addempbtn);
            this.Controls.Add(this.projectrb);
            this.Controls.Add(this.namerb);
            this.Controls.Add(this.EmployerGrid);
            this.Name = "EmploymentManagementUI";
            this.Text = "EmploymentManagementUI";
            this.Load += new System.EventHandler(this.EmploymentManagementUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployerGrid;
        private System.Windows.Forms.ComboBox empstatrb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Addempbtn;
        private System.Windows.Forms.RadioButton projectrb;
        private System.Windows.Forms.RadioButton namerb;
        private System.Windows.Forms.ComboBox projectempcb;
    }
}