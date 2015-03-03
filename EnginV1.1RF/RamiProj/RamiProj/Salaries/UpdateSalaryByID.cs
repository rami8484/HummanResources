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
    public partial class UpdateSalaryByID : Form
    {
        public string connectionString;

        public UpdateSalaryByID()
        {
            InitializeComponent();
        }

        private void UpdateSalaryByID_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.Text = "Update Salary";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from PaymentInfo", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
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

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("please enter employee ID");
                return;
            }
            if (textBoxDateOfPayment.Text == "")
            {
                MessageBox.Show("please enter date of payment");
                return;
            }




            int n;
            DateTime date;
            if (Int32.TryParse(textBoxEmpID.Text, out  n) && DateTime.TryParse(textBoxDateOfPayment.Text,out date))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from PaymentInfo where empid = @p1 and DateOfPayment = @p2 ", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxDateOfPayment.Text);
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
            else if (!DateTime.TryParse(textBoxDateOfPayment.Text, out date))
            {
                MessageBox.Show("dateOfPayment must be a date (mm\\dd\\yyyy)");
                return;
            }
            GC.Collect();





            UpdateSalaryInfo form = new UpdateSalaryInfo();
            form.connectionString = connectionString;
            form.EmpID = Convert.ToInt32(textBoxEmpID.Text);
            form.date = textBoxDateOfPayment.Text;
            form.ShowDialog();
            GC.Collect();
        }
    }
}
