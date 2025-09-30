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

namespace PawCare.AdminPanel
{
    public partial class ListOfOwnerAdmin : Form
    {
        private DataTable? originalTable;
        public ListOfOwnerAdmin()
        {
            InitializeComponent();
        }
        private void SortData()
        {

            if (originalTable == null || originalTable.Rows.Count == 0)
                return;


            if (ColumnSortCbx.SelectedItem == null || SortCbx.SelectedItem == null)
                return;

            string selectedColumn = ColumnSortCbx.SelectedItem.ToString();
            string selectedDirection = SortCbx.SelectedItem.ToString();

            DataView view = new DataView(originalTable);

            if (selectedDirection == "A-Z")
            {
                view.Sort = $"{selectedColumn} ASC";
            }
            else
            {
                view.Sort = $"{selectedColumn} DESC";
            }

            CustomerTableData.DataSource = view;
        }

        private void ListOfOwnerAdmin_Load(object sender, EventArgs e)
        {

            string connStr = @"Server=localhost\SQLEXPRESS;Database=Groom_Veterinary_Clinic;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string query = "SELECT FirstName, MiddleName, LastName, Suffix, ContactNumber, Email, Created_At FROM Customer";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))

                    {
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            originalTable = dataTable;
                            CustomerTableData.DataSource = dataTable;

                            CustomerTableData.Columns["FirstName"].HeaderText = "First Name";
                            CustomerTableData.Columns["MiddleName"].HeaderText = "Middle Name";
                            CustomerTableData.Columns["LastName"].HeaderText = "Last Name";
                            CustomerTableData.Columns["Suffix"].HeaderText = "Suffix";
                            CustomerTableData.Columns["ContactNumber"].HeaderText = "Contact No.";
                            CustomerTableData.Columns["Email"].HeaderText = "Email Address";
                            CustomerTableData.Columns["Created_At"].HeaderText = "Date Created";

                            // Make columns stretch evenly
                            CustomerTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
                        ColumnSortCbx.Items = new string[]
                        {
                            "FirstName",
                            "MiddleName",
                            "LastName"
                        };

                        SortCbx.Items = new string[] { "A-Z", "Z-A" };
                        //SortCbx.SelectedItem = SortCbx.Items[0];
                        SortCbx.Enabled = false;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
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

        private void ColumnSortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColumnSortCbx.SelectedIndex == -1)
            {
                SortCbx.Enabled = false;
                SortCbx.SelectedItem = null;
                return;
            }

            SortCbx.Enabled = true;
            SortData();

        }

        private void SortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SortCbx.Enabled || ColumnSortCbx.SelectedIndex == -1)
                return;

            SortData();
        }
    }
}
