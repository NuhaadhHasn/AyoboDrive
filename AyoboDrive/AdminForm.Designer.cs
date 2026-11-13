using System.ComponentModel;

namespace AyoboDrive
{
    partial class AdminForm
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
            this.addNewPackageButton = new System.Windows.Forms.Button();
            this.addNewVehicleButton = new System.Windows.Forms.Button();
            this.addNewDriveButton = new System.Windows.Forms.Button();
            this.rentHireButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewPackageButton
            // 
            this.addNewPackageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.addNewPackageButton.FlatAppearance.BorderSize = 0;
            this.addNewPackageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPackageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPackageButton.ForeColor = System.Drawing.Color.White;
            this.addNewPackageButton.Location = new System.Drawing.Point(276, 69);
            this.addNewPackageButton.Name = "addNewPackageButton";
            this.addNewPackageButton.Size = new System.Drawing.Size(214, 50);
            this.addNewPackageButton.TabIndex = 0;
            this.addNewPackageButton.Text = "Add New Package";
            this.addNewPackageButton.UseVisualStyleBackColor = false;
            this.addNewPackageButton.Click += new System.EventHandler(this.addNewPackageButton_Click);
            // 
            // addNewVehicleButton
            // 
            this.addNewVehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.addNewVehicleButton.FlatAppearance.BorderSize = 0;
            this.addNewVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewVehicleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addNewVehicleButton.ForeColor = System.Drawing.Color.White;
            this.addNewVehicleButton.Location = new System.Drawing.Point(276, 125);
            this.addNewVehicleButton.Name = "addNewVehicleButton";
            this.addNewVehicleButton.Size = new System.Drawing.Size(214, 50);
            this.addNewVehicleButton.TabIndex = 1;
            this.addNewVehicleButton.Text = "Add New Vehicle";
            this.addNewVehicleButton.UseVisualStyleBackColor = false;
            this.addNewVehicleButton.Click += new System.EventHandler(this.addNewVehicleButton_Click);
            // 
            // addNewDriveButton
            // 
            this.addNewDriveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.addNewDriveButton.FlatAppearance.BorderSize = 0;
            this.addNewDriveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewDriveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addNewDriveButton.ForeColor = System.Drawing.Color.White;
            this.addNewDriveButton.Location = new System.Drawing.Point(276, 181);
            this.addNewDriveButton.Name = "addNewDriveButton";
            this.addNewDriveButton.Size = new System.Drawing.Size(214, 50);
            this.addNewDriveButton.TabIndex = 2;
            this.addNewDriveButton.Text = "Add New Driver";
            this.addNewDriveButton.UseVisualStyleBackColor = false;
            this.addNewDriveButton.Click += new System.EventHandler(this.addNewDriveButton_Click);
            // 
            // rentHireButton
            // 
            this.rentHireButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.rentHireButton.FlatAppearance.BorderSize = 0;
            this.rentHireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentHireButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rentHireButton.ForeColor = System.Drawing.Color.White;
            this.rentHireButton.Location = new System.Drawing.Point(276, 237);
            this.rentHireButton.Name = "rentHireButton";
            this.rentHireButton.Size = new System.Drawing.Size(214, 50);
            this.rentHireButton.TabIndex = 3;
            this.rentHireButton.Text = "Rent Hire";
            this.rentHireButton.UseVisualStyleBackColor = false;
            this.rentHireButton.Click += new System.EventHandler(this.rentHireButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(276, 293);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(214, 50);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.headerLabel.Location = new System.Drawing.Point(156, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(218, 48);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Admin Portal";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::AyoboDrive.Properties.Resources.WhatsApp_Image_2022_07_25_at_1;
            this.pictureBox.Location = new System.Drawing.Point(21, 87);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(239, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 360);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.rentHireButton);
            this.Controls.Add(this.addNewDriveButton);
            this.Controls.Add(this.addNewVehicleButton);
            this.Controls.Add(this.addNewPackageButton);
            this.Name = "AdminForm";
            this.Text = "Admin Portal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Label headerLabel;

        private System.Windows.Forms.Button addNewPackageButton;
        private System.Windows.Forms.Button addNewVehicleButton;
        private System.Windows.Forms.Button addNewDriveButton;
        private System.Windows.Forms.Button rentHireButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button logOutButton;

        #endregion
    }
}