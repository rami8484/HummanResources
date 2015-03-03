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
    public partial class Update : Form
    {
        public string connectionString;
        public int EmpID;
        SqlDataAdapter da;
        SqlCommandBuilder cmdBuilder;
        DataSet ds;
        DataRow dr;
        public Update()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(textBox1.Text, out  n))
            {
                SqlConnection con = new SqlConnection(connectionString);
                dr["EmpID"] = textBox1.Text;
                dr["Note"] = richTextBox1.Text;
                try
                {
                    int NoOfRows = da.Update(ds, "Notes");
                    MessageBox.Show(NoOfRows.ToString() + "Row(s) updated");
                }
                catch (IndexOutOfRangeException f)
                {
                    if (f.Message.Contains("Conversion failed"))
                    {
                        MessageBox.Show("Employee ID must be an Integer number");
                        return;
                    }
                    else
                    {
                        MessageBox.Show(f.Message);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            GC.Collect();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Notes where EmpID = @p1",con);
            cmd.Parameters.AddWithValue("@p1", EmpID.ToString());
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            try{
                da.Fill(ds,"Notes");
                dr = ds.Tables["Notes"].Rows[0];
                textBox1.Text = dr["EmpID"].ToString();
                richTextBox1.Text = dr["Note"].ToString();
            }
            catch(IndexOutOfRangeException f)
            {
                if (f.Message.Contains("Conversion failed"))
                {
                    MessageBox.Show("Employee ID must be an Integer number");
                    return;
                }
                else
                {
                    MessageBox.Show(f.Message);
                    return;
                }
            }
        }
        
    }
}
