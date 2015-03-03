namespace RamiProj.WorkingHours
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.comboBoxIsVacation = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkingHours = new System.Windows.Forms.ComboBox();
            this.comboBoxIsHoliday = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxIsVacation
            // 
            this.comboBoxIsVacation.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxIsVacation.FormattingEnabled = true;
            this.comboBoxIsVacation.Location = new System.Drawing.Point(82, 87);
            this.comboBoxIsVacation.Name = "comboBoxIsVacation";
            this.comboBoxIsVacation.Size = new System.Drawing.Size(98, 21);
            this.comboBoxIsVacation.TabIndex = 19;
            // 
            // comboBoxWorkingHours
            // 
            this.comboBoxWorkingHours.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxWorkingHours.FormattingEnabled = true;
            this.comboBoxWorkingHours.Location = new System.Drawing.Point(186, 49);
            this.comboBoxWorkingHours.Name = "comboBoxWorkingHours";
            this.comboBoxWorkingHours.Size = new System.Drawing.Size(79, 21);
            this.comboBoxWorkingHours.TabIndex = 18;
            // 
            // comboBoxIsHoliday
            // 
            this.comboBoxIsHoliday.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxIsHoliday.FormattingEnabled = true;
            this.comboBoxIsHoliday.Location = new System.Drawing.Point(331, 12);
            this.comboBoxIsHoliday.Name = "comboBoxIsHoliday";
            this.comboBoxIsHoliday.Size = new System.Drawing.Size(91, 21);
            this.comboBoxIsHoliday.TabIndex = 17;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(282, 90);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(83, 12);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(122, 20);
            this.textBoxEmpID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Is vacation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Is holiday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of working hours per day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Work date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employee ID";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(556, 283);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 318);
            this.Controls.Add(this.buttonUpdate);
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
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIsVacation;
        private System.Windows.Forms.ComboBox comboBoxWorkingHours;
        private System.Windows.Forms.ComboBox comboBoxIsHoliday;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}