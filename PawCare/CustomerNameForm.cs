using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PawCare
{
    public partial class CustomerNameForm : Form
    {
        private CustomerRegistrationData customerData;

        public CustomerNameForm()
        {
            InitializeComponent();
            customerData = new CustomerRegistrationData();
        }

        private void suffixCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameForm_Load(object sender, EventArgs e)
        {
            suffixCbox.Items = new string[] { "Jr.", "Sr.", "I", "II", "III", "IV", "V" };
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            employeeDashboard.Show();
            this.Hide();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
           customerData.FirstName = FnametxtBox.Content;
           customerData.MiddleName = MnametxtBox.Content;
           customerData.LastName = LnametxtBox.Content;
           customerData.Suffix = suffixCbox.SelectedItem?.ToString();

            CustomerAddressForm customerAddressForm = new CustomerAddressForm(customerData);
           customerAddressForm.Show();
           this.Hide();

        }


        private void FnametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void MnametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void LnametxtBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
