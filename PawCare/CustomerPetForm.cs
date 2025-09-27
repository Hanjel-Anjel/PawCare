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
    public partial class CustomerPetForm : Form
    {
        private CustomerRegistrationData customerData;
        public CustomerPetForm(CustomerRegistrationData customerData)
        {
            InitializeComponent();
            this.customerData = customerData;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerContactForm customerContactForm = new CustomerContactForm(customerData);
            customerContactForm.Show();
            this.Hide();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CustomerPetForm2 customerPetForm2 = new CustomerPetForm2(customerData);
            customerPetForm2.Show();
            this.Hide();
        }
    }
}
