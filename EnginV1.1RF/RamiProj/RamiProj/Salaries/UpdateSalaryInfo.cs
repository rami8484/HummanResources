using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Salaries
{
    public partial class UpdateSalaryInfo : Form
    {
        public string connectionString;
        public string date;
        public int EmpID;
        SqlDataAdapter da;
        SqlCommandBuilder cmdBuilder;
        DataSet ds;
        DataRow dr;
        public UpdateSalaryInfo()
        {
            InitializeComponent();
        }

        private void UpdateSalaryInfo_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar2.Visible = false;
            monthCalendar2.MaxSelectionCount = 1;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from PaymentInfo",con);
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            try
            {
                da.Fill(ds, "PaymentInfo");
                dr = ds.Tables["PaymentInfo"].Rows[0];
                textBoxEmpID.Text = dr["EmpID"].ToString();
                textBoxDateOfPayment.Text = dr["DateOfPayment"].ToString();
                textBoxRewardAmount.Text = dr["RewardAmount"].ToString();
                textBoxPunishmentAmount.Text = dr["PunishmentAmount"].ToString();
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dr["EmpID"] = textBoxEmpID.Text;
            dr["DateOfPayment"] = textBoxDateOfPayment.Text;
            dr["RewardAmount"] = textBoxRewardAmount.Text;
            dr["PunishmentAmount"] = textBoxPunishmentAmount.Text;

            int NoOfRows = da.Update(ds, "PaymentInfo");
            MessageBox.Show(NoOfRows.ToString() + "Row(s) updated");
            GC.Collect();
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar2.Visible == false)
            {
                monthCalendar2.Visible = true;
            }
            else
                monthCalendar2.Visible = false;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDateOfPayment.Text = monthCalendar2.SelectionStart.Date.ToString();
            monthCalendar2.Visible = false;
        }
    }
}
