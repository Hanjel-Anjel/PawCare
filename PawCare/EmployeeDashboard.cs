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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerNameForm customerNameForm = new CustomerNameForm();
            customerNameForm.Show();
            this.Close();
        }

        private void ViewCustomerBtn_Click(object sender, EventArgs e)
        {
            ListOfOwner listOfOwner = new ListOfOwner();
            listOfOwner.Show();
            this.Close();
        }

        private void ViewPetBtn_Click(object sender, EventArgs e)
        {
            ListOfPets listOfPets = new ListOfPets();
            listOfPets.Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure to logout?",
                "Confirm Logout",

                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure to logout?",
             "Confirm Logout",

             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }
    }
}
