namespace RamiProj.WorkingHours
{
    partial class WorkingHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingHours));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxIsHoliday = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkingHours = new System.Windows.Forms.ComboBox();
            this.comboBoxIsVacation = new System.Windows.Forms.ComboBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(198, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of working hours per day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is holiday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is vacation";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(86, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(122, 20);
            this.textBoxEmpID.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(285, 88);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // comboBoxIsHoliday
            // 
            this.comboBoxIsHoliday.FormattingEnabled = true;
            this.comboBoxIsHoliday.Location = new System.Drawing.Point(334, 10);
            this.comboBoxIsHoliday.Name = "comboBoxIsHoliday";
            this.comboBoxIsHoliday.Size = new System.Drawing.Size(91, 21);
            this.comboBoxIsHoliday.TabIndex = 7;
            // 
            // comboBoxWorkingHours
            // 
            this.comboBoxWorkingHours.FormattingEnabled = true;
            this.comboBoxWorkingHours.Location = new System.Drawing.Point(189, 47);
            this.comboBoxWorkingHours.Name = "comboBoxWorkingHours";
            this.comboBoxWorkingHours.Size = new System.Drawing.Size(79, 21);
            this.comboBoxWorkingHours.TabIndex = 8;
            this.comboBoxWorkingHours.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkingHours_SelectedIndexChanged);
            // 
            // comboBoxIsVacation
            // 
            this.comboBoxIsVacation.FormattingEnabled = true;
            this.comboBoxIsVacation.Location = new System.Drawing.Point(85, 85);
            this.comboBoxIsVacation.Name = "comboBoxIsVacation";
            this.comboBoxIsVacation.Size = new System.Drawing.Size(98, 21);
            this.comboBoxIsVacation.TabIndex = 9;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(238, 271);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(334, 271);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(437, 271);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(13, 271);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "Find info";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // WorkingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 306);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.comboBoxIsVacation);
            this.Controls.Add(this.comboBoxWorkingHours);
            this.Controls.Add(this.comboBoxIsHoliday);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkingHours";
            this.Text = "WorkingHours";
            this.Load += new System.EventHandler(this.WorkingHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBoxIsHoliday;
        private System.Windows.Forms.ComboBox comboBoxWorkingHours;
        private System.Windows.Forms.ComboBox comboBoxIsVacation;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
    }
}