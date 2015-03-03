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
    public partial class Identity : Form
    {
        public string connectionString;
        public Identity()
        {
            InitializeComponent();
        }

        private void Identity_Load(object sender, EventArgs e)
        {
            GC.Collect();
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Visible = false;
            BasselRamiProj.ListOfAllCountries countriesList = new BasselRamiProj.ListOfAllCountries();
            comboBoxNationality.DataSource = countriesList.list;
            BasselRamiProj.ListOfAllCountries countriesList1 = new BasselRamiProj.ListOfAllCountries();
            comboBoxNationality2.DataSource = countriesList1.list;

            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");

            comboBoxDrivingLicense.Items.Add("Exists");
            comboBoxDrivingLicense.Items.Add("Does'nt exist");

            comboBoxMilitaryService.Items.Add("Done");
            comboBoxMilitaryService.Items.Add("Not done");
            comboBoxMilitaryService.Items.Add("None");

            comboBoxWorkingStatus.Items.Add("Working");
            comboBoxWorkingStatus.Items.Add("Not working");

            

            
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(textBoxFirstName.Text == "")
            {
                MessageBox.Show("Please enter the first name");
                return;
            }
            if (textBoxMiddleName.Text == "")
            {
                MessageBox.Show("Please enter the Middle name");
                return;
            }
            if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Please enter the Last name");
                return;
            }
            if (comboBoxGender.Text == "")
            {
                MessageBox.Show("Please enter the Gender");
                return;
            }
            if (comboBoxNationality.Text == "")
            {
                MessageBox.Show("Please enter the Nationality");
                return;
            }
            if (textBoxPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter the Phone number");
                return;
            }
            if (textBoxAddress1.Text == "")
            {
                MessageBox.Show("Please enter the Address");
                return;
            }
            if (comboBoxDrivingLicense.Text == "")
            {
                MessageBox.Show("Please enter the Driving lisence status");
                return;
            }
            if (comboBoxMilitaryService.Text == "")
            {
                MessageBox.Show("Please enter the Military service status");
                return;
            }
             if (textBoxBirthDate.Text == "")
            {
                MessageBox.Show("Please enter the BirthDate");
                return;
            }
            if(comboBoxWorkingStatus.Text == "")
            {
                MessageBox.Show("Please enter the working status");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Insert into EmpID(FirstName , MiddleName , LastName ,Gender , BirthDate , Nationality , Nationality2 , MilitaryService , PhoneNumber , MobileNumber , Address1 , Address2 , DrivingLicense,WorkingStatus,Email ) values (@para1 , @para2 , @para3 , @para4 , @para5 , @para6 , @para7 , @para8 , @para9 , @para10 , @para11 , @para12 , @para13 , @para14 , @para15)", con);
            cmd.Parameters.AddWithValue("@para1", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@para2", textBoxMiddleName.Text);
            cmd.Parameters.AddWithValue("@para3", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@para4", comboBoxGender.Text);
            cmd.Parameters.AddWithValue("@para5", textBoxBirthDate.Text);
            cmd.Parameters.AddWithValue("@para6", comboBoxNationality.Text);
            cmd.Parameters.AddWithValue("@para7", comboBoxNationality2.Text);
            cmd.Parameters.AddWithValue("@para8", comboBoxMilitaryService.Text);
            cmd.Parameters.AddWithValue("@para9", textBoxPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@para10", textBoxMobileNumber.Text);
            cmd.Parameters.AddWithValue("@para11", textBoxAddress1.Text);
            cmd.Parameters.AddWithValue("@para12", textBoxAddress2.Text);
            cmd.Parameters.AddWithValue("@para13", comboBoxDrivingLicense.Text);
            cmd.Parameters.AddWithValue("@para14", comboBoxWorkingStatus.Text);
            cmd.Parameters.AddWithValue("@para15", textBoxEmail.Text);
            try
            {
                con.Open();
                int rowsCount = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsCount.ToString() + "Rows inserted");

            }
            catch(SqlException f)
            {
                if (f.Message.Contains("Violation of UNIQUE KEY constraint 'UN'. Cannot insert duplicate key in object 'dbo.EmpID'"))
                {
                    MessageBox.Show("Full name exists in the database");
                }
                else if (f.Message.Contains("Error converting"))
                {
                    MessageBox.Show("You must enter a number as a phone number or mobile number");
                }
                else
                {
                    MessageBox.Show(f.Message);
                }
            }
            finally
            {
                con.Close();
            }

        }

        private void buttonFindInformation_Click(object sender, EventArgs e)
        {
            //this.Close();
            FindInformation form = new FindInformation();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GC.Collect();
            UpdateEmployeeID form = new UpdateEmployeeID();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEmp form = new DeleteEmp();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonDisplayById_Click(object sender, EventArgs e)
        {
            if(textBoxEmployeeID.Text  == "")
            {
                MessageBox.Show("Please enter an Employee ID to display");
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from EmpID where EmployeeID = @para", con);
            cmd.Parameters.AddWithValue("@para", textBoxEmployeeID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();

            try
            {
                da.Fill(ds, "EmpID");
                DataRow dr = ds.Tables["EmpID"].Rows[0];

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
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxBirthDate.Text = monthCalendar1.SelectionStart.Date.ToString();
            monthCalendar1.Visible = false;
        }
    }
}
