using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.SkillsAndEducation
{
    public partial class Delete : Form
    {
        public string connectionString;
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select b.EmpID , a.FirstName , a.MiddleName , a.LastName from EmpID a join EducationAndSkills b on a.EmployeeID = b.EmpID", con);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete from EducationAndSkills where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            try
            {
                con.Open();
                int NoOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfRows.ToString() + "Row(S) deleted");
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
    }
}
