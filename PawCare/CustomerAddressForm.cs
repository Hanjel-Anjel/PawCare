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
    public partial class CustomerAddressForm : Form
    {
        private CustomerRegistrationData customerData;
        public CustomerAddressForm(CustomerRegistrationData data)
        {
            InitializeComponent();
            customerData = data;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CustomerContactForm customerContactForm = new CustomerContactForm(customerData);
            customerContactForm.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerNameForm customerNameForm = new CustomerNameForm();
            customerNameForm.Show();
            this.Hide();
        }
    }
}
