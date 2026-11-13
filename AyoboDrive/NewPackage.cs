using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AyoboDrive
{
    public partial class NewPackage : Form
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["AyoboDb"].ConnectionString;

        SqlConnection conn = new SqlConnection(ConnectionString);

        public NewPackage()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            packageIdTextBox.Text = "";
            packageNameTextBox.Text = "";
            packageRateTextBox.Text = "";
            maxDistanceTextBox.Text = "";
            maxDurationTextBox.Text = "";
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
                    "INSERT INTO newPackage VALUES (@packageId, @packageName, @packageRate, @maximumDistance, @maximumDuration)";
                sqlCommand.Parameters.AddWithValue("@packageId", int.Parse(packageIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@packageName", packageNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@packageRate", packageRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@maximumDistance", maxDistanceTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@maximumDuration", maxDurationTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("New Package Created", "New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    "UPDATE newPackage SET packageId = @packageId, packageName = @packageName, " +
                    "packageRate = @packageRate, maximumDistance = @maximumDistance, maximumDuration = @maximumDuration " +
                    "WHERE packageId = @packageId";
                sqlCommand.Parameters.AddWithValue("@packageId", int.Parse(packageIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@packageName", packageNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@packageRate", packageRateTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@maximumDistance", maxDistanceTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@maximumDuration", maxDurationTextBox.Text);
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
                sqlCommand.CommandText = "SELECT * FROM newPackage WHERE packageId = @packageId";
                sqlCommand.Parameters.Add("@packageId", packageIdTextBox.Text);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    packageIdTextBox.Text = sqlDataReader[0].ToString();
                    packageNameTextBox.Text = sqlDataReader[1].ToString();
                    packageRateTextBox.Text = sqlDataReader[2].ToString();
                    maxDistanceTextBox.Text = sqlDataReader[3].ToString();
                    maxDurationTextBox.Text = sqlDataReader[4].ToString();
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
                sqlCommand.CommandText = "DELETE FROM newPackage WHERE packageId = @packageId";
                sqlCommand.Parameters.Add("@packageId", packageIdTextBox.Text);
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

        private void NewPackage_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}