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
    public partial class PaymentInfo : Form
    {
        public string connectionString;

        public PaymentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "")
            {
                MessageBox.Show("please enter Employee ID");
                return;
            }
            if(textBoxRewardAmount.Text == "")
            {
                MessageBox.Show("please enter reward amount");
                return;
            }
            if(textBoxPunishmentAmount.Text == "")
            {
                MessageBox.Show("please enter punishment amount");
                return;
            }
            if(textBoxDateOfPayment.Text == "")
            {
                MessageBox.Show("please enter date of payment");
                return;
            }
           
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into PaymentInfo(EmpID ,   RewardAmount , PunishmentAmount , DateOfPayment , SalaryAmount) values(@p1 , @p2 , @p3, @p4,(select SalaryAmount from FIxedSalary where DateOfDecision = (select max(DateOfDecision) from FixedSalary where EmpID =  @p5) and EmpID = @p1))", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxRewardAmount.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxPunishmentAmount.Text);
            cmd.Parameters.AddWithValue("@p4", textBoxDateOfPayment.Text);
            cmd.Parameters.AddWithValue("@p5", textBoxEmpID.Text);
            try
            {
                try
                {
                    con.Open();
                    int NoOfRows = cmd.ExecuteNonQuery();
                    MessageBox.Show(NoOfRows.ToString() + "Row(s) inserted");
                }
                catch (SqlException f)
                {
                    if (f.Message.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint fk3"))
                    {
                        MessageBox.Show("You dont have this employee in the database");
                    }

                    else if (f.Message.Contains("Cannot insert the value NULL"))
                    {
                        MessageBox.Show("You need to determine the fixed salary amount for this employee");
                    }
                    else if(f.Message.Contains("Error converting data"))
                    {
                        MessageBox.Show("You need to enter a numeric value in the Reward amount or punishment amount");
                    }
                    else if (f.Message.Contains("Conversion failed when converting"))
                    {
                        MessageBox.Show("You need to enter an integer value in the Employee ID");
                    }
                    else
                        MessageBox.Show(f.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            catch(IndexOutOfRangeException g)
            {
                MessageBox.Show(g.Message);
            }
            }
            

        

        private void buttonDisplayInfo_Click(object sender, EventArgs e)
        {
            FindPaymentInfo form = new FindPaymentInfo();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            UpdateSalaryByID form = new UpdateSalaryByID();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
            DeletePayment form = new DeletePayment();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void PaymentInfo_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar2.Visible = false;
            monthCalendar2.MaxSelectionCount = 1;
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

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDateOfPayment.Text = monthCalendar2.SelectionStart.Date.ToString();
            monthCalendar2.Visible = false;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
