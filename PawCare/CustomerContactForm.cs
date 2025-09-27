using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            customerData.Email = EmailtxtBox.Content;

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
