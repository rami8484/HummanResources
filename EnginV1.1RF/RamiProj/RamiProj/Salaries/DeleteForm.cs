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
    public partial class DeleteForm : Form
    {
        public string connectionString;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void buttonDeleteSalary_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("please enter the employee ID to delete salary for");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("please enter the dte of decision to delete salary for");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete from FixedSalary where EmpID = @p1 and DateOfDecision = @p2", con);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);


            try
            {
                con.Open();
                int NoOfROws = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfROws.ToString() + "Row(s) deleted");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
        
    }
}
