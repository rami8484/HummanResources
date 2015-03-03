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
    public partial class Tasks : Form
    {
        public string connectionString;
        public Tasks()
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
            if (textBoxTaskName.Text == "")
            {
                MessageBox.Show("Please enter the task name");
                return;
            }
            if (textBoxStartDate.Text == "")
            {
                MessageBox.Show("Please enter the start date");
                return;
            }
            SqlConnection con = new SqlConnection(this.connectionString);
            SqlCommand cmd = new SqlCommand("insert into Tasks values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxTaskName.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxStartDate.Text);
            cmd.Parameters.AddWithValue("@p4", textBoxDelierDate.Text);
            cmd.Parameters.AddWithValue("@p5", richTextBoxDetails.Text);
            cmd.Parameters.AddWithValue("@p6", comboBoxStatus.Text);
            cmd.Parameters.AddWithValue("@p7", comboBoxPriority.Text);
            try
            {
                con.Open();
                int NoOfRows;
                NoOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(NoOfRows.ToString() + "Rows inserted");
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
            GC.Collect();
            RamiProj.Tasks.DeleteTask form = new DeleteTask();
            form.connectionString = connectionString;
            form.ShowDialog();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            RamiProj.Tasks.UpdateTask form = new UpdateTask();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonFindInformation_Click(object sender, EventArgs e)
        {
            RamiProj.Tasks.FindInformation form = new FindInformation();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            GC.Collect();
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
            list1.Add("High");
            list1.Add("Very High");
            comboBoxStatus.DataSource = list;
            comboBoxPriority.DataSource = list1;
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.Visible == false)
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

        private void buttonSelectDate2_Click(object sender, EventArgs e)
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxStartDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDelierDate.Text = monthCalendar2.SelectionStart.Date.ToString();
            monthCalendar2.Visible = false;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
