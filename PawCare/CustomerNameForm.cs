using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace PawCare
{
    public partial class CustomerNameForm : Form
    {
        private CustomerRegistrationData customerData;

        public CustomerNameForm(CustomerRegistrationData data)
        {
            InitializeComponent();
            customerData = data;
        }

        public CustomerNameForm()
        {
            InitializeComponent();
            customerData = new CustomerRegistrationData();
        }



        private void suffixCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameForm_Load(object sender, EventArgs e)
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            employeeDashboard.Show();
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
            else if (!Regex.IsMatch(customerData.FirstName, @"^[A-Za-z]{1,50}$"))
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
            else if (!Regex.IsMatch(customerData.MiddleName, @"^[A-Za-z]{1,50}$"))
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
            else if (!Regex.IsMatch(customerData.LastName, @"^[A-Za-z]{1,50}$"))
            {
                MessageBox.Show("Last Name must contain only letters.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LnametxtBox.Focus();
                return;
            }
            customerData.Suffix = suffixCbox.SelectedItem?.ToString() ?? string.Empty;

            CustomerAddressForm customerAddressForm = new CustomerAddressForm(customerData);
            customerAddressForm.Show();
            this.Hide();

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
    }
}

