using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class LongTourForm : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["AyoboDb"].ConnectionString;

        SqlConnection conn = new SqlConnection(ConnectionString);
        private bool VIDComboBoxSelect = false;
        private bool PIDComboBoxSelect = false;
        private bool DIDComboBoxSelect = false;

        public LongTourForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            VehicleRentForm vehicleRentForm = new VehicleRentForm();
            vehicleRentForm.adminOrUserLabel.Text = adminOrUserLabel.Text;
            vehicleRentForm.Show();
            this.Hide();
        }

        private void LongTourForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            VehicleRentForm vehicleRentForm = new VehicleRentForm();
            vehicleRentForm.adminOrUserLabel.Text = adminOrUserLabel.Text;
            vehicleRentForm.Show();
            this.Hide();
        }

        private void LongTourForm_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            if (packageIdComboBox.SelectedIndex == -1 && VIDComboBoxSelect == false)
            {
                conn.Open();
                VIDComboBoxSelect = true;
                sqlCommand.CommandText = "SELECT * FROM newPackage";
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    packageIdComboBox.Items.Add(reader[0].ToString());
                }

                conn.Close();
            }

            if (vehicleIdComboBox.SelectedIndex == -1 && PIDComboBoxSelect == false)
            {
                conn.Open();

                PIDComboBoxSelect = true;
                sqlCommand.CommandText = "SELECT * FROM newVehicle";
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    vehicleIdComboBox.Items.Add(reader[0].ToString());
                }

                conn.Close();
            }

            if (driverIdComboBox.SelectedIndex == -1 && DIDComboBoxSelect == false)
            {
                conn.Open();

                DIDComboBoxSelect = true;
                sqlCommand.CommandText = "SELECT * FROM newDriver";
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    driverIdComboBox.Items.Add(reader[0].ToString());
                }

                conn.Close();
            }
        }

        private void packageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM newPackage where packageId=@packageId";
                sqlCommand.Parameters.AddWithValue("@packageId", packageIdComboBox.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    packageNameTextBox.Text = reader[1].ToString();
                    packageRateTextBox.Text = reader[2].ToString();
                    maxDistanceTextBox.Text = reader[3].ToString();
                    maxDurationTextBox.Text = reader[4].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void vehicleIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM newVehicle where vehicleId=@vehicleId";
                sqlCommand.Parameters.AddWithValue("@vehicleId", vehicleIdComboBox.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    vehicleNameTextBox.Text = reader[1].ToString();
                    vehicleTypeTextBox.Text = reader[2].ToString();
                    noOfSeatsTextBox.Text = reader[4].ToString();
                    vehicleDayRateTextBox.Text = reader[5].ToString();
                    previousDistanceTextBox.Text = reader[9].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void driverIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM newDriver where driverId=@driverId";
                sqlCommand.Parameters.AddWithValue("@driverId", driverIdComboBox.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    driverNameTextBox.Text = reader[1].ToString();
                    driverRateTextBox.Text = reader[6].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void calculateExtraDistanceCostButton_Click(object sender, EventArgs e)
        {
            int previousDistance, currentDistance, totalKm, maxKm, extraKm, extraKmCost;
            previousDistance = int.Parse(previousDistanceTextBox.Text);
            currentDistance = int.Parse(currentDistanceTextBox.Text);

            totalKm = currentDistance - previousDistance;
            totalNoOfDistanceTextBox.Text = totalKm.ToString();
            maxKm = int.Parse(maxDistanceTextBox.Text);
            if (totalKm > maxKm)
            {
                extraKm = totalKm - maxKm;
                extraNoOfDistanceTextBox.Text = extraKm.ToString();
                extraKmCost = extraKm * int.Parse(extraRateForDistanceTextBox.Text);
                totalCostForExtraDistanceTextBox.Text = extraKmCost.ToString();
            }
            else
            {
                extraNoOfDistanceTextBox.Text = "0";
                totalCostForExtraDistanceTextBox.Text = "0";
            }
        }

        private void calculateExtraNightCost_Click(object sender, EventArgs e)
        {
            double totalDays, extraNights, maxNights, totalExtraHoursCost;
            DateTime returnedTimeValue = returnedDateTimePicker.Value;
            DateTime lendTimeValue = LendDateTimePicker.Value;

            TimeSpan timeSpan = returnedTimeValue - lendTimeValue;
            totalDays = timeSpan.Days;
            noOfNightTextBox.Text = (totalDays - 1).ToString();

            maxNights = double.Parse(maxDurationTextBox.Text);

            if (totalDays > maxNights)
            {
                extraNights = totalDays - maxNights - 1;
                noOfExtraNightTextBox.Text = extraNights.ToString();
                totalExtraHoursCost = extraNights * double.Parse(extraRateForNightTextBox.Text);
                totalCostForExtraNightTextBox.Text = totalExtraHoursCost.ToString();
            }
            else
            {
                noOfExtraNightTextBox.Text = "0";
                totalCostForExtraNightTextBox.Text = "0";
            }
        }

        private void calcLongTourCostButton_Click(object sender, EventArgs e)
        {
            totalCostForLongTourTextBox.Text = (int.Parse(vehicleDayRateTextBox.Text) +
                                                int.Parse(driverRateTextBox.Text) +
                                                int.Parse(totalCostForExtraNightTextBox.Text) +
                                                int.Parse(totalCostForExtraDistanceTextBox.Text)).ToString();
        }
    }
}