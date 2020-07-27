namespace OITChauffer_WindowsForm.Views
{
    partial class SystemAdminMainMenu
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
            this.AllRidersLV = new System.Windows.Forms.ListView();
            this.RiderIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_FirstNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_LastNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_UserNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AllChauffersLV = new System.Windows.Forms.ListView();
            this.ChaufferIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C_FirstNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C_LastNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleTypeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LicensePlateNumCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllRideRequestsLV = new System.Windows.Forms.ListView();
            this.AllNotificationsLV = new System.Windows.Forms.ListView();
            this.AllPaymentsLV = new System.Windows.Forms.ListView();
            this.AllRidersLB = new System.Windows.Forms.Label();
            this.AllChauffersLB = new System.Windows.Forms.Label();
            this.AllRideRequestsLB = new System.Windows.Forms.Label();
            this.AllNotificationsLB = new System.Windows.Forms.Label();
            this.AllPaymentsLB = new System.Windows.Forms.Label();
            this.C_UsernameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RideRequestId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RR_RiderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RR_ChaufferId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PickupTimeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PickupAddressCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationAddressCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RideStatusCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotificationIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_ChaufferIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_RiderIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_RideRequestIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriverFirstNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_VehicleTypeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_LicensePlateNumCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETACH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentTypeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.P_RideRequestId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // AllRidersLV
            // 
            this.AllRidersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RiderIdCH,
            this.R_FirstNameCH,
            this.R_LastNameCH,
            this.R_UserNameCH});
            this.AllRidersLV.GridLines = true;
            this.AllRidersLV.Location = new System.Drawing.Point(29, 34);
            this.AllRidersLV.Name = "AllRidersLV";
            this.AllRidersLV.Size = new System.Drawing.Size(461, 120);
            this.AllRidersLV.TabIndex = 0;
            this.AllRidersLV.UseCompatibleStateImageBehavior = false;
            this.AllRidersLV.View = System.Windows.Forms.View.Details;
            // 
            // RiderIdCH
            // 
            this.RiderIdCH.Text = "Rider Id";
            this.RiderIdCH.Width = 75;
            // 
            // R_FirstNameCH
            // 
            this.R_FirstNameCH.Text = "First Name";
            this.R_FirstNameCH.Width = 128;
            // 
            // R_LastNameCH
            // 
            this.R_LastNameCH.Text = "Last Name";
            this.R_LastNameCH.Width = 128;
            // 
            // R_UserNameCH
            // 
            this.R_UserNameCH.Text = "Username";
            this.R_UserNameCH.Width = 128;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(318, 882);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(171, 36);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AllChauffersLV
            // 
            this.AllChauffersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChaufferIdCH,
            this.C_FirstNameCH,
            this.C_LastNameCH,
            this.VehicleTypeCH,
            this.LicensePlateNumCH,
            this.C_UsernameCH});
            this.AllChauffersLV.GridLines = true;
            this.AllChauffersLV.Location = new System.Drawing.Point(28, 217);
            this.AllChauffersLV.Name = "AllChauffersLV";
            this.AllChauffersLV.Size = new System.Drawing.Size(462, 120);
            this.AllChauffersLV.TabIndex = 4;
            this.AllChauffersLV.UseCompatibleStateImageBehavior = false;
            this.AllChauffersLV.View = System.Windows.Forms.View.Details;
            // 
            // ChaufferIdCH
            // 
            this.ChaufferIdCH.Text = "Chauffer Id";
            this.ChaufferIdCH.Width = 75;
            // 
            // C_FirstNameCH
            // 
            this.C_FirstNameCH.Text = "First Name";
            this.C_FirstNameCH.Width = 128;
            // 
            // C_LastNameCH
            // 
            this.C_LastNameCH.Text = "Last Name";
            this.C_LastNameCH.Width = 128;
            // 
            // VehicleTypeCH
            // 
            this.VehicleTypeCH.Text = "Vehicle Type";
            this.VehicleTypeCH.Width = 128;
            // 
            // LicensePlateNumCH
            // 
            this.LicensePlateNumCH.Text = "License Plate Number";
            this.LicensePlateNumCH.Width = 150;
            // 
            // AllRideRequestsLV
            // 
            this.AllRideRequestsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RideRequestId,
            this.RR_RiderId,
            this.RR_ChaufferId,
            this.PickupTimeCH,
            this.PickupAddressCH,
            this.DestinationAddressCH,
            this.RideStatusCH});
            this.AllRideRequestsLV.GridLines = true;
            this.AllRideRequestsLV.Location = new System.Drawing.Point(29, 393);
            this.AllRideRequestsLV.Name = "AllRideRequestsLV";
            this.AllRideRequestsLV.Size = new System.Drawing.Size(461, 120);
            this.AllRideRequestsLV.TabIndex = 5;
            this.AllRideRequestsLV.UseCompatibleStateImageBehavior = false;
            this.AllRideRequestsLV.View = System.Windows.Forms.View.Details;
            // 
            // AllNotificationsLV
            // 
            this.AllNotificationsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NotificationIdCH,
            this.N_ChaufferIdCH,
            this.N_RiderIdCH,
            this.N_RideRequestIdCH,
            this.DriverFirstNameCH,
            this.N_VehicleTypeCH,
            this.N_LicensePlateNumCH,
            this.ETACH});
            this.AllNotificationsLV.GridLines = true;
            this.AllNotificationsLV.Location = new System.Drawing.Point(29, 564);
            this.AllNotificationsLV.Name = "AllNotificationsLV";
            this.AllNotificationsLV.Size = new System.Drawing.Size(461, 120);
            this.AllNotificationsLV.TabIndex = 6;
            this.AllNotificationsLV.UseCompatibleStateImageBehavior = false;
            this.AllNotificationsLV.View = System.Windows.Forms.View.Details;
            // 
            // AllPaymentsLV
            // 
            this.AllPaymentsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaymentId,
            this.P_RideRequestId,
            this.PaymentTypeCH,
            this.AmountCH});
            this.AllPaymentsLV.GridLines = true;
            this.AllPaymentsLV.Location = new System.Drawing.Point(29, 740);
            this.AllPaymentsLV.Name = "AllPaymentsLV";
            this.AllPaymentsLV.Size = new System.Drawing.Size(461, 120);
            this.AllPaymentsLV.TabIndex = 7;
            this.AllPaymentsLV.UseCompatibleStateImageBehavior = false;
            this.AllPaymentsLV.View = System.Windows.Forms.View.Details;
            // 
            // AllRidersLB
            // 
            this.AllRidersLB.AutoSize = true;
            this.AllRidersLB.Location = new System.Drawing.Point(235, 9);
            this.AllRidersLB.Name = "AllRidersLB";
            this.AllRidersLB.Size = new System.Drawing.Size(68, 17);
            this.AllRidersLB.TabIndex = 8;
            this.AllRidersLB.Text = "All Riders";
            // 
            // AllChauffersLB
            // 
            this.AllChauffersLB.AutoSize = true;
            this.AllChauffersLB.Location = new System.Drawing.Point(222, 182);
            this.AllChauffersLB.Name = "AllChauffersLB";
            this.AllChauffersLB.Size = new System.Drawing.Size(88, 17);
            this.AllChauffersLB.TabIndex = 9;
            this.AllChauffersLB.Text = "All Chauffers";
            // 
            // AllRideRequestsLB
            // 
            this.AllRideRequestsLB.AutoSize = true;
            this.AllRideRequestsLB.Location = new System.Drawing.Point(203, 356);
            this.AllRideRequestsLB.Name = "AllRideRequestsLB";
            this.AllRideRequestsLB.Size = new System.Drawing.Size(120, 17);
            this.AllRideRequestsLB.TabIndex = 10;
            this.AllRideRequestsLB.Text = "All Ride Requests";
            // 
            // AllNotificationsLB
            // 
            this.AllNotificationsLB.AutoSize = true;
            this.AllNotificationsLB.Location = new System.Drawing.Point(212, 531);
            this.AllNotificationsLB.Name = "AllNotificationsLB";
            this.AllNotificationsLB.Size = new System.Drawing.Size(104, 17);
            this.AllNotificationsLB.TabIndex = 11;
            this.AllNotificationsLB.Text = "All Notifications";
            // 
            // AllPaymentsLB
            // 
            this.AllPaymentsLB.AutoSize = true;
            this.AllPaymentsLB.Location = new System.Drawing.Point(216, 700);
            this.AllPaymentsLB.Name = "AllPaymentsLB";
            this.AllPaymentsLB.Size = new System.Drawing.Size(89, 17);
            this.AllPaymentsLB.TabIndex = 12;
            this.AllPaymentsLB.Text = "All Payments";
            // 
            // C_UsernameCH
            // 
            this.C_UsernameCH.Text = "Username";
            this.C_UsernameCH.Width = 128;
            // 
            // RideRequestId
            // 
            this.RideRequestId.Text = "Ride Request Id";
            this.RideRequestId.Width = 128;
            // 
            // RR_RiderId
            // 
            this.RR_RiderId.Text = "Rider Id";
            this.RR_RiderId.Width = 75;
            // 
            // RR_ChaufferId
            // 
            this.RR_ChaufferId.Text = "Chauffer Id";
            this.RR_ChaufferId.Width = 75;
            // 
            // PickupTimeCH
            // 
            this.PickupTimeCH.Text = "Pickup Time";
            this.PickupTimeCH.Width = 128;
            // 
            // PickupAddressCH
            // 
            this.PickupAddressCH.Text = "Pickup Address";
            this.PickupAddressCH.Width = 128;
            // 
            // DestinationAddressCH
            // 
            this.DestinationAddressCH.Text = "Destination Address";
            this.DestinationAddressCH.Width = 150;
            // 
            // RideStatusCH
            // 
            this.RideStatusCH.Text = "Ride Status";
            this.RideStatusCH.Width = 128;
            // 
            // NotificationIdCH
            // 
            this.NotificationIdCH.Text = "Notification Id";
            this.NotificationIdCH.Width = 100;
            // 
            // N_ChaufferIdCH
            // 
            this.N_ChaufferIdCH.Text = "Chauffer Id";
            this.N_ChaufferIdCH.Width = 68;
            // 
            // N_RiderIdCH
            // 
            this.N_RiderIdCH.Text = "Rider Id";
            this.N_RiderIdCH.Width = 68;
            // 
            // N_RideRequestIdCH
            // 
            this.N_RideRequestIdCH.Text = "Ride Request Id";
            this.N_RideRequestIdCH.Width = 128;
            // 
            // DriverFirstNameCH
            // 
            this.DriverFirstNameCH.Text = "Driver First Name";
            this.DriverFirstNameCH.Width = 128;
            // 
            // N_VehicleTypeCH
            // 
            this.N_VehicleTypeCH.Text = "Vehicle Type";
            this.N_VehicleTypeCH.Width = 128;
            // 
            // N_LicensePlateNumCH
            // 
            this.N_LicensePlateNumCH.Text = "License Plate Number";
            this.N_LicensePlateNumCH.Width = 150;
            // 
            // ETACH
            // 
            this.ETACH.Text = "ETA";
            this.ETACH.Width = 128;
            // 
            // PaymentId
            // 
            this.PaymentId.Text = "Payment Id";
            this.PaymentId.Width = 100;
            // 
            // PaymentTypeCH
            // 
            this.PaymentTypeCH.Text = "Payment Type";
            this.PaymentTypeCH.Width = 128;
            // 
            // AmountCH
            // 
            this.AmountCH.Text = "Amount";
            this.AmountCH.Width = 128;
            // 
            // P_RideRequestId
            // 
            this.P_RideRequestId.Text = "Ride Request Id";
            this.P_RideRequestId.Width = 128;
            // 
            // SystemAdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(553, 504);
            this.Controls.Add(this.AllPaymentsLB);
            this.Controls.Add(this.AllNotificationsLB);
            this.Controls.Add(this.AllRideRequestsLB);
            this.Controls.Add(this.AllChauffersLB);
            this.Controls.Add(this.AllRidersLB);
            this.Controls.Add(this.AllPaymentsLV);
            this.Controls.Add(this.AllNotificationsLV);
            this.Controls.Add(this.AllRideRequestsLV);
            this.Controls.Add(this.AllChauffersLV);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AllRidersLV);
            this.Name = "SystemAdminMainMenu";
            this.Text = "SystemAdminMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AllRidersLV;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.ColumnHeader RiderIdCH;
        private System.Windows.Forms.ColumnHeader R_FirstNameCH;
        private System.Windows.Forms.ColumnHeader R_LastNameCH;
        private System.Windows.Forms.ColumnHeader R_UserNameCH;
        private System.Windows.Forms.ListView AllChauffersLV;
        private System.Windows.Forms.ColumnHeader ChaufferIdCH;
        private System.Windows.Forms.ColumnHeader C_FirstNameCH;
        private System.Windows.Forms.ColumnHeader C_LastNameCH;
        private System.Windows.Forms.ColumnHeader VehicleTypeCH;
        private System.Windows.Forms.ColumnHeader LicensePlateNumCH;
        private System.Windows.Forms.ListView AllRideRequestsLV;
        private System.Windows.Forms.ListView AllNotificationsLV;
        private System.Windows.Forms.ListView AllPaymentsLV;
        private System.Windows.Forms.Label AllRidersLB;
        private System.Windows.Forms.Label AllChauffersLB;
        private System.Windows.Forms.Label AllRideRequestsLB;
        private System.Windows.Forms.Label AllNotificationsLB;
        private System.Windows.Forms.Label AllPaymentsLB;
        private System.Windows.Forms.ColumnHeader C_UsernameCH;
        private System.Windows.Forms.ColumnHeader RideRequestId;
        private System.Windows.Forms.ColumnHeader RR_RiderId;
        private System.Windows.Forms.ColumnHeader RR_ChaufferId;
        private System.Windows.Forms.ColumnHeader PickupTimeCH;
        private System.Windows.Forms.ColumnHeader PickupAddressCH;
        private System.Windows.Forms.ColumnHeader DestinationAddressCH;
        private System.Windows.Forms.ColumnHeader RideStatusCH;
        private System.Windows.Forms.ColumnHeader NotificationIdCH;
        private System.Windows.Forms.ColumnHeader N_ChaufferIdCH;
        private System.Windows.Forms.ColumnHeader N_RiderIdCH;
        private System.Windows.Forms.ColumnHeader N_RideRequestIdCH;
        private System.Windows.Forms.ColumnHeader DriverFirstNameCH;
        private System.Windows.Forms.ColumnHeader N_VehicleTypeCH;
        private System.Windows.Forms.ColumnHeader N_LicensePlateNumCH;
        private System.Windows.Forms.ColumnHeader ETACH;
        private System.Windows.Forms.ColumnHeader PaymentId;
        private System.Windows.Forms.ColumnHeader P_RideRequestId;
        private System.Windows.Forms.ColumnHeader PaymentTypeCH;
        private System.Windows.Forms.ColumnHeader AmountCH;
    }
}