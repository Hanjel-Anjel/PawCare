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

            if (!Regex.IsMatch(customerData.ContactNumber, @"^\d{11}$"))
            {
                MessageBox.Show("❌ Invalid contact number! It must be exactly 11 digits.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            customerData.Email = EmailtxtBox.Content;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(customerData.Email, pattern))
            {
                MessageBox.Show("❌ Invalid email address! Please enter a valid email.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ContactNumbertxtBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
