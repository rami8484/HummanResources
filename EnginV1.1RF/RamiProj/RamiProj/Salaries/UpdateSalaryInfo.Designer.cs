namespace RamiProj.Salaries
{
    partial class UpdateSalaryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSalaryInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxDateOfPayment = new System.Windows.Forms.TextBox();
            this.textBoxRewardAmount = new System.Windows.Forms.TextBox();
            this.textBoxPunishmentAmount = new System.Windows.Forms.TextBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.buttonSelectDate = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(205, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reward amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punishment amount";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(407, 167);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(99, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 5;
            // 
            // textBoxDateOfPayment
            // 
            this.textBoxDateOfPayment.Location = new System.Drawing.Point(313, 10);
            this.textBoxDateOfPayment.Name = "textBoxDateOfPayment";
            this.textBoxDateOfPayment.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateOfPayment.TabIndex = 6;
            // 
            // textBoxRewardAmount
            // 
            this.textBoxRewardAmount.Location = new System.Drawing.Point(105, 71);
            this.textBoxRewardAmount.Name = "textBoxRewardAmount";
            this.textBoxRewardAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxRewardAmount.TabIndex = 7;
            // 
            // textBoxPunishmentAmount
            // 
            this.textBoxPunishmentAmount.Location = new System.Drawing.Point(346, 71);
            this.textBoxPunishmentAmount.Name = "textBoxPunishmentAmount";
            this.textBoxPunishmentAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPunishmentAmount.TabIndex = 8;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(168, 35);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 29;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectDate.BackgroundImage")));
            this.buttonSelectDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectDate.Location = new System.Drawing.Point(452, 69);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(28, 23);
            this.buttonSelectDate.TabIndex = 28;
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // UpdateSalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 202);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.buttonSelectDate);
            this.Controls.Add(this.textBoxPunishmentAmount);
            this.Controls.Add(this.textBoxRewardAmount);
            this.Controls.Add(this.textBoxDateOfPayment);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSalaryInfo";
            this.Text = "UpdateSalaryInfo";
            this.Load += new System.EventHandler(this.UpdateSalaryInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxDateOfPayment;
        private System.Windows.Forms.TextBox textBoxRewardAmount;
        private System.Windows.Forms.TextBox textBoxPunishmentAmount;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button buttonSelectDate;
    }
}