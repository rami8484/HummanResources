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
    public partial class JobAndDepartment : Form
    {
        public string connectionString;
        public JobAndDepartment()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("please enter employee ID");
                    return;
                }


                if (comboBoxIsTrainer.Text == "")
                {
                    MessageBox.Show("please enter Is trainer");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("insert into EmpJob (EmpID , JobTitle , Department , WorkingHours , IsTrainer , Responsibilities) values (@p1 , @p2 , @p3 , @p4 , @p5 , @p6)", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                cmd.Parameters.AddWithValue("@p2", comboBoxJobTitle.Text);
                cmd.Parameters.AddWithValue("@p3", comboBoxDepartment.Text);
                cmd.Parameters.AddWithValue("@p4", comboBox3Hours.Text);
                cmd.Parameters.AddWithValue("@p5", comboBoxIsTrainer.Text);
                cmd.Parameters.AddWithValue("@p6", richTextBoxResponsibilities.Text);

                try
                {
                    con.Open();
                    int NoOfRows = cmd.ExecuteNonQuery();
                    MessageBox.Show(NoOfRows.ToString() + "Row(s) inserted");
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
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Employee ID must be an integer value");
            }
            
        }

        private void JobAndDepartment_Load(object sender, EventArgs e)
        {
            GC.Collect();
            BasselRamiProj.ListOfJobTitles listJob = new BasselRamiProj.ListOfJobTitles();
            comboBoxJobTitle.DataSource = listJob.item;
            comboBoxDepartment.Items.Add("Sales");
            for (int n = 1;n <= 24 ; n++)
            {
                comboBox3Hours.Items.Add(n.ToString());

            }
            comboBoxIsTrainer.Items.Add("Yes");
            comboBoxIsTrainer.Items.Add("No");

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            JobAndDepartmentUpdate form = new JobAndDepartmentUpdate();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonFindInformation_Click(object sender, EventArgs e)
        {
            FindInfo form = new  FindInfo();
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
