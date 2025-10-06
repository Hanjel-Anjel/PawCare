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
    public partial class ListOfPetsAdmin : Form
    {
        private DataTable? originalTable;
        public ListOfPetsAdmin()
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

            PetTableData.DataSource = view;
        }

        private void ListOfPetsAdmin_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string query = @"
                                    SELECT 
                                    p.PetName,
                                    p.PetType,
                                    p.Breed,
                                    p.Gender,
                                    p.DateOfBirth,
                                    CONCAT(c.FirstName, ' ', c.LastName) AS OwnerName
                                FROM Pet p
                                INNER JOIN Customer c ON p.CustomerID = c.CustomerID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))

                    {
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            originalTable = dataTable;
                            PetTableData.DataSource = dataTable;

                            PetTableData.Columns["PetName"].HeaderText = "Pet Name";
                            PetTableData.Columns["PetType"].HeaderText = "Type";
                            PetTableData.Columns["Breed"].HeaderText = "Breed";
                            PetTableData.Columns["Gender"].HeaderText = "Gender";
                            PetTableData.Columns["DateOfBirth"].HeaderText = "Birth Date";
                            PetTableData.Columns["OwnerName"].HeaderText = "Owner";

                            // Make columns stretch evenly
                            PetTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
                        ColumnSortCbx.Items = new string[]
                        {
                            "OwnerName",
                            "PetName"
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

        private void PetTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void SearchtxtBox_ContentChanged(object sender, EventArgs e)
        {
            string searchText = SearchtxtBox.Content.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText) || originalTable == null)
            {
                // If empty, reset to full table
                PetTableData.DataSource = originalTable;


                return;
            }

            // Use LINQ to filter
            var filteredRows = originalTable.AsEnumerable()
                .Where(row =>
                    (row.Field<string>("PetName") ?? String.Empty).ToLower().Contains(searchText) ||
                    (row.Field<string>("OwnerName") ?? String.Empty).ToLower().Contains(searchText));

            if (filteredRows.Any())
            {
                PetTableData.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                PetTableData.DataSource = null; // or keep old data
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBtn_Click(sender, e);
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
