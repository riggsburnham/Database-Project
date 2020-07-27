namespace OITChauffer_WindowsForm.Views
{
    partial class RegisterNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ChaufferYesNoLabel = new System.Windows.Forms.Label();
            this.RequiredFieldsLabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.LicensePlateNumberLabel = new System.Windows.Forms.Label();
            this.ChaufferYesNoCB = new System.Windows.Forms.CheckBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.LicensePlateNumberTB = new System.Windows.Forms.TextBox();
            this.VehicleTypeCB = new System.Windows.Forms.ComboBox();
            this.VehicleTypeClearButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(33, 32);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(33, 77);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // ChaufferYesNoLabel
            // 
            this.ChaufferYesNoLabel.AutoSize = true;
            this.ChaufferYesNoLabel.Location = new System.Drawing.Point(33, 211);
            this.ChaufferYesNoLabel.Name = "ChaufferYesNoLabel";
            this.ChaufferYesNoLabel.Size = new System.Drawing.Size(133, 17);
            this.ChaufferYesNoLabel.TabIndex = 2;
            this.ChaufferYesNoLabel.Text = "Are you a chauffer?";
            // 
            // RequiredFieldsLabel
            // 
            this.RequiredFieldsLabel.AutoSize = true;
            this.RequiredFieldsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.RequiredFieldsLabel.Location = new System.Drawing.Point(52, 259);
            this.RequiredFieldsLabel.Name = "RequiredFieldsLabel";
            this.RequiredFieldsLabel.Size = new System.Drawing.Size(249, 17);
            this.RequiredFieldsLabel.TabIndex = 3;
            this.RequiredFieldsLabel.Text = "Only fill out below if you are a chauffer";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(33, 307);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(94, 17);
            this.VehicleTypeLabel.TabIndex = 4;
            this.VehicleTypeLabel.Text = "Vehicle Type:";
            // 
            // LicensePlateNumberLabel
            // 
            this.LicensePlateNumberLabel.AutoSize = true;
            this.LicensePlateNumberLabel.Location = new System.Drawing.Point(33, 358);
            this.LicensePlateNumberLabel.Name = "LicensePlateNumberLabel";
            this.LicensePlateNumberLabel.Size = new System.Drawing.Size(151, 17);
            this.LicensePlateNumberLabel.TabIndex = 5;
            this.LicensePlateNumberLabel.Text = "License Plate Number:";
            // 
            // ChaufferYesNoCB
            // 
            this.ChaufferYesNoCB.AutoSize = true;
            this.ChaufferYesNoCB.Location = new System.Drawing.Point(186, 212);
            this.ChaufferYesNoCB.Name = "ChaufferYesNoCB";
            this.ChaufferYesNoCB.Size = new System.Drawing.Size(18, 17);
            this.ChaufferYesNoCB.TabIndex = 6;
            this.ChaufferYesNoCB.UseVisualStyleBackColor = true;
            this.ChaufferYesNoCB.CheckedChanged += new System.EventHandler(this.ChaufferYesNoCB_CheckedChanged);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(119, 32);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(203, 22);
            this.FirstNameTB.TabIndex = 7;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(119, 77);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(203, 22);
            this.LastNameTB.TabIndex = 8;
            // 
            // LicensePlateNumberTB
            // 
            this.LicensePlateNumberTB.Location = new System.Drawing.Point(190, 358);
            this.LicensePlateNumberTB.Name = "LicensePlateNumberTB";
            this.LicensePlateNumberTB.Size = new System.Drawing.Size(132, 22);
            this.LicensePlateNumberTB.TabIndex = 9;
            // 
            // VehicleTypeCB
            // 
            this.VehicleTypeCB.AllowDrop = true;
            this.VehicleTypeCB.FormattingEnabled = true;
            this.VehicleTypeCB.Location = new System.Drawing.Point(133, 307);
            this.VehicleTypeCB.Name = "VehicleTypeCB";
            this.VehicleTypeCB.Size = new System.Drawing.Size(108, 24);
            this.VehicleTypeCB.TabIndex = 10;
            // 
            // VehicleTypeClearButton
            // 
            this.VehicleTypeClearButton.Location = new System.Drawing.Point(247, 307);
            this.VehicleTypeClearButton.Name = "VehicleTypeClearButton";
            this.VehicleTypeClearButton.Size = new System.Drawing.Size(75, 24);
            this.VehicleTypeClearButton.TabIndex = 11;
            this.VehicleTypeClearButton.Text = "Clear";
            this.VehicleTypeClearButton.UseVisualStyleBackColor = true;
            this.VehicleTypeClearButton.Click += new System.EventHandler(this.VehicleTypeClearButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(224, 416);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(98, 31);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(36, 416);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 31);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(120, 164);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(202, 22);
            this.PasswordTB.TabIndex = 17;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(120, 119);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(202, 22);
            this.UserNameTB.TabIndex = 16;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(34, 164);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(34, 119);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(83, 17);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "User Name:";
            // 
            // RegisterNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 482);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.VehicleTypeClearButton);
            this.Controls.Add(this.VehicleTypeCB);
            this.Controls.Add(this.LicensePlateNumberTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.ChaufferYesNoCB);
            this.Controls.Add(this.LicensePlateNumberLabel);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.RequiredFieldsLabel);
            this.Controls.Add(this.ChaufferYesNoLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "RegisterNewUser";
            this.Text = "RegisterNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label ChaufferYesNoLabel;
        private System.Windows.Forms.Label RequiredFieldsLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label LicensePlateNumberLabel;
        private System.Windows.Forms.CheckBox ChaufferYesNoCB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox LicensePlateNumberTB;
        private System.Windows.Forms.ComboBox VehicleTypeCB;
        private System.Windows.Forms.Button VehicleTypeClearButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
    }
}