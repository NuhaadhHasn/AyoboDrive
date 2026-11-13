using System.ComponentModel;

namespace AyoboDrive
{
    partial class VehicleRentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.rentCalcButton = new System.Windows.Forms.Button();
            this.dayTourButton = new System.Windows.Forms.Button();
            this.longTourButton = new System.Windows.Forms.Button();
            this.adminOrUserLabel = new System.Windows.Forms.Label();
            this.checkGotUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.headerLabel.Location = new System.Drawing.Point(85, 11);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(111, 48);
            this.headerLabel.TabIndex = 22;
            this.headerLabel.Text = "Hiring";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(13, 230);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(260, 50);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // rentCalcButton
            // 
            this.rentCalcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.rentCalcButton.FlatAppearance.BorderSize = 0;
            this.rentCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentCalcButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rentCalcButton.ForeColor = System.Drawing.Color.White;
            this.rentCalcButton.Location = new System.Drawing.Point(13, 62);
            this.rentCalcButton.Name = "rentCalcButton";
            this.rentCalcButton.Size = new System.Drawing.Size(260, 50);
            this.rentCalcButton.TabIndex = 1;
            this.rentCalcButton.Text = "Rent Calculation";
            this.rentCalcButton.UseVisualStyleBackColor = false;
            this.rentCalcButton.Click += new System.EventHandler(this.rentCalcButton_Click);
            // 
            // dayTourButton
            // 
            this.dayTourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.dayTourButton.FlatAppearance.BorderSize = 0;
            this.dayTourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayTourButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dayTourButton.ForeColor = System.Drawing.Color.White;
            this.dayTourButton.Location = new System.Drawing.Point(13, 174);
            this.dayTourButton.Name = "dayTourButton";
            this.dayTourButton.Size = new System.Drawing.Size(260, 50);
            this.dayTourButton.TabIndex = 3;
            this.dayTourButton.Text = "Day Tour";
            this.dayTourButton.UseVisualStyleBackColor = false;
            this.dayTourButton.Click += new System.EventHandler(this.dayTourButton_Click);
            // 
            // longTourButton
            // 
            this.longTourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.longTourButton.FlatAppearance.BorderSize = 0;
            this.longTourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longTourButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.longTourButton.ForeColor = System.Drawing.Color.White;
            this.longTourButton.Location = new System.Drawing.Point(13, 118);
            this.longTourButton.Name = "longTourButton";
            this.longTourButton.Size = new System.Drawing.Size(260, 50);
            this.longTourButton.TabIndex = 2;
            this.longTourButton.Text = "Long Tour";
            this.longTourButton.UseVisualStyleBackColor = false;
            this.longTourButton.Click += new System.EventHandler(this.longTourButton_Click);
            // 
            // adminOrUserLabel
            // 
            this.adminOrUserLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminOrUserLabel.ForeColor = System.Drawing.Color.White;
            this.adminOrUserLabel.Location = new System.Drawing.Point(202, 9);
            this.adminOrUserLabel.Name = "adminOrUserLabel";
            this.adminOrUserLabel.Size = new System.Drawing.Size(85, 29);
            this.adminOrUserLabel.TabIndex = 41;
            this.adminOrUserLabel.Text = "none";
            this.adminOrUserLabel.Visible = false;
            // 
            // checkGotUserLabel
            // 
            this.checkGotUserLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkGotUserLabel.ForeColor = System.Drawing.Color.White;
            this.checkGotUserLabel.Location = new System.Drawing.Point(12, 38);
            this.checkGotUserLabel.Name = "checkGotUserLabel";
            this.checkGotUserLabel.Size = new System.Drawing.Size(67, 21);
            this.checkGotUserLabel.TabIndex = 41;
            this.checkGotUserLabel.Text = "none";
            this.checkGotUserLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "none";
            this.label1.Visible = false;
            // 
            // VehicleRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(286, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkGotUserLabel);
            this.Controls.Add(this.adminOrUserLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rentCalcButton);
            this.Controls.Add(this.dayTourButton);
            this.Controls.Add(this.longTourButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "VehicleRentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleRentForm_FormClosed);
            this.Shown += new System.EventHandler(this.VehicleRentForm_Shown);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Label label1;

        public System.Windows.Forms.Label checkGotUserLabel;

        public System.Windows.Forms.Label adminOrUserLabel;

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button rentCalcButton;
        private System.Windows.Forms.Button dayTourButton;
        private System.Windows.Forms.Button longTourButton;

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button rentHireButton;
        private System.Windows.Forms.Button button2;

        #endregion
    }
}