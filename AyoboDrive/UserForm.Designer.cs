using System.ComponentModel;

namespace AyoboDrive
{
    partial class UserForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.rentHireButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::AyoboDrive.Properties.Resources._11639594342hjraqgbufi3xlb66lt30fz1pwfcydxkjqbynfqdpvufz41ysjtngiet4dyrywgqqqqu56w5nozgrhyecs4ixrlllkl150ogbiid1;
            this.pictureBox.Location = new System.Drawing.Point(23, 61);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(179, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.headerLabel.Location = new System.Drawing.Point(147, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(218, 48);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "User Portal";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(208, 149);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(260, 50);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // rentHireButton
            // 
            this.rentHireButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.rentHireButton.FlatAppearance.BorderSize = 0;
            this.rentHireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentHireButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rentHireButton.ForeColor = System.Drawing.Color.White;
            this.rentHireButton.Location = new System.Drawing.Point(208, 93);
            this.rentHireButton.Name = "rentHireButton";
            this.rentHireButton.Size = new System.Drawing.Size(260, 50);
            this.rentHireButton.TabIndex = 1;
            this.rentHireButton.Text = "Rent\\Hire";
            this.rentHireButton.UseVisualStyleBackColor = false;
            this.rentHireButton.Click += new System.EventHandler(this.rentHireButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(493, 254);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.rentHireButton);
            this.Name = "UserForm";
            this.Text = "User Portal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button rentHireButton;

        #endregion
    }
}