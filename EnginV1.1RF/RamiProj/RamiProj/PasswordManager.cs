using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace RamiProj
{
    public partial class PasswordManager : Form
    {
        public string connectionString;
        public PasswordManager()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select ID , UserName , Password from Credencials where UserName = @para", con);
            cmd.Parameters.AddWithValue("@para", textBoxUserName.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            DataRow dr;
            string password;
            string UserName;
            try
            {
                try
                {
                    da.Fill(ds, "Table");
                    dr = ds.Tables["Table"].Rows[0];
                    password = dr["Password"].ToString();
                    UserName = dr["UserName"].ToString();
                    if (UserName == textBoxUserName.Text && password == textBoxPassword.Text)
                    {
                        // Change the password
                        if(textBoxNewPassword.Text == textBoxConfirmPassword.Text)
                        {
                            dr["UserName"] = textBoxUserName.Text;
                            dr["Password"] = textBoxNewPassword.Text;
                            if(da.Update(ds, "Table") > 0)
                            {
                                MessageBox.Show("Password updated");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password does'nt match");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("User name or password is incorrect");
                    }
                }
                catch (SqlException f)
                {
                    MessageBox.Show(f.Message);
                }
            }
            catch (SystemException f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
