namespace OITChauffer_WindowsForm.Views
{
    partial class RideRequestsMenu
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
            this.OpenRequestsLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ChuafferButton = new System.Windows.Forms.Button();
            this.CurrentRequestsLV = new System.Windows.Forms.ListView();
            this.RideRequestId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PickupAdressCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationAddressCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetailsButton = new System.Windows.Forms.Button();
            this.ETALabel = new System.Windows.Forms.Label();
            this.ETADTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // OpenRequestsLabel
            // 
            this.OpenRequestsLabel.AutoSize = true;
            this.OpenRequestsLabel.Location = new System.Drawing.Point(304, 47);
            this.OpenRequestsLabel.Name = "OpenRequestsLabel";
            this.OpenRequestsLabel.Size = new System.Drawing.Size(111, 17);
            this.OpenRequestsLabel.TabIndex = 0;
            this.OpenRequestsLabel.Text = "Open Requests:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(56, 444);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 33);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChuafferButton
            // 
            this.ChuafferButton.Location = new System.Drawing.Point(530, 444);
            this.ChuafferButton.Name = "ChuafferButton";
            this.ChuafferButton.Size = new System.Drawing.Size(120, 33);
            this.ChuafferButton.TabIndex = 4;
            this.ChuafferButton.Text = "Chauffer";
            this.ChuafferButton.UseVisualStyleBackColor = true;
            this.ChuafferButton.Click += new System.EventHandler(this.ChuafferButton_Click);
            // 
            // CurrentRequestsLV
            // 
            this.CurrentRequestsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RideRequestId,
            this.FullNameCH,
            this.PickupAdressCH,
            this.DestinationAddressCH});
            this.CurrentRequestsLV.FullRowSelect = true;
            this.CurrentRequestsLV.GridLines = true;
            this.CurrentRequestsLV.Location = new System.Drawing.Point(56, 80);
            this.CurrentRequestsLV.Name = "CurrentRequestsLV";
            this.CurrentRequestsLV.Size = new System.Drawing.Size(594, 294);
            this.CurrentRequestsLV.TabIndex = 5;
            this.CurrentRequestsLV.TabStop = false;
            this.CurrentRequestsLV.UseCompatibleStateImageBehavior = false;
            this.CurrentRequestsLV.View = System.Windows.Forms.View.Details;
            // 
            // RideRequestId
            // 
            this.RideRequestId.Text = "Ride Request Id";
            this.RideRequestId.Width = 0;
            // 
            // FullNameCH
            // 
            this.FullNameCH.Text = "Full Name";
            this.FullNameCH.Width = 150;
            // 
            // PickupAdressCH
            // 
            this.PickupAdressCH.Text = "Pickup Address";
            this.PickupAdressCH.Width = 150;
            // 
            // DestinationAddressCH
            // 
            this.DestinationAddressCH.Text = "Destination Address";
            this.DestinationAddressCH.Width = 150;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(295, 444);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(120, 33);
            this.DetailsButton.TabIndex = 6;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // ETALabel
            // 
            this.ETALabel.AutoSize = true;
            this.ETALabel.Location = new System.Drawing.Point(142, 404);
            this.ETALabel.Name = "ETALabel";
            this.ETALabel.Size = new System.Drawing.Size(256, 17);
            this.ETALabel.TabIndex = 7;
            this.ETALabel.Text = "What is your Estimated Time of Arrival?";
            // 
            // ETADTP
            // 
            this.ETADTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ETADTP.Location = new System.Drawing.Point(436, 404);
            this.ETADTP.Name = "ETADTP";
            this.ETADTP.Size = new System.Drawing.Size(110, 22);
            this.ETADTP.TabIndex = 9;
            // 
            // RideRequestsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 499);
            this.Controls.Add(this.ETADTP);
            this.Controls.Add(this.ETALabel);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CurrentRequestsLV);
            this.Controls.Add(this.ChuafferButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OpenRequestsLabel);
            this.Name = "RideRequestsMenu";
            this.Text = "RideRequestsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpenRequestsLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ChuafferButton;
        private System.Windows.Forms.ListView CurrentRequestsLV;
        private System.Windows.Forms.ColumnHeader FullNameCH;
        private System.Windows.Forms.ColumnHeader PickupAdressCH;
        private System.Windows.Forms.ColumnHeader DestinationAddressCH;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.ColumnHeader RiderId;
        private System.Windows.Forms.ColumnHeader RideRequestId;
        private System.Windows.Forms.Label ETALabel;
        private System.Windows.Forms.DateTimePicker ETADTP;
    }
}