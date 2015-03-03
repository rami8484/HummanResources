namespace RamiProj.Salaries
{
    partial class FixedSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxFixedSalaryAmount = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.buttonInsertSalary = new System.Windows.Forms.Button();
            this.buttonDeleteSalary = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(192, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fixed salary amount";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(86, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 3;
            // 
            // textBoxFixedSalaryAmount
            // 
            this.textBoxFixedSalaryAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFixedSalaryAmount.Location = new System.Drawing.Point(302, 10);
            this.textBoxFixedSalaryAmount.Name = "textBoxFixedSalaryAmount";
            this.textBoxFixedSalaryAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxFixedSalaryAmount.TabIndex = 4;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(408, 10);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(70, 21);
            this.comboBoxUnit.TabIndex = 5;
            // 
            // buttonInsertSalary
            // 
            this.buttonInsertSalary.Location = new System.Drawing.Point(130, 90);
            this.buttonInsertSalary.Name = "buttonInsertSalary";
            this.buttonInsertSalary.Size = new System.Drawing.Size(113, 23);
            this.buttonInsertSalary.TabIndex = 6;
            this.buttonInsertSalary.Text = "Insert Salary";
            this.buttonInsertSalary.UseVisualStyleBackColor = true;
            this.buttonInsertSalary.Click += new System.EventHandler(this.buttonInsertSalary_Click);
            // 
            // buttonDeleteSalary
            // 
            this.buttonDeleteSalary.Location = new System.Drawing.Point(356, 90);
            this.buttonDeleteSalary.Name = "buttonDeleteSalary";
            this.buttonDeleteSalary.Size = new System.Drawing.Size(96, 23);
            this.buttonDeleteSalary.TabIndex = 7;
            this.buttonDeleteSalary.Text = "Delete salary";
            this.buttonDeleteSalary.UseVisualStyleBackColor = true;
            this.buttonDeleteSalary.Click += new System.EventHandler(this.buttonDeleteSalary_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(5, 90);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FixedSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 140);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDeleteSalary);
            this.Controls.Add(this.buttonInsertSalary);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.textBoxFixedSalaryAmount);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FixedSalary";
            this.Text = "FixedSalary";
            this.Load += new System.EventHandler(this.FixedSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxFixedSalaryAmount;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Button buttonInsertSalary;
        private System.Windows.Forms.Button buttonDeleteSalary;
        private System.Windows.Forms.Button buttonFind;
    }
}