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
    public partial class Update : Form
    {
        public DataSet ds;
        public SqlDataAdapter da;
        public SqlCommandBuilder cmdBuilder;
        DataRow dr;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar1.MaxSelectionCount = 1;
            IList<string> list = new List<string>();
            for (int n = 0; n <= 24; n++)
            {

                list.Add(n.ToString());
            }
            comboBoxWorkingHours.DataSource = list;
            comboBoxIsHoliday.Items.Add("Yes");
            comboBoxIsHoliday.Items.Add("No");
            comboBoxIsVacation.Items.Add("Yes");
            comboBoxIsVacation.Items.Add("No");

            try
            {
                dr = ds.Tables[0].Rows[0];
                textBoxEmpID.Text = dr["EmpID"].ToString();
                comboBoxIsHoliday.Text = dr["IsHoliday"].ToString();
                comboBoxIsVacation.Text = dr["IsVacation"].ToString();
                comboBoxWorkingHours.Text = dr["NumberOfWorkingHours"].ToString();
                monthCalendar1.SetDate(Convert.ToDateTime(dr["WorkDate"].ToString()));
            }
            catch(IndexOutOfRangeException f)
            {
                MessageBox.Show(f.Message);
                
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            dr["EmpID"] = textBoxEmpID.Text;
            dr["WorkDate"] = monthCalendar1.SelectionRange.Start.ToString();
            dr["IsHoliday"] = comboBoxIsHoliday.Text;
            dr["IsVacation"] = comboBoxIsVacation.Text;
            dr["NumberOfWorkingHours"] = comboBoxWorkingHours.Text;
            try
            {
                int rowCount = da.Update(ds, "WorkingHours");
                MessageBox.Show(rowCount.ToString() + "Row(s) updated");
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
