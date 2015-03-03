using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace RamiProj.Salaries
{
    public partial class PaymentReport : Form
    {
        public int EmpID;
        public string connectionString;
        public PaymentReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select a.EmployeeID , a.FIrstName , a.MiddleName , a.LastName , b.PaymentAmount, b.DateOfPayment from EmpID a join getSalaryInfo2  b on a.EmployeeID = b.EmployeeID where a.EmployeeID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", EmpID.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Join");
            PaymentsReport1 rep = new PaymentsReport1();
            rep.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.Refresh();
        }
    }
}
