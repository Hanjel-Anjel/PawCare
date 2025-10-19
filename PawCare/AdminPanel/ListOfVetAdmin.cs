using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace PawCare.AdminPanel
{
    public partial class ListOfVetAdmin : Form
    {
        private DataTable? originalTable;
        public ListOfVetAdmin()
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

            VetTableData.DataSource = view;
        }

        private void ListOfVetAdmin_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT FirstName, MiddleName, LastName, Suffix,
                                    ContactNumber, Email, Specialization FROM Veterinarian";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))

                    {
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            originalTable = dataTable;
                            VetTableData.DataSource = dataTable;


                            VetTableData.Columns["FirstName"].HeaderText = "First name ";
                            VetTableData.Columns["MiddleName"].HeaderText = "Middle name";
                            VetTableData.Columns["LastName"].HeaderText = "Last name";
                            VetTableData.Columns["Suffix"].HeaderText = "Suffix";
                            VetTableData.Columns["ContactNumber"].HeaderText = "Contact number";
                            VetTableData.Columns["Email"].HeaderText = "Email";
                            VetTableData.Columns["Specialization"].HeaderText = "Specialization";

                            // Make columns stretch evenly
                            VetTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void ServiceTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ApplySearch();

        }

        private void SearchtxtBox_ContentChanged(object sender, EventArgs e)
        {
            ApplySearch();

        }

        private void ApplySearch()
        {
            string searchText = SearchtxtBox.Content.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText) || originalTable == null)
            {
                VetTableData.DataSource = originalTable;
                return;
            }

            var filteredRows = originalTable.AsEnumerable()
                .Where(row =>
                    (row.Field<string>("FirstName") ?? "").ToLower().Contains(searchText) ||
                    (row.Field<string>("LastName") ?? "").ToLower().Contains(searchText));

            VetTableData.DataSource = filteredRows.Any() ? filteredRows.CopyToDataTable() : null;
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
        

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void VetTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
