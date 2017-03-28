namespace DeviceTrackerUI
{
    partial class DeviceUI
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
            this.devicegrid = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.statecmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.destxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.devicegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // devicegrid
            // 
            this.devicegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicegrid.Location = new System.Drawing.Point(13, 167);
            this.devicegrid.Name = "devicegrid";
            this.devicegrid.Size = new System.Drawing.Size(702, 364);
            this.devicegrid.TabIndex = 0;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(640, 138);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "button1";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // statecmb
            // 
            this.statecmb.FormattingEnabled = true;
            this.statecmb.Location = new System.Drawing.Point(258, 138);
            this.statecmb.Name = "statecmb";
            this.statecmb.Size = new System.Drawing.Size(241, 21);
            this.statecmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // destxt
            // 
            this.destxt.Location = new System.Drawing.Point(258, 52);
            this.destxt.Multiline = true;
            this.destxt.Name = "destxt";
            this.destxt.Size = new System.Drawing.Size(241, 60);
            this.destxt.TabIndex = 4;
            // 
            // DeviceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 543);
            this.Controls.Add(this.destxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statecmb);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.devicegrid);
            this.Name = "DeviceUI";
            this.Text = "DeviceUI";
            this.Load += new System.EventHandler(this.DeviceUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devicegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView devicegrid;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ComboBox statecmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destxt;
    }
}