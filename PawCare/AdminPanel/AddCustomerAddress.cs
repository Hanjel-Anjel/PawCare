using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawCare.AdminPanel
{
    public partial class AddCustomerAddress : Form
    {
        private AddCustomerData customerData;
        public AddCustomerAddress(AddCustomerData data)
        {
            InitializeComponent();
            customerData = data;
        }

        private void AddCustomerAddress_Load(object sender, EventArgs e)
        {
            RegionCbox.Items = new string[] { "NCR" };

            CityCbox.Items = new string[]
            {
            "Quezon City",
            "Manila",
            "Makati",
            "Pasig",
            "Taguig",
            "Mandaluyong",
            "Caloocan"
            };

            if (!string.IsNullOrEmpty(customerData.Region))
                RegionCbox.SelectedItem = customerData.Region;
            if (!string.IsNullOrEmpty(customerData.MunicipalityCity))
                CityCbox.SelectedItem = customerData.MunicipalityCity;
            if (!string.IsNullOrEmpty(customerData.Barangay))
                BarangayCbox.SelectedItem = customerData.Barangay;
            if (!string.IsNullOrEmpty(customerData.HouseNo))
                HouseNotxtBox.Content = customerData.HouseNo;
            if (!string.IsNullOrEmpty(customerData.LotBlock))
                LotBlocktxtBox.Content = customerData.LotBlock;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            customerData.Region = RegionCbox.SelectedItem?.ToString() ?? string.Empty;
            customerData.MunicipalityCity = CityCbox.SelectedItem?.ToString() ?? string.Empty;
            customerData.Barangay = BarangayCbox.SelectedItem?.ToString() ?? string.Empty;

            customerData.HouseNo = HouseNotxtBox.Content ?? string.Empty;
            customerData.LotBlock = LotBlocktxtBox.Content ?? string.Empty;

            AddCustomerContact addCustomerContact = new AddCustomerContact(customerData);
            addCustomerContact.Show();
            this.Hide();
        }

        private void RegionCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CityCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarangayCbox.Items = null; // Clear old data

            if (CityCbox.SelectedItem == null) return;

            string selectedCity = CityCbox.SelectedItem.ToString();

            switch (selectedCity)
            {
                case "Quezon City":
                    BarangayCbox.Items = new string[]
                    {
                "Barangay Commonwealth",
                "Barangay Batasan Hills",
                "Barangay Fairview"
                    };
                    break;

                case "Manila":
                    BarangayCbox.Items = new string[]
                    {
                "Barangay 1",
                "Barangay 2",
                "Barangay 3"
                    };
                    break;

                case "Makati":
                    BarangayCbox.Items = new string[]
                    {
                "Barangay Bel-Air",
                "Barangay Poblacion",
                "Barangay Guadalupe Nuevo"
                    };
                    break;

                case "Pasig":
                    BarangayCbox.Items = new string[]
                    {
                "Barangay San Miguel",
                "Barangay Rosario",
                "Barangay Manggahan"
                    };
                    break;

                case "Taguig":
                    BarangayCbox.Items = new string[]
                    {
                "Barangay Lower Bicutan",
                "Barangay Upper Bicutan",
                "Barangay Bagumbayan"
                    };
                    break;

                case "Mandaluyong":
                    BarangayCbox.Items = new string[]
                    {
                "Barangay Plainview",
                "Barangay Hulo",
                "Barangay Mauway"
                    };
                    break;
                case "Caloocan":
                    BarangayCbox.Items = new string[]
                    {
                        "Barangay 175",
                        "Barangay 176",
                        "Barangay 177"
                    };
                    break;
            }
        }

        private void BarangayCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HouseNotxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void LotBlocktxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddCustomerName addCustomerName = new AddCustomerName(customerData);
            addCustomerName.Show();
            this.Hide();
        }
    }
}
