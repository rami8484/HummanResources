using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Salaries
{
    public partial class FindPaymentInfo : Form
    {
        public string connectionString;
        public FindPaymentInfo()
        {
            InitializeComponent();
        }

        private void FindPaymentInfo_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select distinct EmpID from PaymentInfo order by EmpID asc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            IList<string> list = new List<string>();
            while(dr.Read())
            {
                list.Add(dr["EmpID"].ToString());
            }
            comboBoxEmpID.DataSource = list;
        }

        private void comboBoxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from getSalaryInfo2 where EmployeeID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxEmpID.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = dr;
            con.Close();
            dataGridView1.DataSource = source;
        }

        private void buttonPaymentReport_Click(object sender, EventArgs e)
        {
            if(textBoxEmpid.Text == "")
            {
                MessageBox.Show("Please enter employee ID to display report for");
                return;
            }


            int n;
           
            if (Int32.TryParse(textBoxEmpid.Text, out  n) )
            {
                if (textBoxEmpid.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from PaymentInfo where empid = @p1 ", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpid.Text);
                
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }

            }

            else if (!Int32.TryParse(textBoxEmpid.Text, out  n))
            {
                MessageBox.Show("Employee ID must be an integer value");
                return;
            }
            
            GC.Collect();


            PaymentReport form = new PaymentReport();
            form.EmpID = Convert.ToInt32(textBoxEmpid.Text);
            form.connectionString = connectionString;
            form.ShowDialog();

        }
    }
}
