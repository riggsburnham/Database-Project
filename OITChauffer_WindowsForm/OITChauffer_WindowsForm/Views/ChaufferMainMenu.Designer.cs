namespace OITChauffer_WindowsForm.Views
{
    partial class ChaufferMainMenu
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CurrentRideRequestsButton = new System.Windows.Forms.Button();
            this.PastPaymentsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(47, 34);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(66, 17);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // CurrentRideRequestsButton
            // 
            this.CurrentRideRequestsButton.Location = new System.Drawing.Point(50, 83);
            this.CurrentRideRequestsButton.Name = "CurrentRideRequestsButton";
            this.CurrentRideRequestsButton.Size = new System.Drawing.Size(191, 28);
            this.CurrentRideRequestsButton.TabIndex = 1;
            this.CurrentRideRequestsButton.Text = "Current Ride Requests";
            this.CurrentRideRequestsButton.UseVisualStyleBackColor = true;
            this.CurrentRideRequestsButton.Click += new System.EventHandler(this.CurrentRideRequestsButton_Click);
            // 
            // PastPaymentsButton
            // 
            this.PastPaymentsButton.Location = new System.Drawing.Point(50, 139);
            this.PastPaymentsButton.Name = "PastPaymentsButton";
            this.PastPaymentsButton.Size = new System.Drawing.Size(191, 28);
            this.PastPaymentsButton.TabIndex = 3;
            this.PastPaymentsButton.Text = "Past Payments";
            this.PastPaymentsButton.UseVisualStyleBackColor = true;
            this.PastPaymentsButton.Click += new System.EventHandler(this.PastPaymentsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(126, 189);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 36);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ChaufferMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 261);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PastPaymentsButton);
            this.Controls.Add(this.CurrentRideRequestsButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "ChaufferMainMenu";
            this.Text = "ChaufferMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CurrentRideRequestsButton;
        private System.Windows.Forms.Button PastPaymentsButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}