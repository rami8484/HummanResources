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
    public partial class Report : Form
    {
        public string connectionString;
        public string Date;
        public string EmpID;
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from getEmpRating where EmployeeID = @p1 and Date = @p2", con);
            cmd.Parameters.AddWithValue("@p1", EmpID);
            cmd.Parameters.AddWithValue("@p2", Date);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            
            try
            {
                da.Fill(ds, "EmpRating");
                EmpRatingReport rpt = new EmpRatingReport();
                rpt.SetDataSource(ds.Tables["EmpRating"]);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            
        }
    }
}
