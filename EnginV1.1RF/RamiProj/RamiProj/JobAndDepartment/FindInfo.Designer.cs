﻿namespace RamiProj.JobAndDepartment
{
    partial class FindInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // comboBoxEmpID
            // 
            this.comboBoxEmpID.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEmpID.FormattingEnabled = true;
            this.comboBoxEmpID.Location = new System.Drawing.Point(84, 10);
            this.comboBoxEmpID.Name = "comboBoxEmpID";
            this.comboBoxEmpID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmpID.TabIndex = 1;
            this.comboBoxEmpID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpID_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(608, 309);
            this.dataGridView1.TabIndex = 2;
            // 
            // FindInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxEmpID);
            this.Controls.Add(this.label1);
            this.Name = "FindInfo";
            this.Text = "FindInfo";
            this.Load += new System.EventHandler(this.FindInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}