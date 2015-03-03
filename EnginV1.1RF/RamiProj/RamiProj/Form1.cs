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
    public partial class Form1 : Form
    {
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "data source = WISSACZH\\RAMI;database = Employees;integrated security = true";
            this.Text = "Log in";
            try
            {
                FileStream file = new FileStream("CS.txt", FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                //MessageBox.Show(connectionString);
                writer.Write(connectionString);
                writer.Close();
                file.Close();

            }
            catch (IOException f)
            {
                MessageBox.Show(f.Message);
                FileStream file = new FileStream("CS.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                connectionString = reader.ReadToEnd();
                file.Close();
                
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select UserName , Password from Credencials where UserName = @para", con);
            cmd.Parameters.AddWithValue("@para", textBoxUserName.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
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
                        // start the software
                        MainWIndow form = new MainWIndow();
                        form.connectionString = connectionString;
                        form.ShowDialog();
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
            catch(SystemException f)
            {
                if(f.Message == "There is no row at position 0.")
                {
                    MessageBox.Show("User name or password doesnt exist in the database");
                }
                else
                MessageBox.Show(f.Message);
            }

            this.Close();

            

           
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            PasswordManager form = new PasswordManager();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
