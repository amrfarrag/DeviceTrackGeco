namespace DeviceTrackerUI
{
    partial class ProjectMangmentUI
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
            this.ProjectsGrid = new System.Windows.Forms.DataGridView();
            this.ByNamerb = new System.Windows.Forms.RadioButton();
            this.ByAddressrb = new System.Windows.Forms.RadioButton();
            this.Addbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectsGrid
            // 
            this.ProjectsGrid.AllowUserToAddRows = false;
            this.ProjectsGrid.AllowUserToDeleteRows = false;
            this.ProjectsGrid.AllowUserToResizeColumns = false;
            this.ProjectsGrid.AllowUserToResizeRows = false;
            this.ProjectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGrid.Location = new System.Drawing.Point(6, 78);
            this.ProjectsGrid.MultiSelect = false;
            this.ProjectsGrid.Name = "ProjectsGrid";
            this.ProjectsGrid.RowHeadersVisible = false;
            this.ProjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectsGrid.Size = new System.Drawing.Size(794, 463);
            this.ProjectsGrid.TabIndex = 0;
            this.ProjectsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProjectsGrid_CellMouseClick);
            // 
            // ByNamerb
            // 
            this.ByNamerb.AutoSize = true;
            this.ByNamerb.Location = new System.Drawing.Point(13, 11);
            this.ByNamerb.Name = "ByNamerb";
            this.ByNamerb.Size = new System.Drawing.Size(52, 17);
            this.ByNamerb.TabIndex = 1;
            this.ByNamerb.TabStop = true;
            this.ByNamerb.Text = "Name";
            this.ByNamerb.UseVisualStyleBackColor = true;
            // 
            // ByAddressrb
            // 
            this.ByAddressrb.AutoSize = true;
            this.ByAddressrb.Location = new System.Drawing.Point(159, 10);
            this.ByAddressrb.Name = "ByAddressrb";
            this.ByAddressrb.Size = new System.Drawing.Size(64, 17);
            this.ByAddressrb.TabIndex = 2;
            this.ByAddressrb.TabStop = true;
            this.ByAddressrb.Text = "Address";
            this.ByAddressrb.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(644, 34);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(379, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // ProjectMangmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 553);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ByAddressrb);
            this.Controls.Add(this.ByNamerb);
            this.Controls.Add(this.ProjectsGrid);
            this.Name = "ProjectMangmentUI";
            this.Text = "ProjectMangmentUI";
            this.Load += new System.EventHandler(this.ProjectMangmentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectsGrid;
        private System.Windows.Forms.RadioButton ByNamerb;
        private System.Windows.Forms.RadioButton ByAddressrb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}