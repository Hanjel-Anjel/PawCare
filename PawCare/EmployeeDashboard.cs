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

        //employee dashboard form load
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

        //employee name label
        private void employeenameLabel_Click(object sender, EventArgs e)
        {

        }

        //add new patient button
        private void addnewpatientBtn_Click(object sender, EventArgs e)
        {
            CustomerNameForm customerNameForm = new CustomerNameForm();
            customerNameForm.Show();
            this.Close();
        }
        //customer list button
        private void customerlistBtn_Click(object sender, EventArgs e)
        {
            ListOfOwner listOfOwner = new ListOfOwner();
            listOfOwner.Show();
            this.Close();
        }
        //pet list button
        private void petlistBtn_Click(object sender, EventArgs e)
        {
            ListOfPets listOfPets = new ListOfPets();
            listOfPets.Show();
            this.Close();
        }
        //veterinarian list button
        private void vetlistBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "This feature is under development.",        // Message
             "Warning",                                   // Title
             MessageBoxButtons.OK,                        // Buttons
             MessageBoxIcon.Warning                       // Icon
            );
        }
        //logout button
        private void logoutBtn_Click_1(object sender, EventArgs e)
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
