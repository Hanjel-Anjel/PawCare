using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace PawCare.AdminPanel
{
    public partial class AddVetInfo : Form
    {
        AddCustomerData customerData;
        public AddVetInfo(AddCustomerData data)
        {
            InitializeComponent();
            customerData = data;
        }

        private void AddVetInfo_Load(object sender, EventArgs e)
        {

        }

        private void ContactNumbertxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void EmailtxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void SpecializationtxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Contact Number Validation
            customerData.ContactNumber = ContactNumbertxtBox.Content;

            if (string.IsNullOrWhiteSpace(customerData.ContactNumber))
            {
                MessageBox.Show("Please input Contact number.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactNumbertxtBox.Focus();
                return;
            }

            if (!Regex.IsMatch(customerData.ContactNumber, @"^\d{11}$"))
            {
                MessageBox.Show("Invalid contact number! It must be exactly 11 digits.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            // Email Validation
            customerData.Email = EmailtxtBox.Content;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(customerData.Email))
            {
                MessageBox.Show("Please input valid Email.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailtxtBox.Focus();
                return;
            }

            if (!Regex.IsMatch(customerData.Email, pattern))
            {
                MessageBox.Show("Invalid email address! Please enter a valid email.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customerData.Specialization = SpecializationtxtBox.Content;
            if (string.IsNullOrWhiteSpace(customerData.Specialization))
            {
                MessageBox.Show("Please input Specialization.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SpecializationtxtBox.Focus();
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Veterinarian (FirstName, MiddleName, LastName, Suffix, ContactNumber, Email, Specialization)
                                           VALUES (@FirstName, @MiddleName, @LastName, @Suffix, @ContactNumber, @Email, @Specialization)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customerData.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrEmpty(customerData.MiddleName) ? (object)DBNull.Value : customerData.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", customerData.LastName);
                        cmd.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(customerData.Suffix) ? (object)DBNull.Value : customerData.Suffix);
                        cmd.Parameters.AddWithValue("@ContactNumber", customerData.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", customerData.Email);
                        cmd.Parameters.AddWithValue("@Specialization", customerData.Specialization);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Veterinarian information saved successfully!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    customerData.FirstName = null;
                    customerData.MiddleName = null;
                    customerData.LastName = null;
                    customerData.Suffix = null;
                    customerData.ContactNumber = null;
                    customerData.Email = null;
                    customerData.Specialization = null;

                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddVetInfo addVetInfo = new AddVetInfo(customerData);
            addVetInfo.Show();
            this.Hide();
        }
    }
}
