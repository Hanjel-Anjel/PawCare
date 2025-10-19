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
    public partial class AddPetInformation : Form
    {
        private AddCustomerData customerData;

        // Helper list to store ServiceIDs
        private List<int> _serviceIds = new List<int>();

        // Helper list to store VeterinarianIDs
        private List<int> _vetIds = new List<int>();

        public AddPetInformation(AddCustomerData customerData)
        {
            InitializeComponent();
            this.customerData = customerData;
        }

        private void AddPetInformation_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // ------------------ LOAD SERVICES ------------------
                    string query = "SELECT ServiceID, ServiceName FROM Service";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<string> serviceNames = new List<string>();
                        _serviceIds.Clear();

                        while (reader.Read())
                        {
                            serviceNames.Add(reader["ServiceName"].ToString());
                            _serviceIds.Add(Convert.ToInt32(reader["ServiceID"]));
                        }

                        TypeServiceCbx.Items = serviceNames.ToArray();
                    }

                    // ------------------ LOAD VETERINARIANS ------------------
                    string vetQuery = "SELECT VeterinarianID, LastName FROM Veterinarian";

                    using (SqlCommand vetCmd = new SqlCommand(vetQuery, conn))
                    using (SqlDataReader vetReader = vetCmd.ExecuteReader())
                    {
                        List<string> vetNames = new List<string>();
                        _vetIds.Clear();

                        while (vetReader.Read())
                        {
                            vetNames.Add(vetReader["LastName"].ToString());
                            _vetIds.Add(Convert.ToInt32(vetReader["VeterinarianID"]));
                        }

                        VetCbx.Items = vetNames.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services or veterinarians: " + ex.Message);
                }
            }
        }

        private void TypeServiceCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WeighttxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void VetCbx_SelectedIndexChanged(object sender, EventArgs e)
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            customerData.ServiceType = TypeServiceCbx.SelectedItem?.ToString() ?? string.Empty;
            customerData.Weight = WeighttxtBox.Content;
            customerData.AssignedVet = VetCbx.SelectedItem?.ToString() ?? string.Empty;

            //Connection string to your SQL Server
            string connectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // ------------------ 1. INSERT PET ------------------
                    string insertPetQuery = @"
                        INSERT INTO Pet (CustomerID, PetName, PetType, Breed, Gender, DateOfBirth)
                        OUTPUT INSERTED.PetID
                        VALUES (@CustomerID, @PetName, @PetType, @Breed, @Gender, @DateOfBirth)";

                    int newPetId;
                    using (SqlCommand cmd = new SqlCommand(insertPetQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerData.CustomerID);
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

                    // ------------------ 2. INSERT SERVICE RECORD ------------------
                    string insertServiceQuery = @"
                        INSERT INTO ServiceRecord (PetID, ServiceTypeID, VeterinarianID, Weight, Picture)
                        VALUES (@PetID, @ServiceTypeID, @VeterinarianID, @Weight, @Picture)";

                    using (SqlCommand cmd2 = new SqlCommand(insertServiceQuery, conn))
                    {
                        cmd2.Parameters.AddWithValue("@PetID", newPetId);
                        cmd2.Parameters.AddWithValue("@ServiceTypeID", _serviceIds[TypeServiceCbx.SelectedIndex]);
                        cmd2.Parameters.AddWithValue("@VeterinarianID", _vetIds[VetCbx.SelectedIndex]);
                        cmd2.Parameters.AddWithValue("@Weight", customerData.Weight ?? (object)DBNull.Value);

                        // Handle picture
                        if (PetPicBox.Image != null)
                        {
                            using (var ms = new System.IO.MemoryStream())
                            {
                                PetPicBox.Image.Save(ms, PetPicBox.Image.RawFormat);
                                cmd2.Parameters.AddWithValue("@Picture", ms.ToArray());
                            }
                        }
                        else
                            cmd2.Parameters.AddWithValue("@Picture", DBNull.Value);

                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pet and Service Record saved successfully!");



                    customerData.CustomerID = 0;
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

                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddPetName addPetName = new AddPetName(customerData);
            addPetName.Show();
            this.Hide();
        }
    }
}
