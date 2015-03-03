namespace RamiProj.JobAndDepartment
{
    partial class JobAndDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobAndDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBox3Hours = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxResponsibilities = new System.Windows.Forms.RichTextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFindInformation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIsTrainer = new System.Windows.Forms.ComboBox();
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
            this.label2.Location = new System.Drawing.Point(187, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of hours per day";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(86, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(95, 20);
            this.textBoxEmpID.TabIndex = 4;
            // 
            // comboBoxJobTitle
            // 
            this.comboBoxJobTitle.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxJobTitle.FormattingEnabled = true;
            this.comboBoxJobTitle.Location = new System.Drawing.Point(238, 10);
            this.comboBoxJobTitle.Name = "comboBoxJobTitle";
            this.comboBoxJobTitle.Size = new System.Drawing.Size(162, 21);
            this.comboBoxJobTitle.TabIndex = 5;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(476, 10);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(233, 21);
            this.comboBoxDepartment.TabIndex = 6;
            // 
            // comboBox3Hours
            // 
            this.comboBox3Hours.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox3Hours.FormattingEnabled = true;
            this.comboBox3Hours.Location = new System.Drawing.Point(145, 50);
            this.comboBox3Hours.Name = "comboBox3Hours";
            this.comboBox3Hours.Size = new System.Drawing.Size(60, 21);
            this.comboBox3Hours.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Responsibilities";
            // 
            // richTextBoxResponsibilities
            // 
            this.richTextBoxResponsibilities.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxResponsibilities.Location = new System.Drawing.Point(332, 50);
            this.richTextBoxResponsibilities.Name = "richTextBoxResponsibilities";
            this.richTextBoxResponsibilities.Size = new System.Drawing.Size(377, 102);
            this.richTextBoxResponsibilities.TabIndex = 9;
            this.richTextBoxResponsibilities.Text = "";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(332, 205);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert data";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(426, 205);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update data";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(525, 205);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete data";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFindInformation
            // 
            this.buttonFindInformation.Location = new System.Drawing.Point(12, 205);
            this.buttonFindInformation.Name = "buttonFindInformation";
            this.buttonFindInformation.Size = new System.Drawing.Size(117, 23);
            this.buttonFindInformation.TabIndex = 14;
            this.buttonFindInformation.Text = "Find information";
            this.buttonFindInformation.UseVisualStyleBackColor = true;
            this.buttonFindInformation.Click += new System.EventHandler(this.buttonFindInformation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Is trainer";
            // 
            // comboBoxIsTrainer
            // 
            this.comboBoxIsTrainer.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxIsTrainer.FormattingEnabled = true;
            this.comboBoxIsTrainer.Location = new System.Drawing.Point(84, 89);
            this.comboBoxIsTrainer.Name = "comboBoxIsTrainer";
            this.comboBoxIsTrainer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIsTrainer.TabIndex = 16;
            // 
            // JobAndDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 240);
            this.Controls.Add(this.comboBoxIsTrainer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonFindInformation);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.richTextBoxResponsibilities);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3Hours);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxJobTitle);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobAndDepartment";
            this.Text = "JobAndDepartment";
            this.Load += new System.EventHandler(this.JobAndDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBox3Hours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxResponsibilities;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFindInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxIsTrainer;
    }
}