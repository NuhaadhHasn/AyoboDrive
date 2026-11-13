using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class NewDriver : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["AyoboDb"].ConnectionString;

        SqlConnection conn = new SqlConnection(ConnectionString);

        public NewDriver()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            driverIdTextBox.Text = "";
            driverNameTextBox.Text = "";
            ageTextBox.Text = "";
            genderComboxBox.Text = "";
            addressTextBox.Text = "";
            mobileNumberTextBox.Text = "";
            driverRateTextBox.Text = "";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText =
                    "INSERT INTO newDriver VALUES (@driverId, @driverName, @age, @gender, @address, @mobileNumber, @driverRate)";
                sqlCommand.Parameters.AddWithValue("@driverId", int.Parse(driverIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@driverName", driverNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@age", ageTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@gender", genderComboxBox.Text);
                sqlCommand.Parameters.AddWithValue("@address", addressTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@mobileNumber", mobileNumberTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@driverRate", driverRateTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("New Driver Created", "New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
                conn.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText =
                    "UPDATE newDriver SET driverId = @driverId, driverName = @driverName, age = @age, gender = @gender," +
                    "address = @address, mobileNumber = @mobileNumber, driverRate = @driverRate " +
                    "WHERE driverId = @driverId";
                sqlCommand.Parameters.AddWithValue("@driverId", int.Parse(driverIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@driverName", driverNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@age", ageTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@gender", genderComboxBox.Text);
                sqlCommand.Parameters.AddWithValue("@address", addressTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@mobileNumber", mobileNumberTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@driverRate", driverRateTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Package Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
                conn.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM newDriver WHERE driverId = @driverId";
                sqlCommand.Parameters.Add("@driverId", driverIdTextBox.Text);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    driverIdTextBox.Text = sqlDataReader[0].ToString();
                    driverNameTextBox.Text = sqlDataReader[1].ToString();
                    ageTextBox.Text = sqlDataReader[2].ToString();
                    genderComboxBox.Text = sqlDataReader[3].ToString();
                    addressTextBox.Text = sqlDataReader[4].ToString();
                    mobileNumberTextBox.Text = sqlDataReader[5].ToString();
                    driverRateTextBox.Text = sqlDataReader[6].ToString();
                }
                else
                {
                    MessageBox.Show("Package Not Found");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
                conn.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "DELETE FROM newDriver WHERE driverId = @driverId";
                sqlCommand.Parameters.Add("@driverId", driverIdTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Package Deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
                conn.Close();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void NewDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void genderComboxBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode != Keys.Down) && (e.KeyCode != Keys.Up) && (e.KeyCode != Keys.Tab))
            {
                genderComboxBox.Text = "";
            }
        }
    }
}