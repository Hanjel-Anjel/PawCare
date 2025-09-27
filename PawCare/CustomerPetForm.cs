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
            customerData.PetName = PetNametxtBox.Content;
            customerData.PetType = TypePettxtBox.SelectedItem.ToString() ?? string.Empty;
            customerData.Breed = BreedtxtBox.Content;
            customerData.Gender = PetGendertxtBox.SelectedItem.ToString() ?? string.Empty;
            customerData.DateOfBirth = BdayDatepicker.Content;

            CustomerPetForm2 customerPetForm2 = new CustomerPetForm2(customerData);
            customerPetForm2.Show();
            this.Hide();
        }

        private void CustomerPetForm_Load(object sender, EventArgs e)
        {
            TypePettxtBox.Items = new string[] { "Cat", "Dog" };
            PetGendertxtBox.Items = new string[] { "Male", "Female" };

        }

        private void TypePettxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void PetGendertxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BdayDatepicker_Load(object sender, EventArgs e)
        {

        }

        private void PetNametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void BreedtxtBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
