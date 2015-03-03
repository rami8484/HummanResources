using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Tasks
{
    public partial class DeleteTask : Form
    {
        public string connectionString;
        public DeleteTask()
        {
            InitializeComponent();
        }

        ComboBox fillComboBox(SqlConnection con,SqlCommand cmd,ComboBox cBox)
        {
            try
            {
                con.Open();
                SqlDataReader dr =  cmd.ExecuteReader();
                IList<string> list = new List<string>();
                while(dr.Read())
                {
                    list.Add(dr[0].ToString());
                    
                }
                cBox.DataSource = list;
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            return cBox;
        }

        private void DeleteTask_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(this.connectionString);
            SqlCommand cmdEmpID = new SqlCommand("select distinct EmpID from Tasks", con);
            SqlCommand cmdTaskName = new SqlCommand("select distinct TaskName from Tasks", con);
            SqlCommand cmdStartDate = new SqlCommand("select distinct StartDate from Tasks", con);
            SqlCommand cmdEndDate = new SqlCommand("select distinct EndDate from Tasks", con);
            fillComboBox(con, cmdEmpID,comboBoxEmployeeID);
            fillComboBox(con, cmdTaskName, comboBoxTaskName);
            fillComboBox(con, cmdStartDate, comboBoxStartDate);
            fillComboBox(con, cmdEndDate, comboBoxEndDate);
            SqlCommand cmd = new SqlCommand("select * from Tasks", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            SqlCommand cmd = new SqlCommand("delete from Tasks where EmpID = @p1 and TaskName = @p2 and StartDate = @p3 and EndDate = @p4", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxEmployeeID.Text);
            cmd.Parameters.AddWithValue("@p2", comboBoxTaskName.Text);
            cmd.Parameters.AddWithValue("@p3", comboBoxStartDate.Text);
            cmd.Parameters.AddWithValue("@p4", comboBoxEndDate.Text);
            try
            {
                con.Open();
                int NoOfROws = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfROws.ToString() + "Rows deleted");
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
    }
}
