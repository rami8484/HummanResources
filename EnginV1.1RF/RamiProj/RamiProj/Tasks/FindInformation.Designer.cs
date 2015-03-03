namespace RamiProj.Tasks
{
    partial class FindInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxEmpID = new System.Windows.Forms.ComboBox();
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
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find by task name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Find by start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Find by end date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 184);
            this.dataGridView1.TabIndex = 4;
            // 
            // comboBoxEmpID
            // 
            this.comboBoxEmpID.FormattingEnabled = true;
            this.comboBoxEmpID.Location = new System.Drawing.Point(67, 10);
            this.comboBoxEmpID.Name = "comboBoxEmpID";
            this.comboBoxEmpID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmpID.TabIndex = 5;
            this.comboBoxEmpID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpID_SelectedIndexChanged);
            // 
            // comboBoxTaskName
            // 
            this.comboBoxTaskName.FormattingEnabled = true;
            this.comboBoxTaskName.Location = new System.Drawing.Point(294, 10);
            this.comboBoxTaskName.Name = "comboBoxTaskName";
            this.comboBoxTaskName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTaskName.TabIndex = 6;
            this.comboBoxTaskName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskName_SelectedIndexChanged);
            // 
            // comboBoxStartDate
            // 
            this.comboBoxStartDate.FormattingEnabled = true;
            this.comboBoxStartDate.Location = new System.Drawing.Point(530, 10);
            this.comboBoxStartDate.Name = "comboBoxStartDate";
            this.comboBoxStartDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStartDate.TabIndex = 7;
            this.comboBoxStartDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartDate_SelectedIndexChanged);
            // 
            // comboBoxEndDate
            // 
            this.comboBoxEndDate.FormattingEnabled = true;
            this.comboBoxEndDate.Location = new System.Drawing.Point(110, 55);
            this.comboBoxEndDate.Name = "comboBoxEndDate";
            this.comboBoxEndDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEndDate.TabIndex = 8;
            this.comboBoxEndDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndDate_SelectedIndexChanged);
            // 
            // FindInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 303);
            this.Controls.Add(this.comboBoxEndDate);
            this.Controls.Add(this.comboBoxStartDate);
            this.Controls.Add(this.comboBoxTaskName);
            this.Controls.Add(this.comboBoxEmpID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindInformation";
            this.Text = "FindInformation";
            this.Load += new System.EventHandler(this.FindInformation_Load);
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
        private System.Windows.Forms.ComboBox comboBoxEmpID;
        private System.Windows.Forms.ComboBox comboBoxTaskName;
        private System.Windows.Forms.ComboBox comboBoxStartDate;
        private System.Windows.Forms.ComboBox comboBoxEndDate;
    }
}