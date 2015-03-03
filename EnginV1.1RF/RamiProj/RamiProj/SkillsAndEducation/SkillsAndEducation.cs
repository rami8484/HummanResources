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
    public partial class SkillsAndEducation : Form
    {
        public string connectionString;
        public SkillsAndEducation()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter Employee ID");
                return;
            }
            if (textBoxHigherEducation.Text == "")
            {
                MessageBox.Show("Please enter the higher education");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into EducationAndSkills(EmpID,HigherEducation,UniversityName,DegreeLevel,Score,WorkingExperienceReport,Responsibilities) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxHigherEducation.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxUniversityName.Text);
            cmd.Parameters.AddWithValue("@p4", textBoxDegreeLevel.Text);
            cmd.Parameters.AddWithValue("@p5", textBoxScore.Text);
            cmd.Parameters.AddWithValue("@p6", richTextBoxWorkingExperienceReport.Text);
            cmd.Parameters.AddWithValue("@p7", richTextBoxResponsibilities.Text);
            try
            {
                con.Open();
                int NoOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfRows.ToString() + "Row(s) inserted");
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SelectToUpdate form = new SelectToUpdate();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Delete form = new Delete();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            GC.Collect();
            Find form = new Find();
            form.connectionString = connectionString;
            form.ShowDialog();
        }
    }
}
