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
        public CustomerPetForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerContactForm customerContactForm = new CustomerContactForm();
            customerContactForm.Show();
            this.Hide();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CustomerPetForm2 customerPetForm2 = new CustomerPetForm2();
            customerPetForm2.Show();
            this.Hide();
        }
    }
}
