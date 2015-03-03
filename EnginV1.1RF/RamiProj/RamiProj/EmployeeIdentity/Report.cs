using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace RamiProj.EmployeeIdentity
{
    public partial class Report : Form
    {

        public int empid;
        public string connectionString;
        public Report()
        {
            InitializeComponent();
        }
        
        private void Report_Load(object sender, EventArgs e)
        {

            GC.Collect();
            IdentityRep EmpIDReport;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where EmployeeID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", empid.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(ds, "EmpID");
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            //DataRow dr = ds.Tables[0].Rows[0];
            //MessageBox.Show(dr["EmployeeID"].ToString());
            EmpIDReport = new IdentityRep();
            EmpIDReport.SetDataSource(ds.Tables[0]);
            ds = null;
            //EmpIDReport.Load("C:\\Reports\\IdentityRep.rpt");
            
           

            crystalReportViewer1.ReportSource = EmpIDReport;
            crystalReportViewer1.Refresh();
            EmpIDReport = null;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
