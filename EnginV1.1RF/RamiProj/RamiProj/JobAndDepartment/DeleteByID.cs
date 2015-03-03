using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.JobAndDepartment
{
    public partial class DeleteByID : Form
    {
        public string connectionString;
        public DeleteByID()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32 n;
            if (Int32.TryParse(textBox1.Text, out  n))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter Employee ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("delete from EmpJob where EmpID = @p1", con);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
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
            else if(!Int32.TryParse(textBox1.Text, out  n))
                
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            GC.Collect();
        }

        private void DeleteByID_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
