using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.WorkingHours
{
    public partial class WorkingHours : Form
    {
        public string connectionString;
        public WorkingHours()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            GC.Collect();
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("Please enter employee ID");
                return;
            }
            if (comboBoxIsHoliday.Text == "")
            {
                MessageBox.Show("Please enter Is holiday");
                return;
            }
            if (comboBoxIsVacation.Text == "")
            {
                MessageBox.Show("Please enter Is vacation");
                return;
            }
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into WorkingHours(EmpID,WorkDate,NumberOfWorkingHours,IsHoliday,IsVacation) values(@p1,@p2,@p3,@p4,@p5)", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            
            cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionRange.Start.ToString());
            cmd.Parameters.AddWithValue("@p3", comboBoxWorkingHours.Text);
            cmd.Parameters.AddWithValue("@p4", comboBoxIsHoliday.Text);
            cmd.Parameters.AddWithValue("@p5", comboBoxIsVacation.Text);
            try
            {
                int NoOfRows = 0;
                con.Open();
                NoOfRows = cmd.ExecuteNonQuery();
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

        private void WorkingHours_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar1.MaxSelectionCount = 1;
            IList<string> list = new List<string>();
            for(int n = 0;n <= 24;n++)
            {

                list.Add(n.ToString());
            }
            comboBoxWorkingHours.DataSource = list;
            comboBoxIsHoliday.Items.Add("Yes");
            comboBoxIsHoliday.Items.Add("No");
            comboBoxIsVacation.Items.Add("Yes");
            comboBoxIsVacation.Items.Add("No");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Select2Update form = new Select2Update();
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

        private void comboBoxWorkingHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxWorkingHours.Text != "0")
            {
                comboBoxIsHoliday.Text = "No";
                comboBoxIsVacation.Text = "No";
            }
        }
    }
}
