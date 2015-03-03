namespace RamiProj.Salaries
{
    partial class IncrementSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateSalary = new System.Windows.Forms.Button();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxNewSalaryAmount = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New salary amount";
            // 
            // buttonUpdateSalary
            // 
            this.buttonUpdateSalary.Location = new System.Drawing.Point(394, 192);
            this.buttonUpdateSalary.Name = "buttonUpdateSalary";
            this.buttonUpdateSalary.Size = new System.Drawing.Size(105, 23);
            this.buttonUpdateSalary.TabIndex = 2;
            this.buttonUpdateSalary.Text = "Update Salary";
            this.buttonUpdateSalary.UseVisualStyleBackColor = true;
            this.buttonUpdateSalary.Click += new System.EventHandler(this.buttonUpdateSalary_Click);
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(86, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 3;
            // 
            // textBoxNewSalaryAmount
            // 
            this.textBoxNewSalaryAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNewSalaryAmount.Location = new System.Drawing.Point(306, 10);
            this.textBoxNewSalaryAmount.Name = "textBoxNewSalaryAmount";
            this.textBoxNewSalaryAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewSalaryAmount.TabIndex = 4;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(412, 10);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(74, 21);
            this.comboBoxUnit.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(375, 157);
            this.dataGridView1.TabIndex = 6;
            // 
            // IncrementSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 227);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.textBoxNewSalaryAmount);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.buttonUpdateSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncrementSalary";
            this.Text = "IncrementSalary";
            this.Load += new System.EventHandler(this.IncrementSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateSalary;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxNewSalaryAmount;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}