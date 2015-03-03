using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace RamiProj.SkillsAndEducation
{
    public partial class Find : Form
    {
        public string connectionString;
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select EmpID from EducationAndSkills", con);
            try
            {
                con.Open();
                IList<string> list = new List<string>();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr["EmpID"].ToString());

                }
                comboBox1.DataSource = list;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EducationAndSkills where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
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

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter employee ID to display report for");
                return;
            }

            int n;

            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from EducationAndSkills where empid = @p1 ", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }

            }

            else if (!Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                MessageBox.Show("Employee ID must be an integer value");
                return;
            }

            GC.Collect();
            Report form = new Report();
            form.EmpID = Convert.ToInt32(textBoxEmpID.Text);
            form.connectionString = connectionString;
            form.ShowDialog();

        }
    }
}
