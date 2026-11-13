using System.ComponentModel;

namespace AyoboDrive
{
    partial class LongTourForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectPackageGroupBox = new System.Windows.Forms.GroupBox();
            this.driverIdComboBox = new System.Windows.Forms.ComboBox();
            this.driverRateTextBox = new System.Windows.Forms.TextBox();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.driverRateLabel = new System.Windows.Forms.Label();
            this.driverNameLabel = new System.Windows.Forms.Label();
            this.driverIdLabel = new System.Windows.Forms.Label();
            this.packageIdComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleIdComboBox = new System.Windows.Forms.ComboBox();
            this.extraRateForNightTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDayRateTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.noOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.extraRateForNightLabel = new System.Windows.Forms.Label();
            this.vehicleDayRateLabel = new System.Windows.Forms.Label();
            this.numberOfSeatsLabel = new System.Windows.Forms.Label();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.vehicleNameLabel = new System.Windows.Forms.Label();
            this.vehicleIdLabel = new System.Windows.Forms.Label();
            this.extraRateForDistanceTextBox = new System.Windows.Forms.TextBox();
            this.maxDurationTextBox = new System.Windows.Forms.TextBox();
            this.maxDistanceTextBox = new System.Windows.Forms.TextBox();
            this.packageRateTextBox = new System.Windows.Forms.TextBox();
            this.packageNameTextBox = new System.Windows.Forms.TextBox();
            this.packageRateLabel = new System.Windows.Forms.Label();
            this.extraRateForDistanceLabel = new System.Windows.Forms.Label();
            this.maxDurationLabel = new System.Windows.Forms.Label();
            this.maxDurationLbel = new System.Windows.Forms.Label();
            this.packageNameLabel = new System.Windows.Forms.Label();
            this.packageIdLabel = new System.Windows.Forms.Label();
            this.totalNoOfDistanceTextBox = new System.Windows.Forms.TextBox();
            this.totalCostForExtraDistanceLabel = new System.Windows.Forms.Label();
            this.extraNoOfDistanceTextBox = new System.Windows.Forms.TextBox();
            this.totalCostForExtraDistanceTextBox = new System.Windows.Forms.TextBox();
            this.extraNoOfDistanceLabel = new System.Windows.Forms.Label();
            this.totalNoOfDistanceLabel = new System.Windows.Forms.Label();
            this.calculateExtraDistanceCostButton = new System.Windows.Forms.Button();
            this.distanceGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDistanceTextBox = new System.Windows.Forms.TextBox();
            this.previousDistanceTextBox = new System.Windows.Forms.TextBox();
            this.currentDistanceLabel = new System.Windows.Forms.Label();
            this.previousDistanceLabel = new System.Windows.Forms.Label();
            this.LendDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calculateExtraNightCost = new System.Windows.Forms.Button();
            this.totalCostForExtraNightTextBox = new System.Windows.Forms.TextBox();
            this.DurationGroupBox = new System.Windows.Forms.GroupBox();
            this.adminOrUserLabel = new System.Windows.Forms.Label();
            this.noOfExtraNightTextBox = new System.Windows.Forms.TextBox();
            this.noOfNightTextBox = new System.Windows.Forms.TextBox();
            this.totalCostForExtraNightLabel = new System.Windows.Forms.Label();
            this.noOfExtraNightLabel = new System.Windows.Forms.Label();
            this.noOfNightLabel = new System.Windows.Forms.Label();
            this.returnedDateLabel = new System.Windows.Forms.Label();
            this.lendDateLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.calcLongTourCostButton = new System.Windows.Forms.Button();
            this.totalCostForLongTourTextBox = new System.Windows.Forms.TextBox();
            this.totalCostForLongTourLabel = new System.Windows.Forms.Label();
            this.selectPackageGroupBox.SuspendLayout();
            this.distanceGroupBox.SuspendLayout();
            this.DurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPackageGroupBox
            // 
            this.selectPackageGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.selectPackageGroupBox.Controls.Add(this.driverIdComboBox);
            this.selectPackageGroupBox.Controls.Add(this.driverRateTextBox);
            this.selectPackageGroupBox.Controls.Add(this.driverNameTextBox);
            this.selectPackageGroupBox.Controls.Add(this.driverRateLabel);
            this.selectPackageGroupBox.Controls.Add(this.driverNameLabel);
            this.selectPackageGroupBox.Controls.Add(this.driverIdLabel);
            this.selectPackageGroupBox.Controls.Add(this.packageIdComboBox);
            this.selectPackageGroupBox.Controls.Add(this.vehicleIdComboBox);
            this.selectPackageGroupBox.Controls.Add(this.extraRateForNightTextBox);
            this.selectPackageGroupBox.Controls.Add(this.vehicleDayRateTextBox);
            this.selectPackageGroupBox.Controls.Add(this.vehicleNameTextBox);
            this.selectPackageGroupBox.Controls.Add(this.vehicleTypeTextBox);
            this.selectPackageGroupBox.Controls.Add(this.noOfSeatsTextBox);
            this.selectPackageGroupBox.Controls.Add(this.extraRateForNightLabel);
            this.selectPackageGroupBox.Controls.Add(this.vehicleDayRateLabel);
            this.selectPackageGroupBox.Controls.Add(this.numberOfSeatsLabel);
            this.selectPackageGroupBox.Controls.Add(this.vehicleTypeLabel);
            this.selectPackageGroupBox.Controls.Add(this.vehicleNameLabel);
            this.selectPackageGroupBox.Controls.Add(this.vehicleIdLabel);
            this.selectPackageGroupBox.Controls.Add(this.extraRateForDistanceTextBox);
            this.selectPackageGroupBox.Controls.Add(this.maxDurationTextBox);
            this.selectPackageGroupBox.Controls.Add(this.maxDistanceTextBox);
            this.selectPackageGroupBox.Controls.Add(this.packageRateTextBox);
            this.selectPackageGroupBox.Controls.Add(this.packageNameTextBox);
            this.selectPackageGroupBox.Controls.Add(this.packageRateLabel);
            this.selectPackageGroupBox.Controls.Add(this.extraRateForDistanceLabel);
            this.selectPackageGroupBox.Controls.Add(this.maxDurationLabel);
            this.selectPackageGroupBox.Controls.Add(this.maxDurationLbel);
            this.selectPackageGroupBox.Controls.Add(this.packageNameLabel);
            this.selectPackageGroupBox.Controls.Add(this.packageIdLabel);
            this.selectPackageGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPackageGroupBox.ForeColor = System.Drawing.Color.White;
            this.selectPackageGroupBox.Location = new System.Drawing.Point(12, 3);
            this.selectPackageGroupBox.Name = "selectPackageGroupBox";
            this.selectPackageGroupBox.Size = new System.Drawing.Size(917, 222);
            this.selectPackageGroupBox.TabIndex = 4;
            this.selectPackageGroupBox.TabStop = false;
            this.selectPackageGroupBox.Text = "Select Package";
            // 
            // driverIdComboBox
            // 
            this.driverIdComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverIdComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.driverIdComboBox.ForeColor = System.Drawing.Color.White;
            this.driverIdComboBox.FormattingEnabled = true;
            this.driverIdComboBox.Location = new System.Drawing.Point(748, 28);
            this.driverIdComboBox.Name = "driverIdComboBox";
            this.driverIdComboBox.Size = new System.Drawing.Size(156, 25);
            this.driverIdComboBox.TabIndex = 53;
            this.driverIdComboBox.SelectedIndexChanged += new System.EventHandler(this.driverIdComboBox_SelectedIndexChanged);
            // 
            // driverRateTextBox
            // 
            this.driverRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverRateTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRateTextBox.ForeColor = System.Drawing.Color.White;
            this.driverRateTextBox.Location = new System.Drawing.Point(748, 90);
            this.driverRateTextBox.Name = "driverRateTextBox";
            this.driverRateTextBox.Size = new System.Drawing.Size(156, 25);
            this.driverRateTextBox.TabIndex = 13;
            this.driverRateTextBox.Text = "0";
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverNameTextBox.ForeColor = System.Drawing.Color.White;
            this.driverNameTextBox.Location = new System.Drawing.Point(748, 59);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(156, 25);
            this.driverNameTextBox.TabIndex = 12;
            // 
            // driverRateLabel
            // 
            this.driverRateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.driverRateLabel.ForeColor = System.Drawing.Color.White;
            this.driverRateLabel.Location = new System.Drawing.Point(647, 92);
            this.driverRateLabel.Name = "driverRateLabel";
            this.driverRateLabel.Size = new System.Drawing.Size(104, 23);
            this.driverRateLabel.TabIndex = 51;
            this.driverRateLabel.Text = "Driver Rate : ";
            // 
            // driverNameLabel
            // 
            this.driverNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.driverNameLabel.ForeColor = System.Drawing.Color.White;
            this.driverNameLabel.Location = new System.Drawing.Point(647, 61);
            this.driverNameLabel.Name = "driverNameLabel";
            this.driverNameLabel.Size = new System.Drawing.Size(119, 23);
            this.driverNameLabel.TabIndex = 50;
            this.driverNameLabel.Text = "Driver Name : ";
            // 
            // driverIdLabel
            // 
            this.driverIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.driverIdLabel.ForeColor = System.Drawing.Color.White;
            this.driverIdLabel.Location = new System.Drawing.Point(647, 28);
            this.driverIdLabel.Name = "driverIdLabel";
            this.driverIdLabel.Size = new System.Drawing.Size(100, 23);
            this.driverIdLabel.TabIndex = 52;
            this.driverIdLabel.Text = "Driver ID : ";
            // 
            // packageIdComboBox
            // 
            this.packageIdComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.packageIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.packageIdComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.packageIdComboBox.ForeColor = System.Drawing.Color.White;
            this.packageIdComboBox.FormattingEnabled = true;
            this.packageIdComboBox.Location = new System.Drawing.Point(200, 24);
            this.packageIdComboBox.Name = "packageIdComboBox";
            this.packageIdComboBox.Size = new System.Drawing.Size(156, 25);
            this.packageIdComboBox.TabIndex = 1;
            this.packageIdComboBox.SelectedIndexChanged += new System.EventHandler(this.packageIdComboBox_SelectedIndexChanged);
            // 
            // vehicleIdComboBox
            // 
            this.vehicleIdComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleIdComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.vehicleIdComboBox.ForeColor = System.Drawing.Color.White;
            this.vehicleIdComboBox.FormattingEnabled = true;
            this.vehicleIdComboBox.Location = new System.Drawing.Point(485, 24);
            this.vehicleIdComboBox.Name = "vehicleIdComboBox";
            this.vehicleIdComboBox.Size = new System.Drawing.Size(156, 25);
            this.vehicleIdComboBox.TabIndex = 6;
            this.vehicleIdComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleIdComboBox_SelectedIndexChanged);
            // 
            // extraRateForNightTextBox
            // 
            this.extraRateForNightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.extraRateForNightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraRateForNightTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraRateForNightTextBox.ForeColor = System.Drawing.Color.White;
            this.extraRateForNightTextBox.Location = new System.Drawing.Point(625, 179);
            this.extraRateForNightTextBox.Name = "extraRateForNightTextBox";
            this.extraRateForNightTextBox.Size = new System.Drawing.Size(155, 25);
            this.extraRateForNightTextBox.TabIndex = 15;
            this.extraRateForNightTextBox.Text = "1000";
            // 
            // vehicleDayRateTextBox
            // 
            this.vehicleDayRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleDayRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleDayRateTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDayRateTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleDayRateTextBox.Location = new System.Drawing.Point(485, 148);
            this.vehicleDayRateTextBox.Name = "vehicleDayRateTextBox";
            this.vehicleDayRateTextBox.Size = new System.Drawing.Size(155, 25);
            this.vehicleDayRateTextBox.TabIndex = 10;
            this.vehicleDayRateTextBox.Text = "0";
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNameTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleNameTextBox.Location = new System.Drawing.Point(485, 55);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(155, 25);
            this.vehicleNameTextBox.TabIndex = 7;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(486, 86);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(155, 25);
            this.vehicleTypeTextBox.TabIndex = 8;
            // 
            // noOfSeatsTextBox
            // 
            this.noOfSeatsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.noOfSeatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noOfSeatsTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfSeatsTextBox.ForeColor = System.Drawing.Color.White;
            this.noOfSeatsTextBox.Location = new System.Drawing.Point(485, 117);
            this.noOfSeatsTextBox.Name = "noOfSeatsTextBox";
            this.noOfSeatsTextBox.Size = new System.Drawing.Size(155, 25);
            this.noOfSeatsTextBox.TabIndex = 9;
            // 
            // extraRateForNightLabel
            // 
            this.extraRateForNightLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.extraRateForNightLabel.ForeColor = System.Drawing.Color.White;
            this.extraRateForNightLabel.Location = new System.Drawing.Point(479, 181);
            this.extraRateForNightLabel.Name = "extraRateForNightLabel";
            this.extraRateForNightLabel.Size = new System.Drawing.Size(149, 23);
            this.extraRateForNightLabel.TabIndex = 43;
            this.extraRateForNightLabel.Text = "Extra Rate For Night : ";
            // 
            // vehicleDayRateLabel
            // 
            this.vehicleDayRateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.vehicleDayRateLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleDayRateLabel.Location = new System.Drawing.Point(362, 150);
            this.vehicleDayRateLabel.Name = "vehicleDayRateLabel";
            this.vehicleDayRateLabel.Size = new System.Drawing.Size(143, 23);
            this.vehicleDayRateLabel.TabIndex = 43;
            this.vehicleDayRateLabel.Text = "Vehicle Day Rate : ";
            // 
            // numberOfSeatsLabel
            // 
            this.numberOfSeatsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.numberOfSeatsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfSeatsLabel.Location = new System.Drawing.Point(362, 119);
            this.numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            this.numberOfSeatsLabel.Size = new System.Drawing.Size(151, 23);
            this.numberOfSeatsLabel.TabIndex = 39;
            this.numberOfSeatsLabel.Text = "Number Of Seats : ";
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.vehicleTypeLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(362, 88);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(143, 23);
            this.vehicleTypeLabel.TabIndex = 38;
            this.vehicleTypeLabel.Text = "Vehicle Type : ";
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.vehicleNameLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleNameLabel.Location = new System.Drawing.Point(362, 57);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(143, 23);
            this.vehicleNameLabel.TabIndex = 42;
            this.vehicleNameLabel.Text = "Vehicle Name : ";
            // 
            // vehicleIdLabel
            // 
            this.vehicleIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.vehicleIdLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleIdLabel.Location = new System.Drawing.Point(362, 28);
            this.vehicleIdLabel.Name = "vehicleIdLabel";
            this.vehicleIdLabel.Size = new System.Drawing.Size(100, 23);
            this.vehicleIdLabel.TabIndex = 41;
            this.vehicleIdLabel.Text = "Vehicle ID : ";
            // 
            // extraRateForDistanceTextBox
            // 
            this.extraRateForDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.extraRateForDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraRateForDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraRateForDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.extraRateForDistanceTextBox.Location = new System.Drawing.Point(317, 179);
            this.extraRateForDistanceTextBox.Name = "extraRateForDistanceTextBox";
            this.extraRateForDistanceTextBox.Size = new System.Drawing.Size(156, 25);
            this.extraRateForDistanceTextBox.TabIndex = 14;
            this.extraRateForDistanceTextBox.Text = "1000";
            // 
            // maxDurationTextBox
            // 
            this.maxDurationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.maxDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDurationTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDurationTextBox.ForeColor = System.Drawing.Color.White;
            this.maxDurationTextBox.Location = new System.Drawing.Point(200, 148);
            this.maxDurationTextBox.Name = "maxDurationTextBox";
            this.maxDurationTextBox.Size = new System.Drawing.Size(156, 25);
            this.maxDurationTextBox.TabIndex = 5;
            this.maxDurationTextBox.Text = "0";
            // 
            // maxDistanceTextBox
            // 
            this.maxDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.maxDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.maxDistanceTextBox.Location = new System.Drawing.Point(200, 117);
            this.maxDistanceTextBox.Name = "maxDistanceTextBox";
            this.maxDistanceTextBox.Size = new System.Drawing.Size(156, 25);
            this.maxDistanceTextBox.TabIndex = 4;
            this.maxDistanceTextBox.Text = "0";
            // 
            // packageRateTextBox
            // 
            this.packageRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.packageRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageRateTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageRateTextBox.ForeColor = System.Drawing.Color.White;
            this.packageRateTextBox.Location = new System.Drawing.Point(200, 86);
            this.packageRateTextBox.Name = "packageRateTextBox";
            this.packageRateTextBox.Size = new System.Drawing.Size(156, 25);
            this.packageRateTextBox.TabIndex = 3;
            // 
            // packageNameTextBox
            // 
            this.packageNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.packageNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageNameTextBox.ForeColor = System.Drawing.Color.White;
            this.packageNameTextBox.Location = new System.Drawing.Point(200, 55);
            this.packageNameTextBox.Name = "packageNameTextBox";
            this.packageNameTextBox.Size = new System.Drawing.Size(156, 25);
            this.packageNameTextBox.TabIndex = 2;
            // 
            // packageRateLabel
            // 
            this.packageRateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.packageRateLabel.ForeColor = System.Drawing.Color.White;
            this.packageRateLabel.Location = new System.Drawing.Point(6, 88);
            this.packageRateLabel.Name = "packageRateLabel";
            this.packageRateLabel.Size = new System.Drawing.Size(98, 23);
            this.packageRateLabel.TabIndex = 32;
            this.packageRateLabel.Text = "Package Rate : ";
            // 
            // extraRateForDistanceLabel
            // 
            this.extraRateForDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.extraRateForDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.extraRateForDistanceLabel.Location = new System.Drawing.Point(115, 181);
            this.extraRateForDistanceLabel.Name = "extraRateForDistanceLabel";
            this.extraRateForDistanceLabel.Size = new System.Drawing.Size(196, 23);
            this.extraRateForDistanceLabel.TabIndex = 29;
            this.extraRateForDistanceLabel.Text = "Extra Rate For Distance (KM) : ";
            // 
            // maxDurationLabel
            // 
            this.maxDurationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.maxDurationLabel.ForeColor = System.Drawing.Color.White;
            this.maxDurationLabel.Location = new System.Drawing.Point(6, 150);
            this.maxDurationLabel.Name = "maxDurationLabel";
            this.maxDurationLabel.Size = new System.Drawing.Size(195, 23);
            this.maxDurationLabel.TabIndex = 29;
            this.maxDurationLabel.Text = "Maximum Duration (Nights) : ";
            // 
            // maxDurationLbel
            // 
            this.maxDurationLbel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.maxDurationLbel.ForeColor = System.Drawing.Color.White;
            this.maxDurationLbel.Location = new System.Drawing.Point(6, 119);
            this.maxDurationLbel.Name = "maxDurationLbel";
            this.maxDurationLbel.Size = new System.Drawing.Size(173, 23);
            this.maxDurationLbel.TabIndex = 28;
            this.maxDurationLbel.Text = "Maximum Distance (KM) : ";
            // 
            // packageNameLabel
            // 
            this.packageNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.packageNameLabel.ForeColor = System.Drawing.Color.White;
            this.packageNameLabel.Location = new System.Drawing.Point(6, 57);
            this.packageNameLabel.Name = "packageNameLabel";
            this.packageNameLabel.Size = new System.Drawing.Size(109, 23);
            this.packageNameLabel.TabIndex = 31;
            this.packageNameLabel.Text = "Package Name : ";
            // 
            // packageIdLabel
            // 
            this.packageIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.packageIdLabel.ForeColor = System.Drawing.Color.White;
            this.packageIdLabel.Location = new System.Drawing.Point(6, 28);
            this.packageIdLabel.Name = "packageIdLabel";
            this.packageIdLabel.Size = new System.Drawing.Size(88, 23);
            this.packageIdLabel.TabIndex = 30;
            this.packageIdLabel.Text = "Package ID : ";
            // 
            // totalNoOfDistanceTextBox
            // 
            this.totalNoOfDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.totalNoOfDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalNoOfDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNoOfDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.totalNoOfDistanceTextBox.Location = new System.Drawing.Point(613, 21);
            this.totalNoOfDistanceTextBox.Name = "totalNoOfDistanceTextBox";
            this.totalNoOfDistanceTextBox.Size = new System.Drawing.Size(277, 25);
            this.totalNoOfDistanceTextBox.TabIndex = 24;
            this.totalNoOfDistanceTextBox.Text = "0";
            // 
            // totalCostForExtraDistanceLabel
            // 
            this.totalCostForExtraDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalCostForExtraDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostForExtraDistanceLabel.Location = new System.Drawing.Point(214, 138);
            this.totalCostForExtraDistanceLabel.Name = "totalCostForExtraDistanceLabel";
            this.totalCostForExtraDistanceLabel.Size = new System.Drawing.Size(197, 23);
            this.totalCostForExtraDistanceLabel.TabIndex = 37;
            this.totalCostForExtraDistanceLabel.Text = "Total Cost For Extra Distance : ";
            // 
            // extraNoOfDistanceTextBox
            // 
            this.extraNoOfDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.extraNoOfDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraNoOfDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraNoOfDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.extraNoOfDistanceTextBox.Location = new System.Drawing.Point(613, 52);
            this.extraNoOfDistanceTextBox.Name = "extraNoOfDistanceTextBox";
            this.extraNoOfDistanceTextBox.Size = new System.Drawing.Size(277, 25);
            this.extraNoOfDistanceTextBox.TabIndex = 25;
            this.extraNoOfDistanceTextBox.Text = "0";
            // 
            // totalCostForExtraDistanceTextBox
            // 
            this.totalCostForExtraDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.totalCostForExtraDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostForExtraDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostForExtraDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.totalCostForExtraDistanceTextBox.Location = new System.Drawing.Point(417, 136);
            this.totalCostForExtraDistanceTextBox.Name = "totalCostForExtraDistanceTextBox";
            this.totalCostForExtraDistanceTextBox.Size = new System.Drawing.Size(277, 25);
            this.totalCostForExtraDistanceTextBox.TabIndex = 27;
            this.totalCostForExtraDistanceTextBox.Text = "0";
            // 
            // extraNoOfDistanceLabel
            // 
            this.extraNoOfDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.extraNoOfDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.extraNoOfDistanceLabel.Location = new System.Drawing.Point(425, 54);
            this.extraNoOfDistanceLabel.Name = "extraNoOfDistanceLabel";
            this.extraNoOfDistanceLabel.Size = new System.Drawing.Size(182, 23);
            this.extraNoOfDistanceLabel.TabIndex = 37;
            this.extraNoOfDistanceLabel.Text = "Extra No.Of Distance (KM) : ";
            // 
            // totalNoOfDistanceLabel
            // 
            this.totalNoOfDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalNoOfDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.totalNoOfDistanceLabel.Location = new System.Drawing.Point(425, 23);
            this.totalNoOfDistanceLabel.Name = "totalNoOfDistanceLabel";
            this.totalNoOfDistanceLabel.Size = new System.Drawing.Size(182, 23);
            this.totalNoOfDistanceLabel.TabIndex = 38;
            this.totalNoOfDistanceLabel.Text = "Total No.Of Distance (KM) : ";
            // 
            // calculateExtraDistanceCostButton
            // 
            this.calculateExtraDistanceCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.calculateExtraDistanceCostButton.FlatAppearance.BorderSize = 0;
            this.calculateExtraDistanceCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateExtraDistanceCostButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.calculateExtraDistanceCostButton.ForeColor = System.Drawing.Color.White;
            this.calculateExtraDistanceCostButton.Location = new System.Drawing.Point(338, 83);
            this.calculateExtraDistanceCostButton.Name = "calculateExtraDistanceCostButton";
            this.calculateExtraDistanceCostButton.Size = new System.Drawing.Size(208, 47);
            this.calculateExtraDistanceCostButton.TabIndex = 26;
            this.calculateExtraDistanceCostButton.Text = "Calculate Extra Distance Cost";
            this.calculateExtraDistanceCostButton.UseVisualStyleBackColor = false;
            this.calculateExtraDistanceCostButton.Click += new System.EventHandler(this.calculateExtraDistanceCostButton_Click);
            // 
            // distanceGroupBox
            // 
            this.distanceGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.distanceGroupBox.Controls.Add(this.calculateExtraDistanceCostButton);
            this.distanceGroupBox.Controls.Add(this.totalCostForExtraDistanceTextBox);
            this.distanceGroupBox.Controls.Add(this.currentDistanceTextBox);
            this.distanceGroupBox.Controls.Add(this.extraNoOfDistanceTextBox);
            this.distanceGroupBox.Controls.Add(this.previousDistanceTextBox);
            this.distanceGroupBox.Controls.Add(this.totalNoOfDistanceTextBox);
            this.distanceGroupBox.Controls.Add(this.totalCostForExtraDistanceLabel);
            this.distanceGroupBox.Controls.Add(this.extraNoOfDistanceLabel);
            this.distanceGroupBox.Controls.Add(this.totalNoOfDistanceLabel);
            this.distanceGroupBox.Controls.Add(this.currentDistanceLabel);
            this.distanceGroupBox.Controls.Add(this.previousDistanceLabel);
            this.distanceGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.distanceGroupBox.ForeColor = System.Drawing.Color.White;
            this.distanceGroupBox.Location = new System.Drawing.Point(20, 414);
            this.distanceGroupBox.Name = "distanceGroupBox";
            this.distanceGroupBox.Size = new System.Drawing.Size(900, 172);
            this.distanceGroupBox.TabIndex = 6;
            this.distanceGroupBox.TabStop = false;
            this.distanceGroupBox.Text = "Distance";
            // 
            // currentDistanceTextBox
            // 
            this.currentDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.currentDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.currentDistanceTextBox.Location = new System.Drawing.Point(142, 52);
            this.currentDistanceTextBox.Name = "currentDistanceTextBox";
            this.currentDistanceTextBox.Size = new System.Drawing.Size(277, 25);
            this.currentDistanceTextBox.TabIndex = 23;
            this.currentDistanceTextBox.Text = "0";
            // 
            // previousDistanceTextBox
            // 
            this.previousDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.previousDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previousDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.previousDistanceTextBox.Location = new System.Drawing.Point(142, 21);
            this.previousDistanceTextBox.Name = "previousDistanceTextBox";
            this.previousDistanceTextBox.Size = new System.Drawing.Size(277, 25);
            this.previousDistanceTextBox.TabIndex = 22;
            this.previousDistanceTextBox.Text = "0";
            // 
            // currentDistanceLabel
            // 
            this.currentDistanceLabel.Location = new System.Drawing.Point(6, 54);
            this.currentDistanceLabel.Name = "currentDistanceLabel";
            this.currentDistanceLabel.Size = new System.Drawing.Size(130, 23);
            this.currentDistanceLabel.TabIndex = 4;
            this.currentDistanceLabel.Text = "Current Distance : ";
            // 
            // previousDistanceLabel
            // 
            this.previousDistanceLabel.Location = new System.Drawing.Point(6, 23);
            this.previousDistanceLabel.Name = "previousDistanceLabel";
            this.previousDistanceLabel.Size = new System.Drawing.Size(130, 23);
            this.previousDistanceLabel.TabIndex = 5;
            this.previousDistanceLabel.Text = "Previous Distance : ";
            // 
            // LendDateTimePicker
            // 
            this.LendDateTimePicker.Location = new System.Drawing.Point(127, 24);
            this.LendDateTimePicker.Name = "LendDateTimePicker";
            this.LendDateTimePicker.Size = new System.Drawing.Size(228, 25);
            this.LendDateTimePicker.TabIndex = 16;
            // 
            // returnedDateTimePicker
            // 
            this.returnedDateTimePicker.Location = new System.Drawing.Point(127, 55);
            this.returnedDateTimePicker.Name = "returnedDateTimePicker";
            this.returnedDateTimePicker.Size = new System.Drawing.Size(228, 25);
            this.returnedDateTimePicker.TabIndex = 17;
            // 
            // calculateExtraNightCost
            // 
            this.calculateExtraNightCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.calculateExtraNightCost.FlatAppearance.BorderSize = 0;
            this.calculateExtraNightCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateExtraNightCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.calculateExtraNightCost.ForeColor = System.Drawing.Color.White;
            this.calculateExtraNightCost.Location = new System.Drawing.Point(289, 86);
            this.calculateExtraNightCost.Name = "calculateExtraNightCost";
            this.calculateExtraNightCost.Size = new System.Drawing.Size(208, 47);
            this.calculateExtraNightCost.TabIndex = 41;
            this.calculateExtraNightCost.Text = "Calculate Extra Night Cost";
            this.calculateExtraNightCost.UseVisualStyleBackColor = false;
            this.calculateExtraNightCost.Click += new System.EventHandler(this.calculateExtraNightCost_Click);
            // 
            // totalCostForExtraNightTextBox
            // 
            this.totalCostForExtraNightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.totalCostForExtraNightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostForExtraNightTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostForExtraNightTextBox.ForeColor = System.Drawing.Color.White;
            this.totalCostForExtraNightTextBox.Location = new System.Drawing.Point(346, 139);
            this.totalCostForExtraNightTextBox.Name = "totalCostForExtraNightTextBox";
            this.totalCostForExtraNightTextBox.Size = new System.Drawing.Size(277, 25);
            this.totalCostForExtraNightTextBox.TabIndex = 21;
            this.totalCostForExtraNightTextBox.Text = "0";
            // 
            // DurationGroupBox
            // 
            this.DurationGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.DurationGroupBox.Controls.Add(this.adminOrUserLabel);
            this.DurationGroupBox.Controls.Add(this.calculateExtraNightCost);
            this.DurationGroupBox.Controls.Add(this.totalCostForExtraNightTextBox);
            this.DurationGroupBox.Controls.Add(this.noOfExtraNightTextBox);
            this.DurationGroupBox.Controls.Add(this.noOfNightTextBox);
            this.DurationGroupBox.Controls.Add(this.totalCostForExtraNightLabel);
            this.DurationGroupBox.Controls.Add(this.noOfExtraNightLabel);
            this.DurationGroupBox.Controls.Add(this.noOfNightLabel);
            this.DurationGroupBox.Controls.Add(this.returnedDateLabel);
            this.DurationGroupBox.Controls.Add(this.lendDateLabel);
            this.DurationGroupBox.Controls.Add(this.returnedDateTimePicker);
            this.DurationGroupBox.Controls.Add(this.LendDateTimePicker);
            this.DurationGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DurationGroupBox.ForeColor = System.Drawing.Color.White;
            this.DurationGroupBox.Location = new System.Drawing.Point(69, 231);
            this.DurationGroupBox.Name = "DurationGroupBox";
            this.DurationGroupBox.Size = new System.Drawing.Size(795, 177);
            this.DurationGroupBox.TabIndex = 20;
            this.DurationGroupBox.TabStop = false;
            this.DurationGroupBox.Text = "Duration";
            // 
            // adminOrUserLabel
            // 
            this.adminOrUserLabel.Location = new System.Drawing.Point(44, 104);
            this.adminOrUserLabel.Name = "adminOrUserLabel";
            this.adminOrUserLabel.Size = new System.Drawing.Size(100, 23);
            this.adminOrUserLabel.TabIndex = 40;
            this.adminOrUserLabel.Text = "none";
            this.adminOrUserLabel.Visible = false;
            // 
            // noOfExtraNightTextBox
            // 
            this.noOfExtraNightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.noOfExtraNightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noOfExtraNightTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfExtraNightTextBox.ForeColor = System.Drawing.Color.White;
            this.noOfExtraNightTextBox.Location = new System.Drawing.Point(503, 55);
            this.noOfExtraNightTextBox.Name = "noOfExtraNightTextBox";
            this.noOfExtraNightTextBox.Size = new System.Drawing.Size(277, 25);
            this.noOfExtraNightTextBox.TabIndex = 19;
            this.noOfExtraNightTextBox.Text = "0";
            // 
            // noOfNightTextBox
            // 
            this.noOfNightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.noOfNightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noOfNightTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfNightTextBox.ForeColor = System.Drawing.Color.White;
            this.noOfNightTextBox.Location = new System.Drawing.Point(503, 24);
            this.noOfNightTextBox.Name = "noOfNightTextBox";
            this.noOfNightTextBox.Size = new System.Drawing.Size(277, 25);
            this.noOfNightTextBox.TabIndex = 18;
            this.noOfNightTextBox.Text = "0";
            // 
            // totalCostForExtraNightLabel
            // 
            this.totalCostForExtraNightLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalCostForExtraNightLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostForExtraNightLabel.Location = new System.Drawing.Point(168, 141);
            this.totalCostForExtraNightLabel.Name = "totalCostForExtraNightLabel";
            this.totalCostForExtraNightLabel.Size = new System.Drawing.Size(187, 23);
            this.totalCostForExtraNightLabel.TabIndex = 37;
            this.totalCostForExtraNightLabel.Text = "Total Cost For Extra Night : ";
            // 
            // noOfExtraNightLabel
            // 
            this.noOfExtraNightLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.noOfExtraNightLabel.ForeColor = System.Drawing.Color.White;
            this.noOfExtraNightLabel.Location = new System.Drawing.Point(368, 61);
            this.noOfExtraNightLabel.Name = "noOfExtraNightLabel";
            this.noOfExtraNightLabel.Size = new System.Drawing.Size(129, 23);
            this.noOfExtraNightLabel.TabIndex = 37;
            this.noOfExtraNightLabel.Text = "No Of Extra Night : ";
            // 
            // noOfNightLabel
            // 
            this.noOfNightLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.noOfNightLabel.ForeColor = System.Drawing.Color.White;
            this.noOfNightLabel.Location = new System.Drawing.Point(368, 30);
            this.noOfNightLabel.Name = "noOfNightLabel";
            this.noOfNightLabel.Size = new System.Drawing.Size(103, 23);
            this.noOfNightLabel.TabIndex = 38;
            this.noOfNightLabel.Text = "No Of Night : ";
            // 
            // returnedDateLabel
            // 
            this.returnedDateLabel.Location = new System.Drawing.Point(13, 61);
            this.returnedDateLabel.Name = "returnedDateLabel";
            this.returnedDateLabel.Size = new System.Drawing.Size(108, 23);
            this.returnedDateLabel.TabIndex = 4;
            this.returnedDateLabel.Text = "Returned Date : ";
            // 
            // lendDateLabel
            // 
            this.lendDateLabel.Location = new System.Drawing.Point(13, 30);
            this.lendDateLabel.Name = "lendDateLabel";
            this.lendDateLabel.Size = new System.Drawing.Size(86, 23);
            this.lendDateLabel.TabIndex = 5;
            this.lendDateLabel.Text = "Lend Date : ";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(396, 679);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 50);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // calcLongTourCostButton
            // 
            this.calcLongTourCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.calcLongTourCostButton.FlatAppearance.BorderSize = 0;
            this.calcLongTourCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcLongTourCostButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.calcLongTourCostButton.ForeColor = System.Drawing.Color.White;
            this.calcLongTourCostButton.Location = new System.Drawing.Point(345, 592);
            this.calcLongTourCostButton.Name = "calcLongTourCostButton";
            this.calcLongTourCostButton.Size = new System.Drawing.Size(232, 50);
            this.calcLongTourCostButton.TabIndex = 28;
            this.calcLongTourCostButton.Text = "Calculate Long Tour Cost Button";
            this.calcLongTourCostButton.UseVisualStyleBackColor = false;
            this.calcLongTourCostButton.Click += new System.EventHandler(this.calcLongTourCostButton_Click);
            // 
            // totalCostForLongTourTextBox
            // 
            this.totalCostForLongTourTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.totalCostForLongTourTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostForLongTourTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostForLongTourTextBox.ForeColor = System.Drawing.Color.White;
            this.totalCostForLongTourTextBox.Location = new System.Drawing.Point(437, 648);
            this.totalCostForLongTourTextBox.Name = "totalCostForLongTourTextBox";
            this.totalCostForLongTourTextBox.Size = new System.Drawing.Size(277, 25);
            this.totalCostForLongTourTextBox.TabIndex = 29;
            this.totalCostForLongTourTextBox.Text = "0";
            // 
            // totalCostForLongTourLabel
            // 
            this.totalCostForLongTourLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalCostForLongTourLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostForLongTourLabel.Location = new System.Drawing.Point(253, 650);
            this.totalCostForLongTourLabel.Name = "totalCostForLongTourLabel";
            this.totalCostForLongTourLabel.Size = new System.Drawing.Size(171, 23);
            this.totalCostForLongTourLabel.TabIndex = 39;
            this.totalCostForLongTourLabel.Text = "Total Cost For Long Tour : ";
            // 
            // LongTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(945, 737);
            this.Controls.Add(this.totalCostForLongTourTextBox);
            this.Controls.Add(this.totalCostForLongTourLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.calcLongTourCostButton);
            this.Controls.Add(this.selectPackageGroupBox);
            this.Controls.Add(this.distanceGroupBox);
            this.Controls.Add(this.DurationGroupBox);
            this.Name = "LongTourForm";
            this.Text = "Long Tour";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LongTourForm_FormClosed);
            this.Load += new System.EventHandler(this.LongTourForm_Load);
            this.selectPackageGroupBox.ResumeLayout(false);
            this.selectPackageGroupBox.PerformLayout();
            this.distanceGroupBox.ResumeLayout(false);
            this.distanceGroupBox.PerformLayout();
            this.DurationGroupBox.ResumeLayout(false);
            this.DurationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox driverIdComboBox;

        public System.Windows.Forms.Label adminOrUserLabel;

        private System.Windows.Forms.Label totalCostForLongTourLabel;

        private System.Windows.Forms.TextBox previousDistanceTextBox;
        private System.Windows.Forms.TextBox currentDistanceTextBox;
        private System.Windows.Forms.TextBox totalNoOfDistanceTextBox;
        private System.Windows.Forms.TextBox extraNoOfDistanceTextBox;

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button calcLongTourCostButton;
        private System.Windows.Forms.TextBox noOfNightTextBox;
        private System.Windows.Forms.TextBox noOfExtraNightTextBox;

        private System.Windows.Forms.Label totalCostForExtraNightLabel;
        private System.Windows.Forms.TextBox totalCostForExtraNightTextBox;
        private System.Windows.Forms.Button calculateExtraNightCost;

        private System.Windows.Forms.GroupBox selectPackageGroupBox;
        private System.Windows.Forms.TextBox driverRateTextBox;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.Label driverRateLabel;
        private System.Windows.Forms.Label driverNameLabel;
        private System.Windows.Forms.Label driverIdLabel;
        private System.Windows.Forms.ComboBox packageIdComboBox;
        private System.Windows.Forms.ComboBox vehicleIdComboBox;
        private System.Windows.Forms.TextBox extraRateForNightTextBox;
        private System.Windows.Forms.TextBox vehicleDayRateTextBox;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.TextBox noOfSeatsTextBox;
        private System.Windows.Forms.Label extraRateForNightLabel;
        private System.Windows.Forms.Label vehicleDayRateLabel;
        private System.Windows.Forms.Label numberOfSeatsLabel;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Label vehicleNameLabel;
        private System.Windows.Forms.Label vehicleIdLabel;
        private System.Windows.Forms.TextBox extraRateForDistanceTextBox;
        private System.Windows.Forms.TextBox maxDurationTextBox;
        private System.Windows.Forms.TextBox maxDistanceTextBox;
        private System.Windows.Forms.TextBox packageRateTextBox;
        private System.Windows.Forms.TextBox packageNameTextBox;
        private System.Windows.Forms.Label packageRateLabel;
        private System.Windows.Forms.Label extraRateForDistanceLabel;
        private System.Windows.Forms.Label maxDurationLabel;
        private System.Windows.Forms.Label maxDurationLbel;
        private System.Windows.Forms.Label packageNameLabel;
        private System.Windows.Forms.Label packageIdLabel;
        private System.Windows.Forms.Label totalCostForExtraDistanceLabel;
        private System.Windows.Forms.TextBox totalCostForExtraDistanceTextBox;
        private System.Windows.Forms.Label currentDistanceLabel;
        private System.Windows.Forms.Label extraNoOfDistanceLabel;
        private System.Windows.Forms.Button calculateExtraDistanceCostButton;
        private System.Windows.Forms.GroupBox distanceGroupBox;
        private System.Windows.Forms.Label previousDistanceLabel;
        private System.Windows.Forms.Label totalNoOfDistanceLabel;
        private System.Windows.Forms.Label noOfExtraNightLabel;
        private System.Windows.Forms.DateTimePicker LendDateTimePicker;
        private System.Windows.Forms.DateTimePicker returnedDateTimePicker;
        private System.Windows.Forms.Button calculateTotalAmountButton;
        private System.Windows.Forms.TextBox totalCostForLongTourTextBox;
        private System.Windows.Forms.GroupBox DurationGroupBox;
        private System.Windows.Forms.TextBox noOfExtraDaysTextBox;
        private System.Windows.Forms.TextBox noOfDaysTextBox;
        private System.Windows.Forms.Label noOfNightLabel;
        private System.Windows.Forms.Label noOfExtraDaysLabel;
        private System.Windows.Forms.Label noOfDaysLabel;
        private System.Windows.Forms.Label returnedDateLabel;
        private System.Windows.Forms.Label lendDateLabel;

        private System.Windows.Forms.Label weekRateLabel;

        #endregion
    }
}