using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class NewVehicle : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["AyoboDb"].ConnectionString;

        SqlConnection conn = new SqlConnection(ConnectionString);

        public NewVehicle()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            vehicleIdTextBox.Text = "";
            vehicleNameTextBox.Text = "";
            vehicleTypeTextBox.Text = "";
            licenceNumberTextBox.Text = "";
            noOfSeatsComboxBox.Text = "";
            dayRateTextBox.Text = "";
            weekRateTextBoc.Text = "";
            monthRateTextBox.Text = "";
            driverRateTextBox.Text = "";
            previousReadingTextBox.Text = "";
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
                    "INSERT INTO newVehicle (vehicleId, vehicleName, vehicleType, licenceNumber, numberOfSeats, dayRate," +
                    " weekRate, monthRate, driverRate, previousReading) " +
                    "VALUES (@vehicleId, @vehicleName, @vehicleType, @licenceNumber, @numberOfSeats, @dayRate," +
                    " @weekRate, @monthRate, @driverRate, @previousReading)";
                sqlCommand.Parameters.AddWithValue("@vehicleId", int.Parse(vehicleIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@vehicleName", vehicleNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@vehicleType", vehicleTypeTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@licenceNumber", licenceNumberTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@numberOfSeats", noOfSeatsComboxBox.Text);
                sqlCommand.Parameters.AddWithValue("@dayRate", dayRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@weekRate", weekRateTextBoc.Text);
                sqlCommand.Parameters.AddWithValue("@monthRate", monthRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@driverRate", driverRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@previousReading", previousReadingTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("New Vehicle Created", "New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    "UPDATE newVehicle SET vehicleId = @vehicleId, vehicleName = @vehicleName, " +
                    "vehicleType = @vehicleType, " +
                    "licenceNumber = @licenceNumber, numberOfSeats = @numberOfSeats, dayRate = @dayRate, " +
                    "weekRate = @weekRate, monthRate = @monthRate ,driverRate = @driverRate ,previousReading = @previousReading " +
                    "WHERE vehicleId = @vehicleId";
                sqlCommand.Parameters.AddWithValue("@vehicleId", int.Parse(vehicleIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@vehicleName", vehicleNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@vehicleType", vehicleTypeTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@licenceNumber", licenceNumberTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@numberOfSeats", noOfSeatsComboxBox.Text);
                sqlCommand.Parameters.AddWithValue("@dayRate", dayRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@weekRate", weekRateTextBoc.Text);
                sqlCommand.Parameters.AddWithValue("@monthRate", monthRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@driverRate", driverRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@previousReading", previousReadingTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Vehicle Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                sqlCommand.CommandText = "SELECT * FROM newVehicle WHERE vehicleId = @vehicleId";
                sqlCommand.Parameters.Add("@vehicleId", vehicleIdTextBox.Text);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    vehicleIdTextBox.Text = sqlDataReader["vehicleId"].ToString();
                    vehicleNameTextBox.Text = sqlDataReader["vehicleName"].ToString();
                    vehicleTypeTextBox.Text = sqlDataReader["vehicleType"].ToString();
                    licenceNumberTextBox.Text = sqlDataReader["licenceNumber"].ToString();
                    noOfSeatsComboxBox.Text = sqlDataReader["numberOfSeats"].ToString();
                    dayRateTextBox.Text = sqlDataReader["dayRate"].ToString();
                    weekRateTextBoc.Text = sqlDataReader["weekRate"].ToString();
                    monthRateTextBox.Text = sqlDataReader["monthRate"].ToString();
                    driverRateTextBox.Text = sqlDataReader["driverRate"].ToString();
                    previousReadingTextBox.Text = sqlDataReader["previousReading"].ToString();
                }
                else
                {
                    MessageBox.Show("Vehicle Not Found");
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
                sqlCommand.CommandText = "DELETE FROM newVehicle WHERE vehicleId = @vehicleId";
                sqlCommand.Parameters.Add("@driverId", vehicleIdTextBox.Text);
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

        private void NewVehicle_FormClosed(object sender, FormClosedEventArgs e)
        {

            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void noOfSeatsComboxBox_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode != Keys.Down) && (e.KeyCode != Keys.Up) && (e.KeyCode != Keys.Tab))
            {
                noOfSeatsComboxBox.Text = "";
            }
        }
    }
}