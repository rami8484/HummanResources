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

namespace RamiProj.WorkingHours
{
    public partial class Report : Form
    {
        public string connectionString;
        public int EmpID;
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from getWorkingHoursInfo where EmployeeID = @p1",con);
            cmd.Parameters.AddWithValue("@p1", EmpID.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "WorkingHours");
            WorkingHours1 rep = new WorkingHours1();
            rep.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.Refresh();
        }
    }
}
