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
    public partial class FixedSalary : Form
    {
        public string connectionString;
        public FixedSalary()
        {
            InitializeComponent();
        }

        private void buttonIncrementSalary_Click(object sender, EventArgs e)
        {
            //IncrementSalary form = new IncrementSalary();
            //form.connectionString = connectionString;
            //form.ShowDialog();

        }

        private void FixedSalary_Load(object sender, EventArgs e)
        {
            GC.Collect();
            BasselRamiProj.ListOfCurencies listCurrency = new BasselRamiProj.ListOfCurencies();
            comboBoxUnit.DataSource = listCurrency.list;
        }

        private void buttonInsertSalary_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("please enter employee ID");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into FixedSalary(EmpID , SalaryAmount , Unit,EmpID1) values(@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("p1", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("p2", textBoxFixedSalaryAmount.Text);
            cmd.Parameters.AddWithValue("p3", comboBoxUnit.Text);
            cmd.Parameters.AddWithValue("p4", textBoxEmpID.Text);

            try
            {
                con.Open();
                int NoOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfRows.ToString() + "Rows changed");
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);

            }
            finally
            {
                con.Close();
            }
            GC.Collect();

        }

        private void buttonDeleteSalary_Click(object sender, EventArgs e)
        {
            GC.Collect();
            DeleteForm form = new DeleteForm();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindSalary form = new FindSalary();
            form.connectionString = connectionString;
            form.ShowDialog();
        }
    }
}
