using System;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;



namespace PawCare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        //login form load
        private void Login_Load(object sender, EventArgs e)
        {

        }
        //login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
           

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    string email = UsernameTextbox.Content;   
                    string password = PasswordTextbox.Content;


                    string query = "SELECT COUNT(*) FROM UserAccount WHERE Email = @Email AND Password = @Password";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!");
                            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
                            employeeDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //username textbox
        private void UsernameTextbox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            AdminPanel.AdminDashboard adminDashboard = new AdminPanel.AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        //username label
        private void usernameLabel_Load(object sender, EventArgs e)
        {

        }
        //show password checkbox
        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckbox.Checked)
            {
                // Show the password
                PasswordTextbox.PasswordChar = false;
            }
            else
            {
                // Hide the password
                PasswordTextbox.PasswordChar = true;
            }
        }
        //password textbox
        private void PasswordTextbox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiPictureBox1_Load(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Load(object sender, EventArgs e)
        {

        }
    }

}
