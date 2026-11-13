using System;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void rentHireButton_Click(object sender, EventArgs e)
        {
            VehicleRentForm vehicleRentForm = new VehicleRentForm();
            vehicleRentForm.Show();
            vehicleRentForm.userFormFalse = true;
            this.Hide();
        }
    }
}