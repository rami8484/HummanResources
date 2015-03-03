using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RamiProj
{
    public partial class MainWIndow : Form
    {
        public string connectionString;
        public MainWIndow()
        {
            InitializeComponent();
        }

        private void buttonEmployeeIdentity_Click(object sender, EventArgs e)
        {
            GC.Collect();
            EmployeeIdentity.Identity form = new EmployeeIdentity.Identity();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            JobAndDepartment.JobAndDepartment form = new JobAndDepartment.JobAndDepartment();
            form.connectionString = connectionString;
            form.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Salaries.SalaryMainWindow form = new Salaries.SalaryMainWindow();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Notes.Notes form = new Notes.Notes();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Tasks.Tasks form = new Tasks.Tasks();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonWorkingHours_Click(object sender, EventArgs e)
        {
            GC.Collect();
            WorkingHours.WorkingHours form = new WorkingHours.WorkingHours();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SkillsAndEducation.SkillsAndEducation form = new SkillsAndEducation.SkillsAndEducation();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void MainWIndow_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            GC.Collect();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("use Backup1234;use Employees;drop database Backup1234;create database Backup1234; select * into Backup1234.dbo.EmpID from Employees.dbo.EmpID;select * into Backup1234.dbo.Credencials from Employees.dbo.Credencials;select * into Backup1234.dbo.EducationAndSkills from Employees.dbo.EducationAndSkills;select * into Backup1234.dbo.EmpJob from Employees.dbo.EmpJob;select * into Backup1234.dbo.FixedSalary from Employees.dbo.FixedSalary;select * into Backup1234.dbo.Notes from Employees.dbo.Notes;select * into Backup1234.dbo.PaymentInfo from Employees.dbo.PaymentInfo;select * into Backup1234.dbo.Tasks from Employees.dbo.Tasks;select * into Backup1234.dbo.WorkingHours from Employees.dbo.WorkingHours;", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup complete");
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

        private void button4_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Authentication.UsersAccounts form = new Authentication.UsersAccounts();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonGetCompletedEmployeeReport_Click(object sender, EventArgs e)
        {
            GC.Collect();
            FullReport.FullReport form = new FullReport.FullReport();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            GC.Collect();
            About.About form = new About.About();
            form.ShowDialog();
        }

        private void buttonEmpRating_Click(object sender, EventArgs e)
        {
            GC.Collect();
            EmployeeRating.EmployeeRating form = new EmployeeRating.EmployeeRating();
            form.connectinString = connectionString;
            form.ShowDialog();

        }

        
    }
}
