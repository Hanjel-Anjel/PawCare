using System;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PawCare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=localhost\SQLEXPRESS;Database=Groom_Veterinary_Clinic;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

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
                            MessageBox.Show("Invalid Email or Password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UsernameTextbox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void usernameLabel_Load(object sender, EventArgs e)
        {

        }
    }

}
