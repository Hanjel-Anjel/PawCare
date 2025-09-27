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
    public partial class CustomerPetForm2 : Form
    {
        public CustomerPetForm2()
        {
            InitializeComponent();
        }

        private void cuiLabel3_Load(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerPetForm customerPetForm = new CustomerPetForm();
            customerPetForm.Show();
            this.Hide();
        }
    }
}
