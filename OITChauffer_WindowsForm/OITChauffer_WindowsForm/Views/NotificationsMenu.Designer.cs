namespace OITChauffer_WindowsForm.Views
{
    partial class NotificationsMenu
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
            this.NotificationsLV = new System.Windows.Forms.ListView();
            this.ChaufferNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleTypeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LicensePlateNumCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETACH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompleteChaufferButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.StatusCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotificationIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // NotificationsLV
            // 
            this.NotificationsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NotificationIdCH,
            this.ChaufferNameCH,
            this.VehicleTypeCH,
            this.LicensePlateNumCH,
            this.ETACH,
            this.StatusCH});
            this.NotificationsLV.FullRowSelect = true;
            this.NotificationsLV.GridLines = true;
            this.NotificationsLV.Location = new System.Drawing.Point(37, 28);
            this.NotificationsLV.Name = "NotificationsLV";
            this.NotificationsLV.Size = new System.Drawing.Size(667, 231);
            this.NotificationsLV.TabIndex = 0;
            this.NotificationsLV.UseCompatibleStateImageBehavior = false;
            this.NotificationsLV.View = System.Windows.Forms.View.Details;
            // 
            // ChaufferNameCH
            // 
            this.ChaufferNameCH.Text = "Chauffer Name";
            this.ChaufferNameCH.Width = 128;
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
            // ETACH
            // 
            this.ETACH.Text = "ETA";
            this.ETACH.Width = 128;
            // 
            // CompleteChaufferButton
            // 
            this.CompleteChaufferButton.Location = new System.Drawing.Point(524, 278);
            this.CompleteChaufferButton.Name = "CompleteChaufferButton";
            this.CompleteChaufferButton.Size = new System.Drawing.Size(180, 33);
            this.CompleteChaufferButton.TabIndex = 1;
            this.CompleteChaufferButton.Text = "Complete Chauffer";
            this.CompleteChaufferButton.UseVisualStyleBackColor = true;
            this.CompleteChaufferButton.Click += new System.EventHandler(this.CompleteChaufferButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(37, 278);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(180, 33);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StatusCH
            // 
            this.StatusCH.Text = "Status";
            this.StatusCH.Width = 128;
            // 
            // NotificationIdCH
            // 
            this.NotificationIdCH.Text = "Notification Id";
            this.NotificationIdCH.Width = 0;
            // 
            // NotificationsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 331);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CompleteChaufferButton);
            this.Controls.Add(this.NotificationsLV);
            this.Name = "NotificationsMenu";
            this.Text = "NotificationsMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView NotificationsLV;
        private System.Windows.Forms.ColumnHeader ChaufferNameCH;
        private System.Windows.Forms.ColumnHeader VehicleTypeCH;
        private System.Windows.Forms.ColumnHeader LicensePlateNumCH;
        private System.Windows.Forms.ColumnHeader ETACH;
        private System.Windows.Forms.Button CompleteChaufferButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ColumnHeader StatusCH;
        private System.Windows.Forms.ColumnHeader NotificationIdCH;
    }
}