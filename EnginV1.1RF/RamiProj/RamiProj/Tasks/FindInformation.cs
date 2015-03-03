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
    public partial class FindInformation : Form
    {
        public string connectionString;
        public FindInformation()
        {
            InitializeComponent();
        }
        ComboBox fillComboBox(SqlConnection con, SqlCommand cmd, ComboBox cBox)
        {
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr[0].ToString());

                }
                cBox.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            return cBox;
        }
        private void FindInformation_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(this.connectionString);
            SqlCommand cmdEmpID = new SqlCommand("select distinct EmpID from Tasks", con);
            SqlCommand cmdTaskName = new SqlCommand("select distinct TaskName from Tasks", con);
            SqlCommand cmdStartDate = new SqlCommand("select distinct StartDate from Tasks", con);
            SqlCommand cmdEndDate = new SqlCommand("select distinct EndDate from Tasks", con);
            fillComboBox(con, cmdEmpID, comboBoxEmpID);
            fillComboBox(con, cmdTaskName, comboBoxTaskName);
            fillComboBox(con, cmdStartDate, comboBoxStartDate);
            fillComboBox(con, cmdEndDate, comboBoxEndDate);
            SqlCommand cmd = new SqlCommand("select b.FirstName , b.MiddleName , b.LastName , a.*   from Tasks a join EmpID b on a.EmpID = b.EmployeeID", con);
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

        private void comboBoxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Tasks where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxEmpID.Text);
            
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

        private void comboBoxTaskName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Tasks where TaskName = @p2 ", con);
            
            cmd.Parameters.AddWithValue("@p2", comboBoxTaskName.Text);
            
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

        private void comboBoxStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Tasks where StartDate = @p3 ", con);
            
            cmd.Parameters.AddWithValue("@p3", comboBoxStartDate.Text);
            
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

        private void comboBoxEndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Tasks where EndDate = @p4", con);
            
            cmd.Parameters.AddWithValue("@p4", comboBoxEndDate.Text);
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
    }
}
