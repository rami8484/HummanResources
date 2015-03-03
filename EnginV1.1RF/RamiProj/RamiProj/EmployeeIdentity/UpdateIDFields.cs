using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RamiProj.EmployeeIdentity
{
    public partial class UpdateIDFields : Form
    {
        DataRow dr;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommandBuilder cmdBuilder;
        public int EmpID;
        public string connectionString;
        public UpdateIDFields()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            dr["FIrstName"] = textBoxFirstName.Text;
            dr["MiddleName"] = textBoxMiddleName.Text;
            dr["LastName"] = textBoxLastName.Text;
            dr["Gender"] = comboBoxGender.Text;
            dr["Nationality"] = comboBoxNationality.Text;
            dr["Nationality2"] = comboBoxNationality2.Text;
            dr["PhoneNumber"] = textBoxPhoneNumber.Text;
            dr["MobileNumber"] = textBoxMobileNumber.Text;
            dr["Email"] = textBoxEmail.Text;
            dr["Address1"] = textBoxAddress1.Text;
            dr["Address2"] = textBoxAddress2.Text;
            dr["DrivingLicense"] = comboBoxDrivingLicense.Text;
            dr["MilitaryService"] = comboBoxMilitaryService.Text;
            dr["Birthdate"] = textBoxBirthDate.Text;
            dr["WorkingStatus"] = comboBoxWorkingStatus.Text;
            try
            {
                int NoOfRows = da.Update(ds, "EmpID");
                MessageBox.Show(NoOfRows.ToString() + "Rows updated");
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            GC.Collect();
        }
        private void UpdateIDFields_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Visible = false;
            BasselRamiProj.ListOfAllCountries list = new BasselRamiProj.ListOfAllCountries();
            comboBoxNationality.DataSource = list.list;
            BasselRamiProj.ListOfAllCountries list1 = new BasselRamiProj.ListOfAllCountries();
            comboBoxNationality2.DataSource = list1.list;

            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");

            comboBoxDrivingLicense.Items.Add("Exist");
            comboBoxDrivingLicense.Items.Add("Doesnt exist");

            comboBoxMilitaryService.Items.Add("Done");
            comboBoxMilitaryService.Items.Add("Not done");
            comboBoxMilitaryService.Items.Add("None");

            comboBoxWorkingStatus.Items.Add("Working");
            comboBoxWorkingStatus.Items.Add("Not working");


            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where EmployeeID = @para", con);
            cmd.Parameters.AddWithValue("@para", EmpID.ToString());
            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();

            try
            {
                da.Fill(ds, "EmpID");
                dr = ds.Tables["EmpID"].Rows[0];
                textBoxFirstName.Text = dr["FirstName"].ToString();
                textBoxMiddleName.Text = dr["MiddleName"].ToString();
                textBoxLastName.Text = dr["LastName"].ToString();
                comboBoxGender.Text = dr["Gender"].ToString();
                comboBoxNationality.Text = dr["Nationality"].ToString();
                comboBoxNationality2.Text = dr["Nationality2"].ToString();
                textBoxPhoneNumber.Text = dr["PhoneNumber"].ToString();
                textBoxMobileNumber.Text = dr["MobileNumber"].ToString();
                textBoxEmail.Text = dr["Email"].ToString();
                textBoxAddress1.Text = dr["Address1"].ToString();
                textBoxAddress2.Text = dr["Address2"].ToString();
                comboBoxDrivingLicense.Text = dr["DrivingLicense"].ToString();
                comboBoxMilitaryService.Text = dr["MilitaryService"].ToString();
                textBoxBirthDate.Text = dr["Birthdate"].ToString();
                comboBoxWorkingStatus.Text = dr["WorkingStatus"].ToString();
                
            }
            catch(SqlException f)
            {
                

                    MessageBox.Show(f.Message);
                
            }
        }
        

        

        private void buttonSelectDate_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxBirthDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }
    }
}
