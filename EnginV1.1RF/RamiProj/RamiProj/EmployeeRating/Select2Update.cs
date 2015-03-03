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
    public partial class Select2Update : Form
    {

        public string connectionString;
        public Select2Update()
        {
            InitializeComponent();
        }

        private void Select2Update_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from GetEmpRating",con);
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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            GC.Collect();
            


            int nn;
            DateTime date;
            if (Int32.TryParse(textBoxEmpID.Text, out  nn) && DateTime.TryParse(textBoxDate.Text, out date))
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

            else if (!Int32.TryParse(textBoxEmpID.Text, out  nn))
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





            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter EmployeeIdentity ID");
                return;
            }
            if(textBoxDate.Text == "")
            {
                MessageBox.Show("Please enter the date");
                return;
            }
            Update form = new Update();
            form.EmpID = textBoxEmpID.Text;
            form.Date1 = textBoxDate.Text;
            form.connectionString = connectionString;
            form.ShowDialog();
        }
    }
}
