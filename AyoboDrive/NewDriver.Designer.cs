using System.ComponentModel;

namespace AyoboDrive
{
    partial class NewDriver
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
            this.searchButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.driverIdLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.driverNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileNumberLabel = new System.Windows.Forms.Label();
            this.driverRateLabel = new System.Windows.Forms.Label();
            this.driverIdTextBox = new System.Windows.Forms.TextBox();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.mobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.driverRateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.genderComboxBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(12, 363);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(214, 50);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(12, 307);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(214, 50);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // driverIdLabel
            // 
            this.driverIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.driverIdLabel.ForeColor = System.Drawing.Color.White;
            this.driverIdLabel.Location = new System.Drawing.Point(12, 63);
            this.driverIdLabel.Name = "driverIdLabel";
            this.driverIdLabel.Size = new System.Drawing.Size(100, 23);
            this.driverIdLabel.TabIndex = 3;
            this.driverIdLabel.Text = "Driver ID : ";
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.headerLabel.Location = new System.Drawing.Point(99, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(269, 48);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Add New Driver";
            // 
            // driverNameLabel
            // 
            this.driverNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.driverNameLabel.ForeColor = System.Drawing.Color.White;
            this.driverNameLabel.Location = new System.Drawing.Point(12, 98);
            this.driverNameLabel.Name = "driverNameLabel";
            this.driverNameLabel.Size = new System.Drawing.Size(143, 23);
            this.driverNameLabel.TabIndex = 3;
            this.driverNameLabel.Text = "Driver Name : ";
            // 
            // ageLabel
            // 
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(12, 133);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(143, 23);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age : ";
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(12, 168);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(143, 23);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender : ";
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(12, 203);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(143, 23);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address : ";
            // 
            // mobileNumberLabel
            // 
            this.mobileNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mobileNumberLabel.ForeColor = System.Drawing.Color.White;
            this.mobileNumberLabel.Location = new System.Drawing.Point(12, 238);
            this.mobileNumberLabel.Name = "mobileNumberLabel";
            this.mobileNumberLabel.Size = new System.Drawing.Size(143, 23);
            this.mobileNumberLabel.TabIndex = 3;
            this.mobileNumberLabel.Text = "Mobile Number : ";
            // 
            // driverRateLabel
            // 
            this.driverRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.driverRateLabel.ForeColor = System.Drawing.Color.White;
            this.driverRateLabel.Location = new System.Drawing.Point(12, 274);
            this.driverRateLabel.Name = "driverRateLabel";
            this.driverRateLabel.Size = new System.Drawing.Size(143, 23);
            this.driverRateLabel.TabIndex = 3;
            this.driverRateLabel.Text = "Driver Rate : ";
            // 
            // driverIdTextBox
            // 
            this.driverIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverIdTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverIdTextBox.ForeColor = System.Drawing.Color.White;
            this.driverIdTextBox.Location = new System.Drawing.Point(169, 61);
            this.driverIdTextBox.Name = "driverIdTextBox";
            this.driverIdTextBox.Size = new System.Drawing.Size(277, 29);
            this.driverIdTextBox.TabIndex = 1;
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverNameTextBox.ForeColor = System.Drawing.Color.White;
            this.driverNameTextBox.Location = new System.Drawing.Point(169, 96);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.driverNameTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.Color.White;
            this.ageTextBox.Location = new System.Drawing.Point(169, 131);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(277, 29);
            this.ageTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.White;
            this.addressTextBox.Location = new System.Drawing.Point(169, 201);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(277, 29);
            this.addressTextBox.TabIndex = 5;
            // 
            // mobileNumberTextBox
            // 
            this.mobileNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.mobileNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.mobileNumberTextBox.Location = new System.Drawing.Point(169, 236);
            this.mobileNumberTextBox.Name = "mobileNumberTextBox";
            this.mobileNumberTextBox.Size = new System.Drawing.Size(277, 29);
            this.mobileNumberTextBox.TabIndex = 6;
            // 
            // driverRateTextBox
            // 
            this.driverRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.driverRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverRateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRateTextBox.ForeColor = System.Drawing.Color.White;
            this.driverRateTextBox.Location = new System.Drawing.Point(169, 272);
            this.driverRateTextBox.Name = "driverRateTextBox";
            this.driverRateTextBox.Size = new System.Drawing.Size(277, 29);
            this.driverRateTextBox.TabIndex = 7;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(232, 307);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(214, 50);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(232, 363);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 50);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(232, 421);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 50);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(12, 421);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(214, 50);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // genderComboxBox
            // 
            this.genderComboxBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.genderComboxBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderComboxBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.genderComboxBox.ForeColor = System.Drawing.Color.White;
            this.genderComboxBox.FormattingEnabled = true;
            this.genderComboxBox.Items.AddRange(new object[] { "Male", "Female" });
            this.genderComboxBox.Location = new System.Drawing.Point(169, 166);
            this.genderComboxBox.Name = "genderComboxBox";
            this.genderComboxBox.Size = new System.Drawing.Size(278, 29);
            this.genderComboxBox.TabIndex = 4;
            this.genderComboxBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.genderComboxBox_KeyUp);
            // 
            // NewDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(463, 483);
            this.Controls.Add(this.genderComboxBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.driverRateTextBox);
            this.Controls.Add(this.mobileNumberTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.driverNameTextBox);
            this.Controls.Add(this.driverIdTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.driverRateLabel);
            this.Controls.Add(this.mobileNumberLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.driverNameLabel);
            this.Controls.Add(this.driverIdLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "NewDriver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDriver_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox genderComboxBox;

        private System.Windows.Forms.Button clearButton;

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;

        private System.Windows.Forms.TextBox driverIdTextBox;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox mobileNumberTextBox;
        private System.Windows.Forms.TextBox driverRateTextBox;
        private System.Windows.Forms.Label driverIdLabel;

        private System.Windows.Forms.Label driverNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label mobileNumberLabel;

        private System.Windows.Forms.Label headerLabel;

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label driverRateLabel;

        #endregion
    }
}