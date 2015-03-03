namespace RamiProj.Authentication
{
    partial class DeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccount));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(410, 115);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(95, 13);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLogin.TabIndex = 5;
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(307, 13);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserName.TabIndex = 6;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 150);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.DoubleBuffered = true;
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.Load += new System.EventHandler(this.DeleteAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxUserName;
    }
}