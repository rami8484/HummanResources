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
    public partial class Delete : Form
    {
        public string connectionString;
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete from WorkingHours where EmpID = @p1 and WorkDate = @p2", con);
            cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionRange.Start.ToString());
            int rowCount;
            try
            {
                con.Open();
                rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show(rowCount.ToString() + "Row(s) deleted");
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
    }
}
