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
    public partial class JobAndDepartmentUpdateForm : Form
    {
        SqlCommandBuilder cmdBuilder;
        SqlDataAdapter da;
        DataRow dr;
        DataSet ds;
        public string connectionString;
        public int EmpID;
        public JobAndDepartmentUpdateForm()
        {
            InitializeComponent();
        }

        private void JobAndDepartmentUpdateForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
            BasselRamiProj.ListOfJobTitles listJob = new BasselRamiProj.ListOfJobTitles();
            comboBoxJobTitle.DataSource = listJob.item;
            comboBoxDepartment.Items.Add("Sales");
            for (int n = 1; n <= 24; n++)
            {
                comboBox3Hours.Items.Add(n.ToString());

            }
            comboBoxIsTrainer.Items.Add("Yes");
            comboBoxIsTrainer.Items.Add("No");

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpJob where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", EmpID.ToString());
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();

            try
            {

            
                da.Fill(ds,"EmpJob");

                dr = ds.Tables["EmpJob"].Rows[0];
                textBoxEmpID.Text = dr["EmpID"].ToString();
                comboBoxJobTitle.Text = dr["JobTitle"].ToString();
                comboBoxDepartment.Text = dr["Department"].ToString();
                comboBox3Hours.Text = dr["WorkingHours"].ToString();
                comboBoxIsTrainer.Text = dr["IsTrainer"].ToString();
                richTextBoxResponsibilities.Text = dr["Responsibilities"].ToString();
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void buttonUpdateInformation_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                dr["EmpID"] = textBoxEmpID.Text;
                dr["JobTitle"] = comboBoxJobTitle.Text;
                dr["Department"] = comboBoxDepartment.Text;
                dr["WorkingHours"] = comboBox3Hours.Text;
                dr["IsTrainer"] = comboBoxIsTrainer.Text;
                dr["Responsibilities"] = richTextBoxResponsibilities.Text;
                try
                {
                    int NoOfRows = da.Update(ds, "EmpJob");
                    MessageBox.Show(NoOfRows.ToString() + "Row(s) updated");
                }
                catch (SqlException f)
                {
                    if (f.Message.Contains("Violation of UNIQUE KEY constraint 'UQ__EmpJob__AF2DBA78B7C8A16F'."))
                    {
                        MessageBox.Show("You cannot assign the Employee more than one job in the database");
                    }
                    if (f.Message.Contains("Conversion failed"))
                    {
                        MessageBox.Show("Working hours must be an intiger");
                    }
                    else
                        MessageBox.Show(f.Message);
                }
            }
            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            GC.Collect();



        }
    }
}
