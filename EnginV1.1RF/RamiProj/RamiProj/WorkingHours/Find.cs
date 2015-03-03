using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.WorkingHours
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
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from WorkingHours", con);
            BindingSource source = new BindingSource();
            con.Open();
            source.DataSource = cmd.ExecuteReader();
            dataGridView1.DataSource = source;
            con.Close();
            SqlCommand cmdEmpID = new SqlCommand("select distinct EmpID from WorkingHours", con);
            con.Open();
            IList<string> list = new List<string>();
            SqlDataReader dr = cmdEmpID.ExecuteReader();
            while(dr.Read())
            {
                list.Add(dr["EmpID"].ToString());
            }
            comboBox1.DataSource = list;
            
            con.Close();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from WorkingHours where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
            BindingSource source = new BindingSource();
            con.Open();
            source.DataSource = cmd.ExecuteReader();
            dataGridView1.DataSource = source;
            con.Close();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter employee ID to display report for");
                return;
            }


            int n;

            if (Int32.TryParse(textBox1.Text, out  n))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from WorkingHours where empid = @p1 ", con);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }

            }

            else if (!Int32.TryParse(textBox1.Text, out  n))
            {
                MessageBox.Show("Employee ID must be an integer value");
                return;
            }

            GC.Collect();

            Report form = new Report();
            form.connectionString = connectionString;
            form.EmpID = Convert.ToInt32(textBox1.Text);
            form.ShowDialog();
        }
    }
}
