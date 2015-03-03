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
    public partial class Select2Update : Form
    {
        public string connectionString;
        public Select2Update()
        {
            InitializeComponent();
        }

        private void buttonSelect2Update_Click(object sender, EventArgs e)
        {
            GC.Collect();


            int n;
            DateTime date;
            if (Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                if (textBoxEmpID.Text == "")
                {
                    MessageBox.Show("Please enter the ID");
                    return;
                }
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from WorkingHours where empid = @p1 and workdate = @p2 ", con);
                cmd.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
                cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionRange.Start.ToString());

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("This id or the date dont exist in the database");
                    return;
                }

            }

            else if (!Int32.TryParse(textBoxEmpID.Text, out  n))
            {
                MessageBox.Show("Employee ID must be an integer value");
                return;
            }

            GC.Collect();

            SqlConnection con1 = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand("select * from WorkingHours where EmpID = @p1 and WorkDate = @p2", con1);
            cmd1.Parameters.AddWithValue("@p1", textBoxEmpID.Text);
            cmd1.Parameters.AddWithValue("@p2", monthCalendar1.SelectionRange.Start.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "WorkingHours");
            Update form = new Update();
            form.ds = ds;
            form.da = da;
            form.cmdBuilder = cmdBuilder;
            form.ShowDialog();

            
        }

        private void Select2Update_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar1.MaxSelectionCount = 1;
        }
    }
}
