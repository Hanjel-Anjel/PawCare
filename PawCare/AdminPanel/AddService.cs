using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace PawCare.AdminPanel
{
    public partial class AddService : Form
    {
        private AddCustomerData customerData;
        public AddService(AddCustomerData customerData)
        {
            InitializeComponent();
            this.customerData = customerData;
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
              customerData.ServiceName = ServiceNametxtBox.Content;
              customerData.Description = DescriptiontxtBox.Content;
              customerData.Price = decimal.TryParse(PricetxtBox.Content, out decimal price) ? price : (decimal?)null;

            // Connection string to your SQL Server
            string connectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

           using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Service Query 
                    string insertServiceQuery = @"INSERT INTO Service (ServiceName, Description, Price) 
                         VALUES (@ServiceName, @Description, @Price)";

                    using (SqlCommand cmd = new SqlCommand(insertServiceQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ServiceName", customerData.ServiceName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", customerData.Description ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Price", customerData.Price ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();
                    ServiceNametxtBox.Content = string.Empty;
                    DescriptiontxtBox.Content = string.Empty;
                    PricetxtBox.Content = string.Empty;

                    customerData.ServiceName = string.Empty;
                    customerData.Description = string.Empty;
                    customerData.Price = null;

                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void ServiceNametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void DescriptiontxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PricetxtBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
