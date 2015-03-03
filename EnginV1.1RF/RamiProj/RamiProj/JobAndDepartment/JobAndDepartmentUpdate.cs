using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj
{
    public partial class JobAndDepartmentUpdate : Form
    {
        public int EmpID;
        public string connectionString;
        public JobAndDepartmentUpdate()
        {
            InitializeComponent();
        }

        private void buttonSelectID_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from EmpJob where empid = @p1", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }
                EmpID = Convert.ToInt32(textBoxEmpID.Text);
                JobAndDepartment.JobAndDepartmentUpdateForm form = new JobAndDepartment.JobAndDepartmentUpdateForm();
                form.connectionString = connectionString;
                form.EmpID = EmpID;
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            GC.Collect();


        }

        private void JobAndDepartmentUpdate_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpJob", con);
            BindingSource source = new BindingSource();
            con.Open();
            source.DataSource = cmd.ExecuteReader();
            
            dataGridView1.DataSource = source;
            con.Close();
            
            
        }
    }
}
