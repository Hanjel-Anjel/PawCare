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
    public partial class AddCustomerContact : Form
    {
        private AddCustomerData customerData;
        public AddCustomerContact(AddCustomerData customerData)
        {
            InitializeComponent();
            this.customerData = customerData;
        }

        private void AddCustomerContact_Load(object sender, EventArgs e)
        {

        }

        private void ContactNumbertxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void EmailtxtBox_ContentChanged(object sender, EventArgs e)
        {


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddCustomerAddress addCustomerAddress = new AddCustomerAddress(customerData);
            addCustomerAddress.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
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

            string connectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                { 
                conn.Open();
                    // Customer Query
                    string insertCustomerQuery = @"
                        INSERT INTO Customer (FirstName, MiddleName, LastName, Suffix, ContactNumber, Email)
                        OUTPUT INSERTED.CustomerID
                        VALUES (@FirstName, @MiddleName, @LastName, @Suffix, @ContactNumber, @Email)";

                    int newCustomerId;
                    using (SqlCommand cmd = new SqlCommand(insertCustomerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customerData.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", customerData.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", customerData.LastName);
                        cmd.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(customerData.Suffix) ? (object)DBNull.Value : customerData.Suffix);
                        cmd.Parameters.AddWithValue("@ContactNumber", customerData.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", customerData.Email);
                        newCustomerId = (int)cmd.ExecuteScalar();
                    }

                    // Address Query
                    string insertAddressQuery = @"
                        INSERT INTO CustomerAddress (CustomerID, Region, MunicipalityCity, Barangay, HouseNo, LotBlock)
                        VALUES (@CustomerID, @Region, @MunicipalityCity, @Barangay, @HouseNo, @LotBlock)";
                    using (SqlCommand cmd = new SqlCommand(insertAddressQuery, conn))
                        {
                        cmd.Parameters.AddWithValue("@CustomerID", newCustomerId);
                        cmd.Parameters.AddWithValue("@Region", customerData.Region);
                        cmd.Parameters.AddWithValue("@MunicipalityCity", customerData.MunicipalityCity);
                        cmd.Parameters.AddWithValue("@Barangay", customerData.Barangay);
                        cmd.Parameters.AddWithValue("@HouseNo", customerData.HouseNo);
                        cmd.Parameters.AddWithValue("@LotBlock", string.IsNullOrEmpty(customerData.LotBlock) ? (object)DBNull.Value : customerData.LotBlock);
                        cmd.ExecuteNonQuery();
                        }
                    MessageBox.Show("Customer, address, and Pet saved successfully!");


                    customerData.FirstName = null;
                    customerData.MiddleName = null;
                    customerData.LastName = null;
                    customerData.Suffix = null;

                    customerData.ContactNumber = null;
                    customerData.Email = null;

                    customerData.Region = null;
                    customerData.MunicipalityCity = null;
                    customerData.Barangay = null;
                    customerData.HouseNo = null;
                    customerData.LotBlock = null;

                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error saving customer: " + ex.Message);
                }

            }


        }
    }
}
