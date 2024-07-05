using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class Complaint : Form
    {
        public Complaint()
        {
            InitializeComponent();
        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            LoadComplaints();
        }

   

      

        private void btnView_Click_1(object sender, EventArgs e)
        {
            LoadComplaints();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = @"data source=SHAMPY\SQLEXPRESS2016;Database=CMS;integrated security=true";
                con.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Complaint (CustomerID, Name, MobileNumber, Description, DateTime, Status) VALUES (@CustomerID, @Name, @MobileNumber, @Description, @DateTime, @Status)";
                cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@DateTime", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@Status", "Pending");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Complaint added successfully!");
                LoadComplaints();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = @"data source=SHAMPY\SQLEXPRESS2016;Database=CMS;integrated security=true";
                con.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Complaint SET Status = @Status WHERE ComplaintID = @ComplaintID";
                cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                cmd.Parameters.AddWithValue("@ComplaintID", int.Parse(txtComplaintID.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Complaint status updated successfully!");
                LoadComplaints();
            }
        }

        private void LoadComplaints()
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = @"data source=SHAMPY\SQLEXPRESS2016;Database=CMS;integrated security=true";
                con.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Complaint";
                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
                da.SelectCommand = cmd;
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                this.dgvComplaints.DataSource = dt;
            }
        }
    }
}
