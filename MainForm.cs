using System;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void btnOpenCustomerForm_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.Show();
        }

        private void btnOpenComplaintForm_Click(object sender, EventArgs e)
        {
            Complaint complaintForm = new Complaint();
            complaintForm.Show();
        }
    }
}
