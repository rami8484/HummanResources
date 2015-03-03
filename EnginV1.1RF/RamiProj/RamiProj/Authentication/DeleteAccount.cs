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
    public partial class DeleteAccount : Form
    {
        public string connectionString;
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmdLogin = new SqlCommand("select name from sys.server_principals where type = 'S'", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdLogin.ExecuteReader();
                IList<string> list = new List<string>();
                while(dr.Read())
                {
                    list.Add(dr["name"].ToString());
                }
                comboBoxLogin.DataSource = list;
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmdUserName = new SqlCommand("select name from sys.database_principals where type = 'S'", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdUserName.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["name"].ToString());
                }
                comboBoxUserName.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("drop user " + comboBoxUserName.Text + " ; drop login " + comboBoxLogin.Text + ";", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxUserName.Text);
            cmd.Parameters.AddWithValue("@p2", comboBoxLogin.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account deleted");
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
