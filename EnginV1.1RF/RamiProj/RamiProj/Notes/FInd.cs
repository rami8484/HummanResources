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
    public partial class FInd : Form
    {
        public string connectionString;
        public FInd()
        {
            InitializeComponent();
            this.Text = "Find";
        }

        private void FInd_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select a.FirstName , a.MiddleName , a.LastName , b.Note from EmpID a join Notes b on a.EmployeeID = b.EmpID",con);
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
            SqlConnection con1 = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand("select EmpID from Notes order by EmpID asc", con1);
            try
            {
                con1.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                IList<string> list = new List<string>();
                while(dr.Read())
                {
                    list.Add(dr["EmpID"].ToString());
                }
                comboBoxFindByID.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con1.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select a.FirstName , a.MiddleName , a.LastName , b.Note from EmpID a join Notes b on a.EmployeeID = b.EmpID where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxFindByID.Text);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
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
