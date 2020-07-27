namespace OITChauffer_WindowsForm.Views
{
    partial class RiderMainMenu
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
            this.ViewRequestNotificationsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.RequestChaufferButton = new System.Windows.Forms.Button();
            this.ViewPastPaymentsButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewRequestNotificationsButton
            // 
            this.ViewRequestNotificationsButton.Location = new System.Drawing.Point(36, 163);
            this.ViewRequestNotificationsButton.Name = "ViewRequestNotificationsButton";
            this.ViewRequestNotificationsButton.Size = new System.Drawing.Size(376, 30);
            this.ViewRequestNotificationsButton.TabIndex = 3;
            this.ViewRequestNotificationsButton.Text = "Requests Notifications";
            this.ViewRequestNotificationsButton.UseVisualStyleBackColor = true;
            this.ViewRequestNotificationsButton.Click += new System.EventHandler(this.ViewRequestNotificationsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(337, 219);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 39);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // RequestChaufferButton
            // 
            this.RequestChaufferButton.Location = new System.Drawing.Point(36, 68);
            this.RequestChaufferButton.Name = "RequestChaufferButton";
            this.RequestChaufferButton.Size = new System.Drawing.Size(376, 30);
            this.RequestChaufferButton.TabIndex = 5;
            this.RequestChaufferButton.Text = "Request Chauffer";
            this.RequestChaufferButton.UseVisualStyleBackColor = true;
            this.RequestChaufferButton.Click += new System.EventHandler(this.RequestChaufferButton_Click);
            // 
            // ViewPastPaymentsButton
            // 
            this.ViewPastPaymentsButton.Location = new System.Drawing.Point(36, 116);
            this.ViewPastPaymentsButton.Name = "ViewPastPaymentsButton";
            this.ViewPastPaymentsButton.Size = new System.Drawing.Size(376, 30);
            this.ViewPastPaymentsButton.TabIndex = 6;
            this.ViewPastPaymentsButton.Text = "Past Payments";
            this.ViewPastPaymentsButton.UseVisualStyleBackColor = true;
            this.ViewPastPaymentsButton.Click += new System.EventHandler(this.ViewPastPaymentsButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(119, 20);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(66, 17);
            this.WelcomeLabel.TabIndex = 7;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // RiderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 281);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ViewPastPaymentsButton);
            this.Controls.Add(this.RequestChaufferButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ViewRequestNotificationsButton);
            this.Name = "RiderMainMenu";
            this.Text = "RiderMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewRequestNotificationsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button RequestChaufferButton;
        private System.Windows.Forms.Button ViewPastPaymentsButton;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}