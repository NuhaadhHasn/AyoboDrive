using System.ComponentModel;

namespace AyoboDrive
{
    partial class RentCalculationForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicleNameLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculateTotalAmountButton = new System.Windows.Forms.Button();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleIdComboBox = new System.Windows.Forms.ComboBox();
            this.withDriverCheckBox = new System.Windows.Forms.CheckBox();
            this.dayRateLabel = new System.Windows.Forms.Label();
            this.driverRateLabel = new System.Windows.Forms.Label();
            this.weekRateLabel = new System.Windows.Forms.Label();
            this.monthRateLabel = new System.Windows.Forms.Label();
            this.dayRateTextBox = new System.Windows.Forms.TextBox();
            this.weekRateTextBox = new System.Windows.Forms.TextBox();
            this.calcTotalAmount = new System.Windows.Forms.GroupBox();
            this.driverRateTextBox = new System.Windows.Forms.TextBox();
            this.monthRateTextBox = new System.Windows.Forms.TextBox();
            this.RentedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentedDateLabel = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.totalDaysLabel = new System.Windows.Forms.Label();
            this.weekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.totalDaysTextBox = new System.Windows.Forms.TextBox();
            this.calcNoOfDaysButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminOrUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.returnedDateLabel = new System.Windows.Forms.Label();
            this.calcTotalAmount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(369, 527);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 50);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.Location = new System.Drawing.Point(19, 33);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(123, 23);
            this.vehicleTypeLabel.TabIndex = 1;
            this.vehicleTypeLabel.Text = "Vehicle Type : ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vehicle Id : ";
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vehicleNameLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleNameLabel.Location = new System.Drawing.Point(19, 102);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(143, 23);
            this.vehicleNameLabel.TabIndex = 22;
            this.vehicleNameLabel.Text = "Vehicle Name : ";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.totalAmountLabel.Location = new System.Drawing.Point(207, 170);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(128, 23);
            this.totalAmountLabel.TabIndex = 22;
            this.totalAmountLabel.Text = "Total Amount : ";
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNameTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleNameTextBox.Location = new System.Drawing.Point(161, 100);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(278, 29);
            this.vehicleNameTextBox.TabIndex = 24;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.totalAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.ForeColor = System.Drawing.Color.White;
            this.totalAmountTextBox.Location = new System.Drawing.Point(341, 168);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(278, 29);
            this.totalAmountTextBox.TabIndex = 24;
            // 
            // calculateTotalAmountButton
            // 
            this.calculateTotalAmountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.calculateTotalAmountButton.FlatAppearance.BorderSize = 0;
            this.calculateTotalAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalAmountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.calculateTotalAmountButton.ForeColor = System.Drawing.Color.White;
            this.calculateTotalAmountButton.Location = new System.Drawing.Point(319, 207);
            this.calculateTotalAmountButton.Name = "calculateTotalAmountButton";
            this.calculateTotalAmountButton.Size = new System.Drawing.Size(214, 50);
            this.calculateTotalAmountButton.TabIndex = 27;
            this.calculateTotalAmountButton.Text = "Calculate Total Amount";
            this.calculateTotalAmountButton.UseVisualStyleBackColor = false;
            this.calculateTotalAmountButton.Click += new System.EventHandler(this.calculateTotalAmountButton_Click);
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vehicleTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(161, 30);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(278, 29);
            this.vehicleTypeComboBox.TabIndex = 28;
            this.vehicleTypeComboBox.Text = "Undefined";
            this.vehicleTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleTypeComboBox_SelectedIndexChanged);
            this.vehicleTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.vehicleTypeComboBox_SelectionChangeCommitted);
            // 
            // vehicleIdComboBox
            // 
            this.vehicleIdComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vehicleIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleIdComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vehicleIdComboBox.ForeColor = System.Drawing.Color.White;
            this.vehicleIdComboBox.FormattingEnabled = true;
            this.vehicleIdComboBox.Location = new System.Drawing.Point(161, 65);
            this.vehicleIdComboBox.Name = "vehicleIdComboBox";
            this.vehicleIdComboBox.Size = new System.Drawing.Size(278, 29);
            this.vehicleIdComboBox.TabIndex = 28;
            this.vehicleIdComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleIdComboBox_SelectedIndexChanged);
            // 
            // withDriverCheckBox
            // 
            this.withDriverCheckBox.FlatAppearance.BorderSize = 0;
            this.withDriverCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withDriverCheckBox.Location = new System.Drawing.Point(331, 134);
            this.withDriverCheckBox.Name = "withDriverCheckBox";
            this.withDriverCheckBox.Size = new System.Drawing.Size(146, 31);
            this.withDriverCheckBox.TabIndex = 29;
            this.withDriverCheckBox.Text = "With Driver";
            this.withDriverCheckBox.UseVisualStyleBackColor = true;
            // 
            // dayRateLabel
            // 
            this.dayRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dayRateLabel.ForeColor = System.Drawing.Color.White;
            this.dayRateLabel.Location = new System.Drawing.Point(458, 30);
            this.dayRateLabel.Name = "dayRateLabel";
            this.dayRateLabel.Size = new System.Drawing.Size(111, 23);
            this.dayRateLabel.TabIndex = 33;
            this.dayRateLabel.Text = "Day Rate : ";
            // 
            // driverRateLabel
            // 
            this.driverRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.driverRateLabel.ForeColor = System.Drawing.Color.White;
            this.driverRateLabel.Location = new System.Drawing.Point(458, 135);
            this.driverRateLabel.Name = "driverRateLabel";
            this.driverRateLabel.Size = new System.Drawing.Size(143, 23);
            this.driverRateLabel.TabIndex = 30;
            this.driverRateLabel.Text = "Driver Rate : ";
            // 
            // weekRateLabel
            // 
            this.weekRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.weekRateLabel.ForeColor = System.Drawing.Color.White;
            this.weekRateLabel.Location = new System.Drawing.Point(458, 65);
            this.weekRateLabel.Name = "weekRateLabel";
            this.weekRateLabel.Size = new System.Drawing.Size(111, 23);
            this.weekRateLabel.TabIndex = 32;
            this.weekRateLabel.Text = "Week Rate : ";
            // 
            // monthRateLabel
            // 
            this.monthRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.monthRateLabel.ForeColor = System.Drawing.Color.White;
            this.monthRateLabel.Location = new System.Drawing.Point(458, 100);
            this.monthRateLabel.Name = "monthRateLabel";
            this.monthRateLabel.Size = new System.Drawing.Size(111, 23);
            this.monthRateLabel.TabIndex = 31;
            this.monthRateLabel.Text = "Month Rate : ";
            // 
            // dayRateTextBox
            // 
            this.dayRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.dayRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayRateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayRateTextBox.ForeColor = System.Drawing.Color.White;
            this.dayRateTextBox.Location = new System.Drawing.Point(575, 28);
            this.dayRateTextBox.Name = "dayRateTextBox";
            this.dayRateTextBox.Size = new System.Drawing.Size(277, 29);
            this.dayRateTextBox.TabIndex = 36;
            this.dayRateTextBox.Text = "0";
            // 
            // weekRateTextBox
            // 
            this.weekRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.weekRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekRateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRateTextBox.ForeColor = System.Drawing.Color.White;
            this.weekRateTextBox.Location = new System.Drawing.Point(575, 63);
            this.weekRateTextBox.Name = "weekRateTextBox";
            this.weekRateTextBox.Size = new System.Drawing.Size(277, 29);
            this.weekRateTextBox.TabIndex = 35;
            this.weekRateTextBox.Text = "0";
            // 
            // calcTotalAmount
            // 
            this.calcTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.calcTotalAmount.Controls.Add(this.driverRateTextBox);
            this.calcTotalAmount.Controls.Add(this.monthRateTextBox);
            this.calcTotalAmount.Controls.Add(this.weekRateTextBox);
            this.calcTotalAmount.Controls.Add(this.dayRateTextBox);
            this.calcTotalAmount.Controls.Add(this.monthRateLabel);
            this.calcTotalAmount.Controls.Add(this.weekRateLabel);
            this.calcTotalAmount.Controls.Add(this.driverRateLabel);
            this.calcTotalAmount.Controls.Add(this.dayRateLabel);
            this.calcTotalAmount.Controls.Add(this.withDriverCheckBox);
            this.calcTotalAmount.Controls.Add(this.vehicleIdComboBox);
            this.calcTotalAmount.Controls.Add(this.vehicleTypeComboBox);
            this.calcTotalAmount.Controls.Add(this.calculateTotalAmountButton);
            this.calcTotalAmount.Controls.Add(this.totalAmountTextBox);
            this.calcTotalAmount.Controls.Add(this.vehicleNameTextBox);
            this.calcTotalAmount.Controls.Add(this.totalAmountLabel);
            this.calcTotalAmount.Controls.Add(this.vehicleNameLabel);
            this.calcTotalAmount.Controls.Add(this.label6);
            this.calcTotalAmount.Controls.Add(this.vehicleTypeLabel);
            this.calcTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.calcTotalAmount.ForeColor = System.Drawing.Color.White;
            this.calcTotalAmount.Location = new System.Drawing.Point(12, 251);
            this.calcTotalAmount.Name = "calcTotalAmount";
            this.calcTotalAmount.Size = new System.Drawing.Size(869, 270);
            this.calcTotalAmount.TabIndex = 0;
            this.calcTotalAmount.TabStop = false;
            this.calcTotalAmount.Text = "Calculate Total Amount";
            // 
            // driverRateTextBox
            // 
            this.driverRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverRateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRateTextBox.ForeColor = System.Drawing.Color.White;
            this.driverRateTextBox.Location = new System.Drawing.Point(575, 133);
            this.driverRateTextBox.Name = "driverRateTextBox";
            this.driverRateTextBox.Size = new System.Drawing.Size(277, 29);
            this.driverRateTextBox.TabIndex = 37;
            this.driverRateTextBox.Text = "0";
            // 
            // monthRateTextBox
            // 
            this.monthRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.monthRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthRateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRateTextBox.ForeColor = System.Drawing.Color.White;
            this.monthRateTextBox.Location = new System.Drawing.Point(575, 98);
            this.monthRateTextBox.Name = "monthRateTextBox";
            this.monthRateTextBox.Size = new System.Drawing.Size(277, 29);
            this.monthRateTextBox.TabIndex = 34;
            this.monthRateTextBox.Text = "0";
            // 
            // RentedDateTimePicker
            // 
            this.RentedDateTimePicker.Location = new System.Drawing.Point(161, 59);
            this.RentedDateTimePicker.Name = "RentedDateTimePicker";
            this.RentedDateTimePicker.Size = new System.Drawing.Size(291, 29);
            this.RentedDateTimePicker.TabIndex = 0;
            // 
            // returnedDateTimePicker
            // 
            this.returnedDateTimePicker.Location = new System.Drawing.Point(161, 94);
            this.returnedDateTimePicker.Name = "returnedDateTimePicker";
            this.returnedDateTimePicker.Size = new System.Drawing.Size(291, 29);
            this.returnedDateTimePicker.TabIndex = 0;
            // 
            // rentedDateLabel
            // 
            this.rentedDateLabel.Location = new System.Drawing.Point(19, 65);
            this.rentedDateLabel.Name = "rentedDateLabel";
            this.rentedDateLabel.Size = new System.Drawing.Size(123, 23);
            this.rentedDateLabel.TabIndex = 1;
            this.rentedDateLabel.Text = "Rented Date : ";
            // 
            // weekLabel
            // 
            this.weekLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.weekLabel.ForeColor = System.Drawing.Color.White;
            this.weekLabel.Location = new System.Drawing.Point(458, 94);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(111, 23);
            this.weekLabel.TabIndex = 21;
            this.weekLabel.Text = "Week : ";
            // 
            // monthLabel
            // 
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.monthLabel.ForeColor = System.Drawing.Color.White;
            this.monthLabel.Location = new System.Drawing.Point(458, 59);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(111, 23);
            this.monthLabel.TabIndex = 22;
            this.monthLabel.Text = "Month : ";
            // 
            // dayTextBox
            // 
            this.dayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.dayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTextBox.ForeColor = System.Drawing.Color.White;
            this.dayTextBox.Location = new System.Drawing.Point(575, 127);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(277, 29);
            this.dayTextBox.TabIndex = 26;
            this.dayTextBox.Text = "0";
            // 
            // totalDaysLabel
            // 
            this.totalDaysLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalDaysLabel.ForeColor = System.Drawing.Color.White;
            this.totalDaysLabel.Location = new System.Drawing.Point(458, 24);
            this.totalDaysLabel.Name = "totalDaysLabel";
            this.totalDaysLabel.Size = new System.Drawing.Size(111, 23);
            this.totalDaysLabel.TabIndex = 22;
            this.totalDaysLabel.Text = "Total Days : ";
            // 
            // weekTextBox
            // 
            this.weekTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.weekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekTextBox.ForeColor = System.Drawing.Color.White;
            this.weekTextBox.Location = new System.Drawing.Point(575, 92);
            this.weekTextBox.Name = "weekTextBox";
            this.weekTextBox.Size = new System.Drawing.Size(277, 29);
            this.weekTextBox.TabIndex = 25;
            this.weekTextBox.Text = "0";
            // 
            // monthTextBox
            // 
            this.monthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.monthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.ForeColor = System.Drawing.Color.White;
            this.monthTextBox.Location = new System.Drawing.Point(575, 57);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(277, 29);
            this.monthTextBox.TabIndex = 24;
            this.monthTextBox.Text = "0";
            // 
            // totalDaysTextBox
            // 
            this.totalDaysTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.totalDaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDaysTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDaysTextBox.ForeColor = System.Drawing.Color.White;
            this.totalDaysTextBox.Location = new System.Drawing.Point(575, 22);
            this.totalDaysTextBox.Name = "totalDaysTextBox";
            this.totalDaysTextBox.Size = new System.Drawing.Size(277, 29);
            this.totalDaysTextBox.TabIndex = 24;
            this.totalDaysTextBox.Text = "0";
            // 
            // calcNoOfDaysButton
            // 
            this.calcNoOfDaysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.calcNoOfDaysButton.FlatAppearance.BorderSize = 0;
            this.calcNoOfDaysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcNoOfDaysButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.calcNoOfDaysButton.ForeColor = System.Drawing.Color.White;
            this.calcNoOfDaysButton.Location = new System.Drawing.Point(322, 171);
            this.calcNoOfDaysButton.Name = "calcNoOfDaysButton";
            this.calcNoOfDaysButton.Size = new System.Drawing.Size(214, 50);
            this.calcNoOfDaysButton.TabIndex = 27;
            this.calcNoOfDaysButton.Text = "Calculate No. Of Days";
            this.calcNoOfDaysButton.UseVisualStyleBackColor = false;
            this.calcNoOfDaysButton.Click += new System.EventHandler(this.calcNoOfDaysButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.groupBox1.Controls.Add(this.adminOrUserLabel);
            this.groupBox1.Controls.Add(this.calcNoOfDaysButton);
            this.groupBox1.Controls.Add(this.totalDaysTextBox);
            this.groupBox1.Controls.Add(this.monthTextBox);
            this.groupBox1.Controls.Add(this.weekTextBox);
            this.groupBox1.Controls.Add(this.totalDaysLabel);
            this.groupBox1.Controls.Add(this.dayTextBox);
            this.groupBox1.Controls.Add(this.monthLabel);
            this.groupBox1.Controls.Add(this.weekLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dayLabel);
            this.groupBox1.Controls.Add(this.returnedDateLabel);
            this.groupBox1.Controls.Add(this.rentedDateLabel);
            this.groupBox1.Controls.Add(this.returnedDateTimePicker);
            this.groupBox1.Controls.Add(this.RentedDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate No. Of Dates";
            // 
            // adminOrUserLabel
            // 
            this.adminOrUserLabel.Location = new System.Drawing.Point(55, 171);
            this.adminOrUserLabel.Name = "adminOrUserLabel";
            this.adminOrUserLabel.Size = new System.Drawing.Size(100, 23);
            this.adminOrUserLabel.TabIndex = 41;
            this.adminOrUserLabel.Text = "none";
            this.adminOrUserLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "false";
            this.label1.Visible = false;
            // 
            // dayLabel
            // 
            this.dayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.Location = new System.Drawing.Point(458, 129);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(111, 23);
            this.dayLabel.TabIndex = 23;
            this.dayLabel.Text = "Days : ";
            // 
            // returnedDateLabel
            // 
            this.returnedDateLabel.Location = new System.Drawing.Point(19, 100);
            this.returnedDateLabel.Name = "returnedDateLabel";
            this.returnedDateLabel.Size = new System.Drawing.Size(136, 23);
            this.returnedDateLabel.TabIndex = 1;
            this.returnedDateLabel.Text = "Returned Date : ";
            // 
            // RentCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(896, 585);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.calcTotalAmount);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "RentCalculationForm";
            this.Text = "Rent Calculation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentCalculationForm_FormClosed);
            this.Load += new System.EventHandler(this.RentCalculationForm_Load);
            this.calcTotalAmount.ResumeLayout(false);
            this.calcTotalAmount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox monthTextBox;

        public System.Windows.Forms.Label adminOrUserLabel;

        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label returnedDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calcNoOfDaysButton;
        private System.Windows.Forms.TextBox totalDaysTextBox;
        private System.Windows.Forms.TextBox monthRateTextBox;
        private System.Windows.Forms.TextBox weekTextBox;
        private System.Windows.Forms.Label totalDaysLabel;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label rentedDateLabel;
        private System.Windows.Forms.DateTimePicker returnedDateTimePicker;
        private System.Windows.Forms.DateTimePicker RentedDateTimePicker;
        private System.Windows.Forms.TextBox driverRateTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox calcTotalAmount;
        private System.Windows.Forms.TextBox weekRateTextBox;
        private System.Windows.Forms.TextBox dayRateTextBox;
        private System.Windows.Forms.Label monthRateLabel;
        private System.Windows.Forms.Label weekRateLabel;
        private System.Windows.Forms.Label driverRateLabel;
        private System.Windows.Forms.Label dayRateLabel;
        private System.Windows.Forms.CheckBox withDriverCheckBox;
        private System.Windows.Forms.ComboBox vehicleIdComboBox;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label vehicleNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Button backButton;

        private System.Windows.Forms.Button calculateTotalAmountButton;

        #endregion
    }
}