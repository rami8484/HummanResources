using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RamiProj.Salaries
{
    public partial class SalaryMainWindow : Form
    {
        public string connectionString;
        public SalaryMainWindow()
        {
            InitializeComponent();
        }

        private void buttonFixedSalary_Click(object sender, EventArgs e)
        {
            GC.Collect();
            FixedSalary form = new FixedSalary();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void buttonPaymentInfo_Click(object sender, EventArgs e)
        {
            GC.Collect();
            PaymentInfo form = new PaymentInfo();
            form.connectionString = connectionString;
            form.ShowDialog();
        }

        private void SalaryMainWindow_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
