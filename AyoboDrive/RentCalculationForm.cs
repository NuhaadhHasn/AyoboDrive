using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class RentCalculationForm : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["AyoboDb"].ConnectionString;

        private bool VTypeComboBoxSelect = false;

        SqlConnection conn = new SqlConnection(ConnectionString);

        public RentCalculationForm()
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

        private void RentCalculationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            VehicleRentForm vehicleRentForm = new VehicleRentForm();
            vehicleRentForm.adminOrUserLabel.Text = adminOrUserLabel.Text;
            vehicleRentForm.Show();
            this.Hide();
        }


        private void RentCalculationForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            if (vehicleTypeComboBox.SelectedIndex == -1 && VTypeComboBoxSelect == false)
            {
                VTypeComboBoxSelect = true;
                sqlCommand.CommandText = "SELECT * FROM newVehicle";
                SqlDataReader reader = sqlCommand.ExecuteReader();
                vehicleTypeComboBox.Items.Add("Undefined");
                while (reader.Read())
                {
                    vehicleTypeComboBox.Items.Add(reader[2].ToString());
                    vehicleIdComboBox.Items.Add(reader[0].ToString());
                }
            }

            conn.Close();
        }

        private void vehicleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = CommandType.Text;
                if (vehicleTypeComboBox.Items.Contains("Undefined"))
                {
                }
                else
                {
                    vehicleTypeComboBox.Items.Insert(0, "Undefined");
                }

                if (vehicleTypeComboBox.Text == "Undefined")
                {
                    vehicleTypeComboBox.Items.Clear();
                    vehicleIdComboBox.Items.Clear();
                    label1.Text = VTypeComboBoxSelect.ToString();
                    if (VTypeComboBoxSelect == false || !vehicleTypeComboBox.Items.Contains("Undefined"))
                    {
                        VTypeComboBoxSelect = true;
                        sqlCommand.CommandText = "SELECT * FROM newVehicle";
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        vehicleTypeComboBox.Items.Insert(0, "Undefined");
                        while (reader.Read())
                        {
                            vehicleTypeComboBox.Items.Add(reader[2].ToString());
                            vehicleIdComboBox.Items.Add(reader[0].ToString());
                        }
                    }
                }
                else
                {
                    VTypeComboBoxSelect = false;
                    sqlCommand.CommandText = "SELECT * FROM newVehicle where vehicleType=@vehicleType";
                    sqlCommand.Parameters.AddWithValue("@vehicleType", vehicleTypeComboBox.Text);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        vehicleIdComboBox.Items.Clear();
                        vehicleIdComboBox.Items.Add(reader[0].ToString());
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                // ClearFields();
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
                    dayRateTextBox.Text = reader[5].ToString();
                    weekRateTextBox.Text = reader[6].ToString();
                    monthRateTextBox.Text = reader[7].ToString();
                    driverRateTextBox.Text = reader[8].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // ClearFields();
                conn.Close();
            }
        }

        private void calcNoOfDaysButton_Click(object sender, EventArgs e)
        {
            int TotalDays;
            int Days, Weeks, Months, remainder;
            DateTime returnedDateValue = returnedDateTimePicker.Value;
            DateTime rentedDateValue = RentedDateTimePicker.Value;

            TimeSpan timeSpan = returnedDateValue - rentedDateValue;
            TotalDays = timeSpan.Days;
            totalDaysTextBox.Text = TotalDays.ToString();

            if (TotalDays >= 30)
            {
                dayTextBox.Text = "0";
                weekTextBox.Text = "0";
                Months = TotalDays / 30;
                monthTextBox.Text = Months.ToString();
                remainder = TotalDays % 30;
                if (remainder >= 7 && remainder <= 30)
                {
                    Weeks = remainder / 7;
                    weekTextBox.Text = Weeks.ToString();
                    Days = remainder % 7;
                    dayTextBox.Text = Days.ToString();
                }
                else
                {
                    dayTextBox.Text = remainder.ToString();
                }
            }
            else if (TotalDays >= 7 && TotalDays <= 30)
            {
                dayTextBox.Text = "0";
                Weeks = TotalDays / 7;
                weekTextBox.Text = Weeks.ToString();
                Days = TotalDays % 7;
                dayTextBox.Text = Days.ToString();
            }
            else
            {
                DefaultValue();
                dayTextBox.Text = TotalDays.ToString();
            }
        }

        private void DefaultValue()
        {
            dayTextBox.Text = "0";
            weekTextBox.Text = "0";
            monthTextBox.Text = "0";
        }

        private void calculateTotalAmountButton_Click(object sender, EventArgs e)
        {
            int driverRateValue = 0;
            int dayRateValue = int.Parse(dayRateTextBox.Text) * int.Parse(dayTextBox.Text);
            int weekRateValue = int.Parse(weekRateTextBox.Text) * int.Parse(weekTextBox.Text);
            int monthRateValue = int.Parse(monthRateTextBox.Text) * int.Parse(monthTextBox.Text);
            if (withDriverCheckBox.Checked)
            {
                driverRateValue = int.Parse(driverRateTextBox.Text) * int.Parse(totalDaysTextBox.Text);
            }

            int totalAmount = dayRateValue + weekRateValue + monthRateValue + driverRateValue;
            totalAmountTextBox.Text = totalAmount.ToString();
        }

        private void vehicleTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}