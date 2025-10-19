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
    public partial class ListOfService : Form
    {
        private DataTable? originalTable;
        public ListOfService()
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

            ServiceTableData.DataSource = view;
        }

        private void ListOfService_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT ServiceName, Description, Price FROM Service";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))

                    {
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            originalTable = dataTable;
                            ServiceTableData.DataSource = dataTable;


                            ServiceTableData.Columns["ServiceName"].HeaderText = "Service name";
                            ServiceTableData.Columns["Description"].HeaderText = "Description";
                            ServiceTableData.Columns["Price"].HeaderText = "Price";


                            // Make columns stretch evenly
                            ServiceTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
                        ColumnSortCbx.Items = new string[]
                        {
                           "ServiceName",
                            "Description",
                            "Price"
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


        // Apply search filter
        private void ApplySearch()
        {
            string searchText = SearchtxtBox.Content.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText) || originalTable == null)
            {
                ServiceTableData.DataSource = originalTable;
                return;
            }

            var filteredRows = originalTable.AsEnumerable()
                .Where(row =>
                    (row.Field<string>("ServiceName") ?? "").ToLower().Contains(searchText) ||
                    (row.Field<string>("Description") ?? "").ToLower().Contains(searchText));

            if (filteredRows.Any())
            {
                ServiceTableData.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                ServiceTableData.DataSource = null; // or keep old data
            }
        }

        private void SearchtxtBox_ContentChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ApplySearch();
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

        private void ServiceTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
