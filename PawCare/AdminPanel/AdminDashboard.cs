using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawCare.AdminPanel
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void PetListBtn_Click(object sender, EventArgs e)
        {
            ListOfPetsAdmin listOfPetsAdmin = new ListOfPetsAdmin();
            listOfPetsAdmin.Show();
            this.Hide();
        }

        private void CustomerListBtn_Click(object sender, EventArgs e)
        {
            ListOfOwnerAdmin listOfOwnerAdmin = new ListOfOwnerAdmin();
            listOfOwnerAdmin.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure to Logout?",
                "Confirm Logout",

                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                PawCare.Login login = new PawCare.Login();
                login.Show();
                this.Hide();
            }
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomerName addCustomerName = new AddCustomerName();
            addCustomerName.Show();
            this.Hide();
        }

        private void AddPetBtn_Click(object sender, EventArgs e)
        {
            AddPetOwnerName addPetOwnerName = new AddPetOwnerName();
            addPetOwnerName.Show();
            this.Hide();
        }
    }
}
