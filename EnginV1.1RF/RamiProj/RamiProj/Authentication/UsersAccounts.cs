using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Authentication
{
    public partial class UsersAccounts : Form
    {
        public string connectionString;
        public UsersAccounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            if(textBoxLogin.Text == "")
            {
                MessageBox.Show("Please enter login");
                return;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            if (textBoxUserName.Text == "")
            {
                MessageBox.Show("Please enter User Name");
                return;
            }
            if (comboBoxDatabaseRole.Text == "")
            {
                MessageBox.Show("Please select the database role");
                return;
            }
            if (comboBoxServerRole.Text == "")
            {
                MessageBox.Show("Please select Server role");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("create login " + textBoxLogin.Text + " with password = '" + textBoxPassword.Text + "';create user " + textBoxUserName.Text + " for login " + textBoxLogin.Text + ";exec sp_addsrvrolemember '" + textBoxLogin.Text + "' , '" + comboBoxServerRole.Text + "' ;exec sp_addrolemember '" + comboBoxDatabaseRole.Text + "' , '" + textBoxUserName.Text +"';", con);
            /*SqlCommand cmd = new SqlCommand("create login @p1 with password = @p2 ;create user @p3 for login @p6; exec  sp_addrolemember @p4 , @p7;exec sp_addsrvrolemember  @p8 ,@p5 ", con);
            cmd.Parameters.AddWithValue("@p1", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@p4", comboBoxDatabaseRole.Text);
            cmd.Parameters.AddWithValue("@p5", comboBoxServerRole.Text);
            cmd.Parameters.AddWithValue("@p6",textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@p7",textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@p8",textBoxLogin.Text);*/


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account created");

            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally{
                con.Close();
            }


        }

        private void UsersAccounts_Load(object sender, EventArgs e)
        {
            GC.Collect();
            DatabaseRolesList list = new DatabaseRolesList();
            comboBoxDatabaseRole.DataSource = list.list;
            ServerRolesList srvrList = new ServerRolesList();
            comboBoxServerRole.DataSource = srvrList.list;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            GC.Collect();
            DeleteAccount form = new DeleteAccount();
            form.connectionString = connectionString;
            form.ShowDialog();
        }
    }
}
