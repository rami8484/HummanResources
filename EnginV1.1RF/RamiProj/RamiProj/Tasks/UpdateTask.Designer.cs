namespace RamiProj.Tasks
{
    partial class UpdateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTask));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskName = new System.Windows.Forms.ComboBox();
            this.comboBoxStartDate = new System.Windows.Forms.ComboBox();
            this.comboBoxEndDate = new System.Windows.Forms.ComboBox();
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
            this.label2.Location = new System.Drawing.Point(213, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select data to update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(86, 10);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployeeID.TabIndex = 6;
            // 
            // comboBoxTaskName
            // 
            this.comboBoxTaskName.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxTaskName.FormattingEnabled = true;
            this.comboBoxTaskName.Location = new System.Drawing.Point(277, 10);
            this.comboBoxTaskName.Name = "comboBoxTaskName";
            this.comboBoxTaskName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTaskName.TabIndex = 7;
            // 
            // comboBoxStartDate
            // 
            this.comboBoxStartDate.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxStartDate.FormattingEnabled = true;
            this.comboBoxStartDate.Location = new System.Drawing.Point(462, 10);
            this.comboBoxStartDate.Name = "comboBoxStartDate";
            this.comboBoxStartDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStartDate.TabIndex = 8;
            // 
            // comboBoxEndDate
            // 
            this.comboBoxEndDate.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEndDate.FormattingEnabled = true;
            this.comboBoxEndDate.Location = new System.Drawing.Point(86, 45);
            this.comboBoxEndDate.Name = "comboBoxEndDate";
            this.comboBoxEndDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEndDate.TabIndex = 9;
            // 
            // UpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 291);
            this.Controls.Add(this.comboBoxEndDate);
            this.Controls.Add(this.comboBoxStartDate);
            this.Controls.Add(this.comboBoxTaskName);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTask";
            this.Text = "UpdateTask";
            this.Load += new System.EventHandler(this.UpdateTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.ComboBox comboBoxTaskName;
        private System.Windows.Forms.ComboBox comboBoxStartDate;
        private System.Windows.Forms.ComboBox comboBoxEndDate;
    }
}