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
    public partial class Notes : Form
    {
        public string connectionString;
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FInd form = new FInd();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter Employee ID to insert note to");
                    return;
                }
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Please enter a note");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("insert into Notes(EmpID , Note) values(@p1,@p2)", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                cmd.Parameters.AddWithValue("@p2", richTextBox1.Text);
                try
                {
                    con.Open();

                    int NoOfROws = cmd.ExecuteNonQuery();
                    MessageBox.Show(NoOfROws.ToString() + "Row(s) inserted");
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
            GC.Collect();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            ChooseIDToUpdate form = new ChooseIDToUpdate();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            GC.Collect();
            DeleteByID form = new DeleteByID();
            form.connectionString = connectionString;
            form.ShowDialog();
        }
    }
}
