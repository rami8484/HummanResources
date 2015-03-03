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

namespace RamiProj.Salaries
{
    public partial class FindSalary : Form
    {
        public string connectionString;
        public FindSalary()
        {
            InitializeComponent();
        }

        private void FindSalary_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select distinct EmpID  from FIxedSalary order by EmpID asc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            IList<string> EmpIDList = new List<string>();
            while(dr.Read())
            {
                EmpIDList.Add(dr["EmpID"].ToString());
            }
            con.Close();
            comboBox1.DataSource = EmpIDList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select a.EmployeeID, a.FirstName , a.MiddleName , a.LastName , b.* from EmpID a join FixedSalary b on a.EmployeeID = b.EmpID where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = dr;
            dataGridView1.DataSource = source;
            con.Close();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter Employee ID to display report for");
                return;
            }
            int n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("please enter employee ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from FixedSalary where empid = @p1", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            GC.Collect();
            FixedSalaryReport form = new FixedSalaryReport();
            form.EmpID = Convert.ToInt32(textBoxEmpID.Text);
            form.connectionString = connectionString;
            form.ShowDialog();

        }
    }
}
