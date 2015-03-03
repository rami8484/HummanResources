using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.EmployeeRating
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
            SqlCommand cmdEMpID = new SqlCommand("select distinct EMpID from EmpRating", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdEMpID.ExecuteReader();
                IList<string> list = new List<string>();
                while(dr.Read())
                {
                    list.Add(dr["EmpID"].ToString());
                }
                comboBoxEmpID.DataSource = list;
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();

            }
            SqlCommand cmdDate = new SqlCommand("select distinct Date from EmpRating", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdDate.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["Date"].ToString());
                }
                comboBoxDate.DataSource = list;
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

        private void comboBoxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpRating where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxEmpID.Text);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
                dataGridView1.DataSource = source;
                
                
                
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

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpRating where Date = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxDate.Text);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
                dataGridView1.DataSource = source;



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

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter employee ID and the date to display a report for");
                return;

            }
            if (textBoxDate.Text == "")
            {
                MessageBox.Show("Please enter employee ID and the date to display a report for");
                return;
            }


            int n;
            DateTime date;
            if (Int32.TryParse(textBoxEmpID.Text, out  n) && DateTime.TryParse(textBoxDate.Text,out date))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from EmpRating where empid = @p1 and date = @p2 ", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxDate.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id or the date dont exist in the database");
                    return;
                }

            }

            else if (!Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                MessageBox.Show("Employee ID must be an integer value");
                return;
            }
            else if (!DateTime.TryParse(textBoxDate.Text, out date))
            {
                MessageBox.Show("date must be in the format (mm\\dd\\yyyy)");
                return;
            }

            GC.Collect();

            RamiProj.EmployeeRating.Report form = new RamiProj.EmployeeRating.Report();
            form.EmpID = textBoxEmpID.Text;
            form.connectionString = connectionString;
            form.Date = textBoxDate.Text;
            form.ShowDialog();


        }
    }
}
