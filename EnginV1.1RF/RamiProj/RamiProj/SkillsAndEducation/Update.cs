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

        private void Update_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EducationAndSkills where EmpID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", EmpID.ToString());
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "EducationAndSkills");
            dr = ds.Tables[0].Rows[0];
            textBoxEmpID.Text = dr["EmpID"].ToString();
            textBoxHigherEducation.Text = dr["HigherEducation"].ToString();
            textBoxUniversityName.Text = dr["UniversityName"].ToString();
            textBoxDegreeLevel.Text = dr["DegreeLevel"].ToString();
            textBoxScore.Text = dr["Score"].ToString();
            richTextBoxWorkingExperienceReport.Text = dr["WorkingExperienceReport"].ToString();
            richTextBoxResponsibilities.Text = dr["Responsibilities"].ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dr["EmpID"] = textBoxEmpID.Text;
            dr["HigherEducation"] = textBoxHigherEducation.Text;
            dr["UniversityName"] = textBoxUniversityName.Text;
            dr["DegreeLevel"] = textBoxDegreeLevel.Text;
            dr["Score"] = textBoxScore.Text;
            dr["WorkingExperienceReport"] = richTextBoxWorkingExperienceReport.Text;
            dr["Responsibilities"] = richTextBoxResponsibilities.Text;
            int NoOfRows = da.Update(ds, "EducationAndSkills");
            MessageBox.Show(NoOfRows.ToString() + "Row(s) updated");
        }
    }
}
