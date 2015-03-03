using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.SkillsAndEducation
{
    public partial class SelectToUpdate : Form
    {
        public string connectionString;
        public SelectToUpdate()
        {
            InitializeComponent();
        }

        private void SelectToUpdate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select b.EmpID , a.FirstName , a.MiddleName , a.LastName from EmpID a join EducationAndSkills b on a.EmployeeID = b.EmpID", con);
            try
            {
                con.Open();
                BindingSource source = new BindingSource();
                source.DataSource = cmd.ExecuteReader();
                dataGridView1.DataSource = source;
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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            GC.Collect();
            if(textBoxEmployeeID.Text == "")
            {
                MessageBox.Show("Please enter Employee id");
                return;
            }


            int n;

            if (Int32.TryParse(textBoxEmployeeID.Text, out  n))
            {
                if (textBoxEmployeeID.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from PaymentInfo where empid = @p1 ", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmployeeID.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }

            }

            else if (!Int32.TryParse(textBoxEmployeeID.Text, out  n))
            {
                MessageBox.Show("Employee ID must be an integer value");
                return;
            }

            GC.Collect();

            Update form = new Update();
            form.connectionString = connectionString;
            form.EmpID = Convert.ToInt32(textBoxEmployeeID.Text);
            form.ShowDialog();

        }
    }
}
