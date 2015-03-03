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
    public partial class FindInfo : Form
    {
        public string connectionString;
        public FindInfo()
        {
            InitializeComponent();
        }

        private void FindInfo_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select EmpID from EmpJob order by EmpID asc", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                IList<string> list = new List<string>();
                while(dr.Read())
                {
                    list.Add(dr["EmpID"].ToString());
                }
                comboBoxEmpID.DataSource = list;
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

        private void comboBoxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select em.EmployeeID , em.FIrstName,em.MiddleName,em.LastName,e.* from EmpJob e,EmpID em where EmpID = @p1 and e.EmpID = em.EmployeeID", con);
            cmd.Parameters.AddWithValue("@p1", comboBoxEmpID.Text);
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
