using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Notes
{
    public partial class ChooseIDToUpdate : Form
    {
        public string connectionString;
        
        public ChooseIDToUpdate()
        {
            InitializeComponent();
        }

        private void ChooseIDToUpdate_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(textBox1.Text, out  n))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("please enter employee ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from EmpID where empid = @p1", con);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id does'nt exist in the database");
                    return;
                }
                Update form = new Update();
                form.connectionString = connectionString;
                form.EmpID = Convert.ToInt32(textBox1.Text);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            GC.Collect();
        }
    }
}
