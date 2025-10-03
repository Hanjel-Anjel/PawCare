using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
            customerData.ServiceType = TypeServiceCbx.SelectedItem.ToString() ?? string.Empty;
            customerData.Weight = WeighttxtBox.Content;
            customerData.AssignedVet = VetCbx.SelectedItem.ToString() ?? string.Empty;

            // Connection string to your SQL Server
            string connectionString = @"Server=LAPTOP-AQ32RS4T;Database=Groom_Veterinary_Clinic;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

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

                    // Customer Query 
                    int newCustomerId;
                    using (SqlCommand cmd = new SqlCommand(insertCustomerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customerData.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrEmpty(customerData.MiddleName) ? (object)DBNull.Value : customerData.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", customerData.LastName);
                        cmd.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(customerData.Suffix) ? (object)DBNull.Value : customerData.Suffix);
                        cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(customerData.ContactNumber) ? (object)DBNull.Value : customerData.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(customerData.Email) ? (object)DBNull.Value : customerData.Email);

                        newCustomerId = (int)cmd.ExecuteScalar();
                    }

                    // Customer Address Query 
                    string insertAddressQuery = @"
                        INSERT INTO CustomerAddress (CustomerID, Region, MunicipalityCity, Barangay, HouseNo, LotBlock)
                        VALUES (@CustomerID, @Region, @City, @Barangay, @HouseNo, @LotBlock)";
                    // Customer Address Query 
                    using (SqlCommand cmd = new SqlCommand(insertAddressQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", newCustomerId);
                        cmd.Parameters.AddWithValue("@Region", customerData.Region ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@City", customerData.MunicipalityCity ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Barangay", customerData.Barangay ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@HouseNo", customerData.HouseNo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@LotBlock", customerData.LotBlock ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    // Pet Query
                    int newPetId;
                    string insertPetQuery = @"
                        INSERT INTO Pet (CustomerID, PetName, PetType, Breed, Gender, DateOfBirth)
                        OUTPUT INSERTED.PetID
                        VALUES (@CustomerID, @PetName, @PetType, @Breed, @Gender, @DateOfBirth)";

                    using (SqlCommand cmd = new SqlCommand(insertPetQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", newCustomerId);
                        cmd.Parameters.AddWithValue("@PetName", customerData.PetName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@PetType", customerData.PetType ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Breed", customerData.Breed ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", customerData.Gender ?? (object)DBNull.Value);

                        if (customerData.DateOfBirth.HasValue)
                            cmd.Parameters.AddWithValue("@DateOfBirth", customerData.DateOfBirth.Value);
                        else
                            cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);

                        newPetId = (int)cmd.ExecuteScalar();
                    }

                    // Service Record Query
                    string insertServiceQuery = @"
                        INSERT INTO ServiceRecord (PetID, ServiceType, Weight, AssignedVeterinarian)
                        VALUES (@PetID, @ServiceType, @Weight, @AssignedVet)";

                    using (SqlCommand cmd = new SqlCommand(insertServiceQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@PetID", newPetId);
                        cmd.Parameters.AddWithValue("@ServiceType", string.IsNullOrEmpty(customerData.ServiceType) ? (object)DBNull.Value : customerData.ServiceType);
                        cmd.Parameters.AddWithValue("@Weight", string.IsNullOrEmpty(customerData.Weight) ? (object)DBNull.Value : customerData.Weight);
                        cmd.Parameters.AddWithValue("@AssignedVet", string.IsNullOrEmpty(customerData.AssignedVet) ? (object)DBNull.Value : customerData.AssignedVet);

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

                    customerData.PetName = null;
                    customerData.PetType = null;
                    customerData.Breed = null;
                    customerData.Gender = null;
                    customerData.DateOfBirth = null;

                    customerData.ServiceType = null;
                    customerData.Weight = null;
                    customerData.AssignedVet = null;


                    EmployeeDashboard employeeDashboard = new EmployeeDashboard();
                    employeeDashboard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving customer: " + ex.Message);
                }
            }

        }

        private void CustomerPetForm2_Load(object sender, EventArgs e)
        {
            TypeServiceCbx.Items = new string[] { "Grooming", "Vaccination", "Treatment", "Check-up" };
            VetCbx.Items = new string[] { "Armario", "Maco", "Asierto", "Manzanero" };
        }

        private void TypeServiceCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PetPicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PetPicBox.Image = Image.FromFile(ofd.FileName); // works only if PetPicBox is a PictureBox
                PetPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

