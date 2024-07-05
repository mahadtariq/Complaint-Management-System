using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Step 1: Open Connection to the database
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"data source=SHAMPY\SQLEXPRESS2016;Database=CMS;integrated security=true";
            con.Open();

            // Step 2: Create a command object
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Customer (Name, MobileNumber) VALUES (@Name, @MobileNumber)";
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text);
            cmd.ExecuteNonQuery();

            // Close the connection
            con.Close();

            // Inform the user
            MessageBox.Show("Customer added successfully!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Step 1: Open Connection to the database
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"data source=SHAMPY\SQLEXPRESS2016;Database=CMS;integrated security=true";
            con.Open();

            // Step 2: Create a command object
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Customer";
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            da.Dispose();

            // Close the connection
            con.Close();

            // Bind the data to DataGridView
            this.dgvCustomers.DataSource = dt;
        }

    }
}
