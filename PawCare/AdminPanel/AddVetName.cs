using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawCare.AdminPanel
{
    public partial class AddVetName : Form
    {
        public AddCustomerData customerData;
        public AddVetName()
        {
            InitializeComponent();
            customerData = new AddCustomerData();
        }

        public AddVetName(AddCustomerData Data)
        {
            InitializeComponent();
            customerData = Data;
        }

        private void AddVeterinarian_Load(object sender, EventArgs e)
        {
            suffixCbox.Items = new string[] { "Jr.", "Sr.", "II", "III", "IV", "V" };

            if (!string.IsNullOrEmpty(customerData.FirstName))
                FnametxtBox.Content = customerData.FirstName;
            if (!string.IsNullOrEmpty(customerData.MiddleName))
                MnametxtBox.Content = customerData.MiddleName;
            if (!string.IsNullOrEmpty(customerData.LastName))
                LnametxtBox.Content = customerData.LastName;
            if (!string.IsNullOrEmpty(customerData.Suffix))
                suffixCbox.SelectedItem = customerData.Suffix;
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

        private void suffixCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            customerData.FirstName = FnametxtBox.Content?.Trim();
            customerData.MiddleName = MnametxtBox.Content?.Trim();
            customerData.LastName = LnametxtBox.Content?.Trim();

            if (string.IsNullOrWhiteSpace(customerData.FirstName))
            {
                MessageBox.Show("Please input First Name.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FnametxtBox.Focus();
                return;
            }
            else if (!Regex.IsMatch(customerData.FirstName, @"^[A-Za-z\s]{1,50}$"))
            {
                MessageBox.Show("First Name must contain only letters.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FnametxtBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(customerData.MiddleName))
            {
                MessageBox.Show("Please input Middle Name.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MnametxtBox.Focus();
                return;
            }
            else if (!Regex.IsMatch(customerData.MiddleName, @"^[A-Za-z\s]{1,50}$"))
            {
                MessageBox.Show("Middle Name must contain only letters.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MnametxtBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(customerData.LastName))
            {
                MessageBox.Show("Please input Last Name.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LnametxtBox.Focus();
                return;
            }
            else if (!Regex.IsMatch(customerData.LastName, @"^[A-Za-z\s]{1,50}$"))
            {
                MessageBox.Show("Last Name must contain only letters.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LnametxtBox.Focus();
                return;
            }
            customerData.Suffix = suffixCbox.SelectedItem?.ToString() ?? string.Empty;

            AddVetInfo addVetInfo = new AddVetInfo(customerData);
            addVetInfo.Show();
            this.Hide();

        }
    }
}
