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
            string connStr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            c.CustomerID,
                            CONCAT(
                                COALESCE(c.FirstName, ''), ' ',
                                COALESCE(c.MiddleName, ''), ' ',
                                COALESCE(c.LastName, ''), ' ',
                                COALESCE(c.Suffix, '')
                            ) AS FullName,
                            c.FirstName,
                            c.MiddleName,
                            c.LastName,
                            c.Suffix,
                            c.ContactNumber,
                            c.Email,
                            
                            CONCAT(
                                COALESCE(ca.HouseNo, ''), ' ',
                                COALESCE(ca.LotBlock, ''), ' ',
                                COALESCE(ca.Barangay, ''), ', ',
                                COALESCE(ca.MunicipalityCity, ''), ', ',
                                COALESCE(ca.Region, '')
                            ) AS FullAddress,
                            c.Created_At
                        FROM Customer c
                        LEFT JOIN CustomerAddress ca
                            ON c.CustomerID = ca.CustomerID";



                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))

                    {
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            originalTable = dataTable;
                            CustomerTableData.DataSource = dataTable;

                            CustomerTableData.Columns["FullName"].HeaderText = "Customer Name";
                            CustomerTableData.Columns["Suffix"].HeaderText = "Suffix";
                            CustomerTableData.Columns["ContactNumber"].HeaderText = "Contact No.";
                            CustomerTableData.Columns["FullAddress"].HeaderText = "Address";
                            CustomerTableData.Columns["Email"].HeaderText = "Email Address";
                            CustomerTableData.Columns["Created_At"].HeaderText = "Date Created";

                            CustomerTableData.Columns["FirstName"].Visible = false;
                            CustomerTableData.Columns["MiddleName"].Visible = false;
                            CustomerTableData.Columns["LastName"].Visible = false;
                            CustomerTableData.Columns["Suffix"].Visible = false;
                            CustomerTableData.Columns["CustomerID"].Visible = false;


                            // Make columns stretch evenly
                            CustomerTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            CustomerTableData.Columns["FullAddress"].FillWeight = 250;
                            CustomerTableData.Columns["FullName"].FillWeight = 150;
                            CustomerTableData.Columns["Email"].FillWeight = 150;
                            CustomerTableData.Columns["ContactNumber"].FillWeight = 100;
                            CustomerTableData.Columns["Created_At"].FillWeight = 100;
                        }
                        ColumnSortCbx.Items = new string[]
                        {
                            "FullName"
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

        private void CustomerTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
