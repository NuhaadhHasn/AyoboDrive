using System.ComponentModel;

namespace AyoboDrive
{
    partial class NewPackage
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
            this.packageRateTextBox = new System.Windows.Forms.TextBox();
            this.packageNameTextBox = new System.Windows.Forms.TextBox();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.packageRateLabel = new System.Windows.Forms.Label();
            this.maxDurationLabel = new System.Windows.Forms.Label();
            this.maxDurationLbel = new System.Windows.Forms.Label();
            this.packageNameLabel = new System.Windows.Forms.Label();
            this.packageIdLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.maxDurationTextBox = new System.Windows.Forms.TextBox();
            this.maxDistanceTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // packageRateTextBox
            // 
            this.packageRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.packageRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageRateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageRateTextBox.ForeColor = System.Drawing.Color.White;
            this.packageRateTextBox.Location = new System.Drawing.Point(246, 134);
            this.packageRateTextBox.Name = "packageRateTextBox";
            this.packageRateTextBox.Size = new System.Drawing.Size(200, 29);
            this.packageRateTextBox.TabIndex = 3;
            // 
            // packageNameTextBox
            // 
            this.packageNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.packageNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageNameTextBox.ForeColor = System.Drawing.Color.White;
            this.packageNameTextBox.Location = new System.Drawing.Point(246, 99);
            this.packageNameTextBox.Name = "packageNameTextBox";
            this.packageNameTextBox.Size = new System.Drawing.Size(200, 29);
            this.packageNameTextBox.TabIndex = 2;
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.packageIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageIdTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageIdTextBox.ForeColor = System.Drawing.Color.White;
            this.packageIdTextBox.Location = new System.Drawing.Point(246, 64);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(200, 29);
            this.packageIdTextBox.TabIndex = 1;
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.headerLabel.Location = new System.Drawing.Point(82, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(291, 48);
            this.headerLabel.TabIndex = 18;
            this.headerLabel.Text = "Add New Package";
            // 
            // packageRateLabel
            // 
            this.packageRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.packageRateLabel.ForeColor = System.Drawing.Color.White;
            this.packageRateLabel.Location = new System.Drawing.Point(12, 136);
            this.packageRateLabel.Name = "packageRateLabel";
            this.packageRateLabel.Size = new System.Drawing.Size(143, 23);
            this.packageRateLabel.TabIndex = 16;
            this.packageRateLabel.Text = "Package Rate : ";
            // 
            // maxDurationLabel
            // 
            this.maxDurationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.maxDurationLabel.ForeColor = System.Drawing.Color.White;
            this.maxDurationLabel.Location = new System.Drawing.Point(12, 206);
            this.maxDurationLabel.Name = "maxDurationLabel";
            this.maxDurationLabel.Size = new System.Drawing.Size(236, 23);
            this.maxDurationLabel.TabIndex = 12;
            this.maxDurationLabel.Text = "Maximum Duration (Hours) : ";
            // 
            // maxDurationLbel
            // 
            this.maxDurationLbel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.maxDurationLbel.ForeColor = System.Drawing.Color.White;
            this.maxDurationLbel.Location = new System.Drawing.Point(12, 171);
            this.maxDurationLbel.Name = "maxDurationLbel";
            this.maxDurationLbel.Size = new System.Drawing.Size(214, 23);
            this.maxDurationLbel.TabIndex = 11;
            this.maxDurationLbel.Text = "Maximum Distance (KM) : ";
            // 
            // packageNameLabel
            // 
            this.packageNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.packageNameLabel.ForeColor = System.Drawing.Color.White;
            this.packageNameLabel.Location = new System.Drawing.Point(12, 101);
            this.packageNameLabel.Name = "packageNameLabel";
            this.packageNameLabel.Size = new System.Drawing.Size(143, 23);
            this.packageNameLabel.TabIndex = 15;
            this.packageNameLabel.Text = "Package Name : ";
            // 
            // packageIdLabel
            // 
            this.packageIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.packageIdLabel.ForeColor = System.Drawing.Color.White;
            this.packageIdLabel.Location = new System.Drawing.Point(12, 66);
            this.packageIdLabel.Name = "packageIdLabel";
            this.packageIdLabel.Size = new System.Drawing.Size(143, 23);
            this.packageIdLabel.TabIndex = 14;
            this.packageIdLabel.Text = "Package ID : ";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(232, 295);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 50);
            this.deleteButton.TabIndex = 9;
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
            this.backButton.Location = new System.Drawing.Point(232, 351);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 50);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(12, 295);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(214, 50);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(232, 239);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(214, 50);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(12, 239);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(214, 50);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // maxDurationTextBox
            // 
            this.maxDurationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.maxDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDurationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDurationTextBox.ForeColor = System.Drawing.Color.White;
            this.maxDurationTextBox.Location = new System.Drawing.Point(246, 204);
            this.maxDurationTextBox.Name = "maxDurationTextBox";
            this.maxDurationTextBox.Size = new System.Drawing.Size(200, 29);
            this.maxDurationTextBox.TabIndex = 5;
            // 
            // maxDistanceTextBox
            // 
            this.maxDistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.maxDistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDistanceTextBox.ForeColor = System.Drawing.Color.White;
            this.maxDistanceTextBox.Location = new System.Drawing.Point(246, 169);
            this.maxDistanceTextBox.Name = "maxDistanceTextBox";
            this.maxDistanceTextBox.Size = new System.Drawing.Size(200, 29);
            this.maxDistanceTextBox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(12, 351);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(214, 50);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // NewPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(462, 420);
            this.Controls.Add(this.maxDurationTextBox);
            this.Controls.Add(this.maxDistanceTextBox);
            this.Controls.Add(this.packageRateTextBox);
            this.Controls.Add(this.packageNameTextBox);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.packageRateLabel);
            this.Controls.Add(this.maxDurationLabel);
            this.Controls.Add(this.maxDurationLbel);
            this.Controls.Add(this.packageNameLabel);
            this.Controls.Add(this.packageIdLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Name = "NewPackage";
            this.Text = "New Package";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewPackage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button clearButton;

        private System.Windows.Forms.TextBox maxDurationTextBox;
        private System.Windows.Forms.TextBox maxDistanceTextBox;

        private System.Windows.Forms.TextBox packageRateTextBox;
        private System.Windows.Forms.TextBox packageNameTextBox;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label packageRateLabel;
        private System.Windows.Forms.Label maxDurationLabel;
        private System.Windows.Forms.Label maxDurationLbel;
        private System.Windows.Forms.Label packageNameLabel;
        private System.Windows.Forms.Label packageIdLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;

        #endregion
    }
}