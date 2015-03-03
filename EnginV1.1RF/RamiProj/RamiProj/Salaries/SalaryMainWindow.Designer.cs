namespace RamiProj.Salaries
{
    partial class SalaryMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryMainWindow));
            this.buttonFixedSalary = new System.Windows.Forms.Button();
            this.buttonPaymentInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFixedSalary
            // 
            this.buttonFixedSalary.Location = new System.Drawing.Point(37, 23);
            this.buttonFixedSalary.Name = "buttonFixedSalary";
            this.buttonFixedSalary.Size = new System.Drawing.Size(75, 23);
            this.buttonFixedSalary.TabIndex = 0;
            this.buttonFixedSalary.Text = "Fixed salary";
            this.buttonFixedSalary.UseVisualStyleBackColor = true;
            this.buttonFixedSalary.Click += new System.EventHandler(this.buttonFixedSalary_Click);
            // 
            // buttonPaymentInfo
            // 
            this.buttonPaymentInfo.Location = new System.Drawing.Point(139, 23);
            this.buttonPaymentInfo.Name = "buttonPaymentInfo";
            this.buttonPaymentInfo.Size = new System.Drawing.Size(150, 23);
            this.buttonPaymentInfo.TabIndex = 1;
            this.buttonPaymentInfo.Text = "Payments info";
            this.buttonPaymentInfo.UseVisualStyleBackColor = true;
            this.buttonPaymentInfo.Click += new System.EventHandler(this.buttonPaymentInfo_Click);
            // 
            // SalaryMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 256);
            this.Controls.Add(this.buttonPaymentInfo);
            this.Controls.Add(this.buttonFixedSalary);
            this.Name = "SalaryMainWindow";
            this.Text = "SalaryMainWindow";
            this.Load += new System.EventHandler(this.SalaryMainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFixedSalary;
        private System.Windows.Forms.Button buttonPaymentInfo;
    }
}