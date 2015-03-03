using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.Tasks
{
    public partial class UpdateTask : Form
    {
        


        public string connectionString;
        public UpdateTask()
        {
            InitializeComponent();
        }

        ComboBox fillComboBox(SqlConnection con, SqlCommand cmd, ComboBox cBox)
        {
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                IList<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr[0].ToString());

                }
                cBox.DataSource = list;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
            return cBox;
        }
        private void UpdateTask_Load(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(this.connectionString);
            SqlCommand cmdEmpID = new SqlCommand("select distinct EmpID from Tasks", con);
            SqlCommand cmdTaskName = new SqlCommand("select distinct TaskName from Tasks", con);
            SqlCommand cmdStartDate = new SqlCommand("select distinct StartDate from Tasks", con);
            SqlCommand cmdEndDate = new SqlCommand("select distinct EndDate from Tasks", con);
            fillComboBox(con, cmdEmpID, comboBoxEmployeeID);
            fillComboBox(con, cmdTaskName, comboBoxTaskName);
            fillComboBox(con, cmdStartDate, comboBoxStartDate);
            fillComboBox(con, cmdEndDate, comboBoxEndDate);
            SqlCommand cmd = new SqlCommand("select * from Tasks order by EmpID asc", con);
            try
            {
                con.Open();
                BindingSource source = new BindingSource();
                source.DataSource = cmd.ExecuteReader();
                dataGridView1.DataSource = source;

            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {




            RamiProj.Tasks.UpdateInformation form = new UpdateInformation();
            form.EmpID = comboBoxEmployeeID.Text;
            form.TaskName = comboBoxTaskName.Text;
            form.StartDate = comboBoxStartDate.Text;
            form.EndDate = comboBoxEndDate.Text;
            form.connectionString = connectionString;
            form.ShowDialog();
            GC.Collect();
        }
    }
}
