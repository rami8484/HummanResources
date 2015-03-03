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
    public partial class EmployeeRating : Form
    {
        public string connectinString;
        public EmployeeRating()
        {
            InitializeComponent();
        }

        private void EmployeeRating_Load(object sender, EventArgs e)
        {
            IList<string> list = new List<string>();
            for (int n = 1;n <= 5;n++)
            {
                list.Add(n.ToString());
            }
            comboBoxCOmmunication.DataSource = list;
            comboBoxIntiative.DataSource = list;
            comboBoxQualityOfWork.DataSource = list;
            comboBoxRelationship.DataSource = list;

            monthCalendar1.Visible = false;
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter employee ID");
                return;
            }
            if(comboBoxCOmmunication.Text == "")
            {
                MessageBox.Show("Please enter communication rating");
                return;
            }
            if(comboBoxIntiative.Text == "")
            {
                MessageBox.Show("Please enter Intiative rating");
                return;
            }
            if(comboBoxQualityOfWork.Text == "")
            {
                MessageBox.Show("Please enter Quality of work rating");
                return;
            }
            if(comboBoxRelationship.Text == "")
            {
                MessageBox.Show("Please enter Relationship rating");
                return;
            }
            
            SqlConnection con = new SqlConnection(connectinString);
            SqlCommand cmd = new SqlCommand("insert into EmpRating( EmpID,Date,GreatAchivementsSummary ,.QualityOfWorkRating, RelationshipWithColleguesRating ,InitiativeRating , CommunicationRating ) values(@p1,@p2,@p3,@p4,@p4,@p6,@p7) ", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxDate.Text);
            cmd.Parameters.AddWithValue("@p3", richTextBoxAchievements.Text);
            cmd.Parameters.AddWithValue("@p4", comboBoxQualityOfWork.Text);
            cmd.Parameters.AddWithValue("@p5", comboBoxRelationship.Text);
            cmd.Parameters.AddWithValue("@p6", comboBoxIntiative.Text);
            cmd.Parameters.AddWithValue("@p7", comboBoxCOmmunication.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
            }
            catch(SqlException f)
            {
                if (f.Message.Contains("Violation of UNIQUE KEY constraint 'UNIQUE_EmpIDDate'"))
                {
                    MessageBox.Show("You cannot add the same employee in the same date, please change the date");
                }
                else
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
                monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Select2Update form = new Select2Update();
            form.connectionString = connectinString;
            form.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Find form = new Find();
            form.connectionString = connectinString;
            form.ShowDialog();
        }
    }
}
