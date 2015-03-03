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
    public partial class IncrementSalary : Form
    {
        public string connectionString;
        public IncrementSalary()
        {
            InitializeComponent();
        }

        private void IncrementSalary_Load(object sender, EventArgs e)
        {
            GC.Collect();
            this.Text = "Change salary";
            BasselRamiProj.ListOfCurencies listCurrency = new BasselRamiProj.ListOfCurencies();
            comboBoxUnit.DataSource = listCurrency.list;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select a.EmployeeID , a.FirstName , a.MiddleName , a.LastName , b.DateOfDecision , b.SalaryAmount , b.Unit from EmpID a join FixedSalary b on b.EmpID = a.EmployeeID", con);
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

        private void buttonUpdateSalary_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("please enter employee ID");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into FixedSalary(SalaryAmount,EmpID,EmpID1,Unit) values(@p1,@p2,@p3,@p4)",con);
            cmd.Parameters.AddWithValue("@p1", textBoxNewSalaryAmount.Text);
            cmd.Parameters.AddWithValue("@p4", comboBoxUnit.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxEmpID.Text);
            
            try
            {
                con.Open();
                int NoOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfRows.ToString() + "Row(s) updated");
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            GC.Collect();
        }
    }
}
