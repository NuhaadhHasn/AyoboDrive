using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "Username")
            {
                userNameTextBox.Text = "";
                userNameTextBox.ForeColor = Color.White;
            }
        }

        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.Text = "Username";
                userNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.White;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((userNameTextBox.Text == "admin" || userNameTextBox.Text == "Admin" || userNameTextBox.Text == "ADMIN")
                && (passwordTextBox.Text == "admin123"))
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if ((userNameTextBox.Text == "user" || userNameTextBox.Text == "User" ||
                      userNameTextBox.Text == "USER")
                     && (passwordTextBox.Text == "user123"))
            {
                UserForm userForm = new UserForm();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password you entered is incorrect please recheck it",
                    "Incorrect Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}