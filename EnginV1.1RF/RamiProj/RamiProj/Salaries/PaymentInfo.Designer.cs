namespace RamiProj.Salaries
{
    partial class PaymentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxRewardAmount = new System.Windows.Forms.TextBox();
            this.textBoxPunishmentAmount = new System.Windows.Forms.TextBox();
            this.textBoxDateOfPayment = new System.Windows.Forms.TextBox();
            this.buttonDisplayInfo = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(192, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reward amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punishment amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of payment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete payment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmpID.Location = new System.Drawing.Point(86, 10);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 7;
            // 
            // textBoxRewardAmount
            // 
            this.textBoxRewardAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxRewardAmount.Location = new System.Drawing.Point(281, 10);
            this.textBoxRewardAmount.Name = "textBoxRewardAmount";
            this.textBoxRewardAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxRewardAmount.TabIndex = 8;
            // 
            // textBoxPunishmentAmount
            // 
            this.textBoxPunishmentAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPunishmentAmount.Location = new System.Drawing.Point(123, 49);
            this.textBoxPunishmentAmount.Name = "textBoxPunishmentAmount";
            this.textBoxPunishmentAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPunishmentAmount.TabIndex = 9;
            // 
            // textBoxDateOfPayment
            // 
            this.textBoxDateOfPayment.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDateOfPayment.Location = new System.Drawing.Point(327, 49);
            this.textBoxDateOfPayment.Name = "textBoxDateOfPayment";
            this.textBoxDateOfPayment.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateOfPayment.TabIndex = 10;
            // 
            // buttonDisplayInfo
            // 
            this.buttonDisplayInfo.Location = new System.Drawing.Point(12, 153);
            this.buttonDisplayInfo.Name = "buttonDisplayInfo";
            this.buttonDisplayInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplayInfo.TabIndex = 11;
            this.buttonDisplayInfo.Text = "Display info";
            this.buttonDisplayInfo.UseVisualStyleBackColor = true;
            this.buttonDisplayInfo.Click += new System.EventHandler(this.buttonDisplayInfo_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(129, 35);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 27;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectDate.BackgroundImage")));
            this.buttonSelectDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectDate.Location = new System.Drawing.Point(433, 47);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(28, 23);
            this.buttonSelectDate.TabIndex = 26;
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 200);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.buttonSelectDate);
            this.Controls.Add(this.buttonDisplayInfo);
            this.Controls.Add(this.textBoxDateOfPayment);
            this.Controls.Add(this.textBoxPunishmentAmount);
            this.Controls.Add(this.textBoxRewardAmount);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentInfo";
            this.Text = "PaymentInfo";
            this.Load += new System.EventHandler(this.PaymentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxRewardAmount;
        private System.Windows.Forms.TextBox textBoxPunishmentAmount;
        private System.Windows.Forms.TextBox textBoxDateOfPayment;
        private System.Windows.Forms.Button buttonDisplayInfo;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button buttonSelectDate;
    }
}