using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawCare
{
    public partial class CustomerPetForm2 : Form
    {
        private CustomerRegistrationData customerData;
        public CustomerPetForm2(CustomerRegistrationData customerData)
        {
            InitializeComponent();
            this.customerData = customerData;
        }

        private void cuiLabel3_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerPetForm customerPetForm = new CustomerPetForm(customerData);
            customerPetForm.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Connection string to your SQL Server
            string connectionString = @"Server=.\SQLEXPRESS;Database=Groom_Veterinary_Clinic;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO Customer (FirstName, MiddleName, LastName, Suffix)
                             VALUES (@FirstName, @MiddleName, @LastName, @Suffix)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customerData.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrEmpty(customerData.MiddleName) ? (object)DBNull.Value : customerData.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", customerData.LastName);
                        cmd.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(customerData.Suffix) ? (object)DBNull.Value : customerData.Suffix);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer info saved successfully!");

                    EmployeeDashboard employeeDashboard = new EmployeeDashboard();
                    employeeDashboard.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving customer: " + ex.Message);
                }
            }

        }
    }
}
