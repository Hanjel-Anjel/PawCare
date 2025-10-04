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
    public partial class AddPetOwnerName : Form
    {
        private AddCustomerData? selectedCustomer;

        private DataTable? originalTable;
        public AddPetOwnerName(AddCustomerData customerData)
        {
            InitializeComponent();
            selectedCustomer = customerData;
        }

        public AddPetOwnerName()
        {
            InitializeComponent();
            selectedCustomer = new AddCustomerData();
        }

        private void AddPetOwnerName_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCustomer?.FirstName))
                FnametxtBox.Content = selectedCustomer.FirstName;
            if (!string.IsNullOrEmpty(selectedCustomer?.MiddleName))
                MnametxtBox.Content = selectedCustomer.MiddleName;
            if (!string.IsNullOrEmpty(selectedCustomer?.LastName))
                LnametxtBox.Content = selectedCustomer.LastName;

            string connStr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string query = @"
                        SELECT CustomerID, FirstName, 
                               MiddleName, 
                               LastName, 
                               Suffix FROM Customer";



                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))

                    {
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            originalTable = dataTable;
                            CustomerTableData.DataSource = dataTable;

                            CustomerTableData.Columns["CustomerID"].HeaderText = "Customer ID";
                            CustomerTableData.Columns["FirstName"].HeaderText = "First name";
                            CustomerTableData.Columns["MiddleName"].HeaderText = "Middle name";
                            CustomerTableData.Columns["LastName"].HeaderText = "Last name";
                            CustomerTableData.Columns["Suffix"].HeaderText = "Suffix";

                            //CustomerTableData.Columns["FirstName"].Visible = false;
                            //CustomerTableData.Columns["MiddleName"].Visible = false;
                            //CustomerTableData.Columns["LastName"].Visible = false;
                            //CustomerTableData.Columns["Suffix"].Visible = false;
                            //CustomerTableData.Columns["CustomerID"].Visible = false;


                            // Make columns stretch evenly
                            CustomerTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //CustomerTableData.Columns["FullAddress"].FillWeight = 250;
                            //CustomerTableData.Columns["FullName"].FillWeight = 150;
                            //CustomerTableData.Columns["Email"].FillWeight = 150;
                            //CustomerTableData.Columns["ContactNumber"].FillWeight = 100;
                            //CustomerTableData.Columns["Created_At"].FillWeight = 100;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void SearchtxtBox_ContentChanged(object sender, EventArgs e)
        {
            SearchBtn_Click(sender, e);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = SearchtxtBox.Content.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText) || originalTable == null)
            {
                // If empty, reset to full table
                CustomerTableData.DataSource = originalTable;
                return;
            }

            // Use LINQ to filter
            var filteredRows = originalTable.AsEnumerable()
                .Where(row =>
                    (row.Field<string>("FirstName") ?? String.Empty).ToLower().Contains(searchText) ||
                    (row.Field<string>("LastName") ?? String.Empty).ToLower().Contains(searchText));

            if (filteredRows.Any())
            {
                CustomerTableData.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                CustomerTableData.DataSource = null; // or keep old data
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            AddPetName addPetName = new AddPetName(selectedCustomer);
            addPetName.Show();
            this.Close();



        }

        private void CustomerTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // Ignore header clicks

            DataGridViewRow selectedRow = CustomerTableData.Rows[e.RowIndex];

            selectedCustomer = new AddCustomerData
            {
                CustomerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value),
                FirstName = selectedRow.Cells["FirstName"].Value?.ToString() ?? "",
                MiddleName = selectedRow.Cells["MiddleName"].Value?.ToString() ?? "",
                LastName = selectedRow.Cells["LastName"].Value?.ToString() ?? "",
                Suffix = selectedRow.Cells["Suffix"].Value?.ToString() ?? ""
            };

            FnametxtBox.Content = selectedRow.Cells["FirstName"].Value?.ToString() ?? "";
            MnametxtBox.Content = selectedRow.Cells["MiddleName"].Value?.ToString() ?? "";
            LnametxtBox.Content = selectedRow.Cells["LastName"].Value?.ToString() ?? "";

        }
    
    }
}
