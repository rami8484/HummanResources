using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.EmployeeRating
{
    public partial class Update : Form
    {
        public string EmpID;
        public string Date1;
        public string connectionString;
        SqlDataAdapter da;
        SqlCommandBuilder cmdBuilder;
        DataRow dr;
        DataSet ds;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select EmpID ,Date, CommunicationRating, InitiativeRating ,QualityOfWorkRating , RelationshipWithColleguesRating ,  GreatAchivementsSummary from EmpRating where EmpID = @p1 and date = @p2", con);
            cmd.Parameters.AddWithValue("@p1", EmpID);
            cmd.Parameters.AddWithValue("@p2", Date1);
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);

            try
            {
                con.Open();
                ds = new DataSet();
                da.Fill(ds, "EmpRating");
                dr = ds.Tables[0].Rows[0];
                textBoxDate.Text = dr["Date"].ToString();
                comboBoxCOmmunication.Text = dr["CommunicationRating"].ToString();
                comboBoxIntiative.Text = dr["InitiativeRating"].ToString();
                comboBoxQualityOfWork.Text = dr["QualityOfWorkRating"].ToString();
                comboBoxRelationship.Text = dr["RelationshipWithColleguesRating"].ToString();
                richTextBoxAchievements.Text = dr["GreatAchivementsSummary"].ToString();
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            monthCalendar1.Visible = false;
            monthCalendar1.MaxSelectionCount = 1;
        }

       

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dr["Date"] = textBoxDate.Text;
            dr["CommunicationRating"] = comboBoxCOmmunication.Text;
            dr["InitiativeRating"] = comboBoxIntiative.Text;
            dr["QualityOfWorkRating"] = comboBoxQualityOfWork.Text;
            dr["RelationshipWithColleguesRating"] = comboBoxRelationship.Text;
            dr["GreatAchivementsSummary"] = richTextBoxAchievements.Text;

            try
            {
                int noOfRows = da.Update(ds, "EmpRating");
                MessageBox.Show(noOfRows.ToString() + "Rows updated");
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonCalendar_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
                monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            textBoxDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }
    }
}
