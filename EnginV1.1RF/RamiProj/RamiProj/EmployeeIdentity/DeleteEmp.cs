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
    public partial class DeleteEmp : Form
    {
        public string connectionString;
        public DeleteEmp()
        {
            InitializeComponent();
        }

        private void DeleteEmp_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select EmployeeID , FirstName , MiddleName , LastName from EmpID", con);
            try
            {
                con.Open();
                BindingSource source = new BindingSource();
                source.DataSource = cmd.ExecuteReader();
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

        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {

            Int32 n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter Employee id to delete");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("delete from EmpID where EmployeeID = @para", con);
                cmd.Parameters.AddWithValue("@para", textBoxEmpID.Text);
                try
                {
                    con.Open();
                    int NoOfRows = cmd.ExecuteNonQuery();
                    MessageBox.Show(NoOfRows.ToString() + "Row(s) deleted");
                }
                catch (SqlException f)
                {
                    if (f.Message.Contains("Conversion failed"))
                    {
                        MessageBox.Show("Employee ID must be an Integer number");
                    }
                    else
                        MessageBox.Show(f.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
        }
    }
}
