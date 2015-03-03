using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.EmployeeIdentity
{
    public partial class UpdateEmployeeID : Form
    {
        public string connectionString;
        public int EmpID;
        public UpdateEmployeeID()
        {
            InitializeComponent();
        }

        private void buttonSelectID_Click(object sender, EventArgs e)
        {
            Int32 n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                GC.Collect();
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter an ID to update");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from EmpID where employeeID = @p1", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }
                EmpID = Convert.ToInt32(textBoxEmpID.Text);
                UpdateIDFields form = new UpdateIDFields();
                form.connectionString = connectionString;
                form.EmpID = EmpID;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Employee ID must be an intiger value");
            }
            
        }

        private void UpdateEmployeeID_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select EmployeeID , FIrstName , MiddleName , LastName from EmpID order by FirstName asc", con);
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
    }
}
