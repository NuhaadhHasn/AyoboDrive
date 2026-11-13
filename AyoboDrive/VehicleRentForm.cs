using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class VehicleRentForm : Form
    {
        public bool userFormFalse;
        public bool adminFormFalse;

        private void VehicleRentForm_Shown(object sender, EventArgs e)
        {
            checkGotUserLabel.Text = userFormFalse.ToString();
            label1.Text = adminFormFalse.ToString();
        }

        public VehicleRentForm()
        {
            InitializeComponent();
        }

        private void rentCalcButton_Click(object sender, EventArgs e)
        {
            RentCalculationForm rentCalculationForm = new RentCalculationForm();
            rentCalculationForm.Show();
            if (adminFormFalse == true || adminOrUserLabel.Text == "ADMIN")
            {
                rentCalculationForm.adminOrUserLabel.Text = "ADMIN";
            }
            else if (userFormFalse == true || adminOrUserLabel.Text == "USER")
            {
                rentCalculationForm.adminOrUserLabel.Text = "USER";
            }

            this.Hide();
        }

        private void longTourButton_Click(object sender, EventArgs e)
        {
            LongTourForm longTourForm = new LongTourForm();
            longTourForm.Show();
            if (adminFormFalse == true || adminOrUserLabel.Text == "ADMIN")
            {
                longTourForm.adminOrUserLabel.Text = "ADMIN";
            }
            else if (userFormFalse == true || adminOrUserLabel.Text == "USER")
            {
                longTourForm.adminOrUserLabel.Text = "USER";
            }

            this.Hide();
        }

        private void dayTourButton_Click(object sender, EventArgs e)
        {
            DayTourForm dayTourForm = new DayTourForm();
            dayTourForm.Show();
            if (adminFormFalse == true || adminOrUserLabel.Text == "ADMIN")
            {
                dayTourForm.adminOrUserLabel.Text = "ADMIN";
            }
            else if (userFormFalse == true || adminOrUserLabel.Text == "USER")
            {
                dayTourForm.adminOrUserLabel.Text = "USER";
            }

            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (userFormFalse == true || adminOrUserLabel.Text == "USER")
            {
                UserForm userForm = new UserForm();
                userForm.Show();
                userFormFalse = false;
                this.Hide();
            }
            else if (adminFormFalse == true || adminOrUserLabel.Text == "ADMIN")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                adminFormFalse = false;
                this.Hide();
            }
        }

        private void VehicleRentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (adminOrUserLabel.Text == "USER")
            {
                UserForm userForm = new UserForm();
                userForm.Show();
                userFormFalse = false;
                this.Hide();
            }
            else if (adminOrUserLabel.Text == "ADMIN")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                adminFormFalse = false;
                this.Hide();
            }
        }
    }
}