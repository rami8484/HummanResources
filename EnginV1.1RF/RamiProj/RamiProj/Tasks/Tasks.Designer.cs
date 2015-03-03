namespace RamiProj.Tasks
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxDelierDate = new System.Windows.Forms.TextBox();
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFindInformation = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonSelectDate = new System.Windows.Forms.Button();
            this.buttonSelectDate2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task name";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTaskName.Location = new System.Drawing.Point(80, 44);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(363, 20);
            this.textBoxTaskName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deliver date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Details";
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxStartDate.Location = new System.Drawing.Point(78, 92);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartDate.TabIndex = 5;
            // 
            // textBoxDelierDate
            // 
            this.textBoxDelierDate.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDelierDate.Location = new System.Drawing.Point(90, 134);
            this.textBoxDelierDate.Name = "textBoxDelierDate";
            this.textBoxDelierDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelierDate.TabIndex = 6;
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxDetails.Location = new System.Drawing.Point(90, 193);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.Size = new System.Drawing.Size(341, 96);
            this.richTextBoxDetails.TabIndex = 7;
            this.richTextBoxDetails.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee ID";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(92, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 9;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(141, 295);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(222, 295);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(303, 295);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFindInformation
            // 
            this.buttonFindInformation.Location = new System.Drawing.Point(12, 295);
            this.buttonFindInformation.Name = "buttonFindInformation";
            this.buttonFindInformation.Size = new System.Drawing.Size(95, 23);
            this.buttonFindInformation.TabIndex = 13;
            this.buttonFindInformation.Text = "Find information";
            this.buttonFindInformation.UseVisualStyleBackColor = true;
            this.buttonFindInformation.Click += new System.EventHandler(this.buttonFindInformation_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(301, 134);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Priority";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(270, 92);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPriority.TabIndex = 17;
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectDate.BackgroundImage")));
            this.buttonSelectDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectDate.Location = new System.Drawing.Point(189, 90);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(28, 23);
            this.buttonSelectDate.TabIndex = 18;
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // buttonSelectDate2
            // 
            this.buttonSelectDate2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectDate2.BackgroundImage")));
            this.buttonSelectDate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectDate2.Location = new System.Drawing.Point(196, 132);
            this.buttonSelectDate2.Name = "buttonSelectDate2";
            this.buttonSelectDate2.Size = new System.Drawing.Size(28, 23);
            this.buttonSelectDate2.TabIndex = 19;
            this.buttonSelectDate2.Text = "button2";
            this.buttonSelectDate2.UseVisualStyleBackColor = true;
            this.buttonSelectDate2.Click += new System.EventHandler(this.buttonSelectDate2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(236, 92);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(270, 95);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 21;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 330);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonSelectDate2);
            this.Controls.Add(this.buttonSelectDate);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonFindInformation);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxDetails);
            this.Controls.Add(this.textBoxDelierDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxDelierDate;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFindInformation;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button buttonSelectDate;
        private System.Windows.Forms.Button buttonSelectDate2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}