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
    public partial class DeletePayment : Form
    {
        public string connectionString;
        public DeletePayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("please enter employee ID to delete");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("please enter date of payment to delete");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete from PaymentInfo where EmpID = @p1 and DateOfPayment = @p2", con);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            try
            {
                con.Open();
                int NoOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfRows.ToString() + "Row(s) deleted");
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

        private void DeletePayment_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
