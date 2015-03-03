namespace RamiProj.EmployeeIdentity
{
    partial class UpdateEmployeeID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeID));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.buttonSelectID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(369, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter an id to update";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(6, 66);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 2;
            // 
            // buttonSelectID
            // 
            this.buttonSelectID.Location = new System.Drawing.Point(71, 225);
            this.buttonSelectID.Name = "buttonSelectID";
            this.buttonSelectID.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectID.TabIndex = 3;
            this.buttonSelectID.Text = "Select ID";
            this.buttonSelectID.UseVisualStyleBackColor = true;
            this.buttonSelectID.Click += new System.EventHandler(this.buttonSelectID_Click);
            // 
            // UpdateEmployeeID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.buttonSelectID);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateEmployeeID";
            this.Text = "UpdateEmployeeID";
            this.Load += new System.EventHandler(this.UpdateEmployeeID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Button buttonSelectID;
    }
}