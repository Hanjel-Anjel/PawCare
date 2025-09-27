using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PawCare
{
    public partial class CustomerNameForm : Form
    {

        string connectionString = @"Server=.\SQLEXPRESS;Database=Groom_Veterinary_Clinic;Trusted_Connection=True;";

        public CustomerNameForm()
        {
            InitializeComponent();
        }

        private void suffixCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameForm_Load(object sender, EventArgs e)
        {
            suffixCbox.Items = new string[] { "Jr.", "Sr.", "I", "II", "III", "IV", "V" };
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            employeeDashboard.Show();
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            // Collect values from your form controls
            string firstName = FnametxtBox.Content.Trim();
            string middleName = MnametxtBox.Content.Trim();
            string lastName = LnametxtBox.Content.Trim();
            string suffix = suffixCbox.SelectedItem?.ToString();

            // Database connection string
            string connectionString = @"Server=.\SQLEXPRESS;Database=Groom_Veterinary_Clinic;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Customer (FirstName, MiddleName, LastName, Suffix) " +
                                   "VALUES (@FirstName, @MiddleName, @LastName, @Suffix)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(suffix) ? (object)DBNull.Value : suffix);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer saved successfully!");

                    // Proceed to Address Form
                    CustomerAddressForm addressForm = new CustomerAddressForm();
                    addressForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            
        }

        private void FnametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void MnametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void LnametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
