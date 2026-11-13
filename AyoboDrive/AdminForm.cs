using System;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void addNewPackageButton_Click(object sender, EventArgs e)
        {
            NewPackage newPackage = new NewPackage();
            newPackage.Show();
            this.Hide();
        }

        private void addNewVehicleButton_Click(object sender, EventArgs e)
        {
            NewVehicle newVehicle = new NewVehicle();
            newVehicle.Show();
            this.Hide();
        }

        private void addNewDriveButton_Click(object sender, EventArgs e)
        {
            NewDriver newDriver = new NewDriver();
            newDriver.Show();
            this.Hide();
        }

        private void rentHireButton_Click(object sender, EventArgs e)
        {
            VehicleRentForm vehicleRentForm = new VehicleRentForm();
            vehicleRentForm.Show();
            vehicleRentForm.adminFormFalse = true;
            this.Hide();
        }
    }
}