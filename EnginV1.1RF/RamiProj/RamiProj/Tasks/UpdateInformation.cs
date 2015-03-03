using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Tasks
{
    public partial class UpdateInformation : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlCommandBuilder cmdBuilder;
        public string TaskName;
        public string EmpID;
        public string StartDate;
        public string EndDate;
        public string connectionString;
        public UpdateInformation()
        {
            InitializeComponent();
        }

        private void UpdateInformation_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar2.Visible = false;
            monthCalendar2.MaxSelectionCount = 1;
            IList<string> list = new List<string>();
            list.Add("Pending");
            list.Add("Done");
            IList<string> list1 = new List<string>();
            list1.Add("Low");
            list1.Add("Medium");
            list1.Add("Hight");
            list1.Add("Very Hight");
            comboBoxStatus.DataSource = list;
            comboBoxPriority.DataSource = list1;
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Tasks where EmpID = @p1 and TaskName = @p2 and StartDate = @p3 and EndDate = @p4", con);
            cmd.Parameters.AddWithValue("@p1", EmpID);
            cmd.Parameters.AddWithValue("@p2", TaskName);
            cmd.Parameters.AddWithValue("@p3", StartDate);
            cmd.Parameters.AddWithValue("@p4", EndDate);
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            try
            {
                da.Fill(ds,"Tasks");
                dr = ds.Tables["Tasks"].Rows[0];
                textBoxEmpID.Text = dr["EmpID"].ToString();
                textBoxTaskName.Text = dr["TaskName"].ToString();
                textBoxStartDate.Text = dr["StartDate"].ToString();
                textBoxEndDate.Text = dr["EndDate"].ToString();
                richTextBoxDetails.Text = dr["Details"].ToString();



            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr["EmpID"] = textBoxEmpID.Text;
            dr["TaskName"] = textBoxTaskName.Text;
            dr["StartDate"] = textBoxStartDate.Text;
            dr["EndDate"] = textBoxEndDate.Text;
            dr["Details"] = richTextBoxDetails.Text;
            dr["Priority"] = comboBoxPriority.Text;
            dr["Status"] = comboBoxStatus.Text;
            try
            {
                int NoOfRows = da.Update(ds, "Tasks");
                MessageBox.Show(NoOfRows.ToString() + "Rows updated");
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            GC.Collect();
        }
        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSelectDate2_Click(object sender, EventArgs e)
        {
           
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxStartDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxEndDate.Text = monthCalendar2.SelectionStart.Date.ToString();
            monthCalendar2.Visible = false;
        }

        private void buttonSelectDate_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
                monthCalendar1.Visible = false;
            if (monthCalendar2.Visible == true)
            {
                monthCalendar2.Visible = false;
            }
        }

        private void buttonSelectDate2_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar2.Visible == false)
            {
                monthCalendar2.Visible = true;
            }
            else
                monthCalendar2.Visible = false;
            if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar2_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            textBoxEndDate.Text = monthCalendar2.SelectionStart.Date.ToString();
            monthCalendar2.Visible = false;
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            
            textBoxStartDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }
    }
}
