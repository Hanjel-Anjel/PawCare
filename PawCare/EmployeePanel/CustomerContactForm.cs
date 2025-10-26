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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PawCare.EmployeePanel;

namespace PawCare
{
    public partial class CustomerContactForm : Form
    {
        private CustomerRegistrationData customerData;
        public CustomerContactForm(CustomerRegistrationData customerData)
        {
            InitializeComponent();
            this.customerData = customerData;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            customerData.ContactNumber = ContactNumbertxtBox.Content;

            if (string.IsNullOrWhiteSpace(customerData.ContactNumber))
            {
                MessageBox.Show("Please input Contact number.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactNumbertxtBox.Focus();
                return;
            }

            if (!Regex.IsMatch(customerData.ContactNumber, @"^\d{11}$"))
            {
                MessageBox.Show("Invalid contact number! It must be exactly 11 digits.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            customerData.Email = EmailtxtBox.Content;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(customerData.Email))
            {
                MessageBox.Show("Please input valid Email.",
                                "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailtxtBox.Focus();
                return;
            }

            if (!Regex.IsMatch(customerData.Email, pattern))
            {
                MessageBox.Show("Invalid email address! Please enter a valid email.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerPetForm customerPetForm = new CustomerPetForm(customerData);
            customerPetForm.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerAddressForm customerAddressForm = new CustomerAddressForm(customerData);
            customerAddressForm.Show();
            this.Hide();
        }

        //contact number textbox
        private void ContactNumbertxtBox_ContentChanged(object sender, EventArgs e)
        {
           
        }


        private void CustomerContactForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(customerData.ContactNumber))
                ContactNumbertxtBox.Content = customerData.ContactNumber;
            if (!string.IsNullOrEmpty(customerData.Email))
                EmailtxtBox.Content = customerData.Email;
        }
    }
}
