using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
namespace RamiProj.EmployeeIdentity
{
    public partial class FindInformation : Form
    {
        public string connectionString;
        public FindInformation()
        {
            InitializeComponent();
        }

        private void FindInformation_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID", con);
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
            SqlCommand cmdAge = new SqlCommand("select distinct Age from EmpID order by Age asc", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdAge.ExecuteReader();
                IList<string> list = new List<string>();
                while(dr.Read())
                {
                    list.Add(dr["Age"].ToString());
                }
                comboBoxFindByAge.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmdID = new SqlCommand("select distinct EmployeeID from EmpID order by EmployeeID asc", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdID.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["EmployeeID"].ToString());
                }
                comboBoxFindById.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmdGender = new SqlCommand("select distinct Gender from EmpID", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdGender.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["Gender"].ToString());
                }
                comboBoxFindByGender.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmdLicense = new SqlCommand("select distinct DrivingLicense from EmpID", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdLicense.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["DrivingLicense"].ToString());
                }
                comboBoxFindByDrivingLicense.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmdMilitaryService = new SqlCommand("select distinct MilitaryService from EmpID", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdMilitaryService.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["MilitaryService"].ToString());
                }
                comboBoxFindByMilitaryService.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmdFIrstName = new SqlCommand("select distinct FirstName from EmpID order by FirstName asc", con);
            try
            {
                con.Open();
                IList<string> list = new List<string>();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    list.Add(dr["FirstName"].ToString());

                }
                comboBoxFirstName.DataSource = list;
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);

            }
            finally
            {
                con.Close();
            }
            //SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmdFindByWorkingStatus = new SqlCommand("select distinct WorkingStatus from EmpID", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmdFindByWorkingStatus.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["WorkingStatus"].ToString());
                }
                comboBoxFindByWorkingStatus.DataSource = list;
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

        private void comboBoxFindById_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where EmployeeID = @para",con);
            cmd.Parameters.AddWithValue("@para", comboBoxFindById.Text);
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
        }

        private void comboBoxFindByAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where Age = @para", con);
            cmd.Parameters.AddWithValue("@para", comboBoxFindByAge.Text);
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

        private void comboBoxFindByGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where Gender = @para", con);
            cmd.Parameters.AddWithValue("@para", comboBoxFindByGender.Text);
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

        private void comboBoxFindByDrivingLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where DrivingLicense = @para", con);
            cmd.Parameters.AddWithValue("@para", comboBoxFindByDrivingLicense.Text);
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

        private void comboBoxFindByMilitaryService_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where MilitaryService = @para", con);
            cmd.Parameters.AddWithValue("@para", comboBoxFindByMilitaryService.Text);
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

        private void comboBoxFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where FirstName = @para", con);
            cmd.Parameters.AddWithValue("@para", comboBoxFirstName.Text);
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

        private void comboBoxFindByWorkingStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where WorkingStatus = @para", con);
            cmd.Parameters.AddWithValue("@para", comboBoxFindByWorkingStatus.Text);
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

        private void buttonReportIdentity_Click(object sender, EventArgs e)
        {
            
                Int32 n;
                if (Int32.TryParse(textBoxEmpid.Text, out  n))
                {
                    GC.Collect();
                    if (textBoxEmpid.Text == "")
                    {
                        MessageBox.Show("please enter employee id to display report for");
                        return;
                    }
                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("select * from EmpID where employeeID = @p1", con);
                    cmd.Parameters.AddWithValue("@p1", textBoxEmpid.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(!dr.Read())
                    {
                        MessageBox.Show("This id does'nt exist in the database");
                        return;
                    }
                    Report form = new Report();
                    form.empid = Convert.ToInt32(textBoxEmpid.Text);
                    form.connectionString = connectionString;
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Employee ID must be an intiger");
                    return;
                }
            }
           
        }
    
}
