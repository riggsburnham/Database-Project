namespace OITChauffer_WindowsForm.Views
{
    partial class RequestChaufferMenu
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
            this.PickupTimeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.PaymentTypeLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PickupTimeTB = new System.Windows.Forms.TextBox();
            this.LocationTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PaymentTypeCB = new System.Windows.Forms.ComboBox();
            this.IncreasePickupTimeButton = new System.Windows.Forms.Button();
            this.DecreasePickupTimeButton = new System.Windows.Forms.Button();
            this.DecreaseAmountButton = new System.Windows.Forms.Button();
            this.IncreaseAmountButton = new System.Windows.Forms.Button();
            this.DestinationTB = new System.Windows.Forms.TextBox();
            this.DestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PickupTimeLabel
            // 
            this.PickupTimeLabel.AutoSize = true;
            this.PickupTimeLabel.Location = new System.Drawing.Point(43, 43);
            this.PickupTimeLabel.Name = "PickupTimeLabel";
            this.PickupTimeLabel.Size = new System.Drawing.Size(89, 17);
            this.PickupTimeLabel.TabIndex = 0;
            this.PickupTimeLabel.Text = "Pickup Time:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(43, 103);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(66, 17);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location:";
            // 
            // PaymentTypeLabel
            // 
            this.PaymentTypeLabel.AutoSize = true;
            this.PaymentTypeLabel.Location = new System.Drawing.Point(43, 194);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(99, 17);
            this.PaymentTypeLabel.TabIndex = 2;
            this.PaymentTypeLabel.Text = "PaymentType:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(43, 262);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(60, 17);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Amount:";
            // 
            // PickupTimeTB
            // 
            this.PickupTimeTB.Location = new System.Drawing.Point(148, 43);
            this.PickupTimeTB.Name = "PickupTimeTB";
            this.PickupTimeTB.Size = new System.Drawing.Size(111, 22);
            this.PickupTimeTB.TabIndex = 4;
            // 
            // LocationTB
            // 
            this.LocationTB.Location = new System.Drawing.Point(148, 100);
            this.LocationTB.Name = "LocationTB";
            this.LocationTB.Size = new System.Drawing.Size(253, 22);
            this.LocationTB.TabIndex = 5;
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(148, 262);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(111, 22);
            this.AmountTB.TabIndex = 7;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(34, 307);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 32);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(303, 307);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 32);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PaymentTypeCB
            // 
            this.PaymentTypeCB.AllowDrop = true;
            this.PaymentTypeCB.FormattingEnabled = true;
            this.PaymentTypeCB.Location = new System.Drawing.Point(148, 191);
            this.PaymentTypeCB.Name = "PaymentTypeCB";
            this.PaymentTypeCB.Size = new System.Drawing.Size(253, 24);
            this.PaymentTypeCB.TabIndex = 10;
            // 
            // IncreasePickupTimeButton
            // 
            this.IncreasePickupTimeButton.Location = new System.Drawing.Point(281, 38);
            this.IncreasePickupTimeButton.Name = "IncreasePickupTimeButton";
            this.IncreasePickupTimeButton.Size = new System.Drawing.Size(42, 32);
            this.IncreasePickupTimeButton.TabIndex = 11;
            this.IncreasePickupTimeButton.Text = "+";
            this.IncreasePickupTimeButton.UseVisualStyleBackColor = true;
            this.IncreasePickupTimeButton.Click += new System.EventHandler(this.IncreasePickupTimeButton_Click);
            // 
            // DecreasePickupTimeButton
            // 
            this.DecreasePickupTimeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecreasePickupTimeButton.Location = new System.Drawing.Point(340, 38);
            this.DecreasePickupTimeButton.Name = "DecreasePickupTimeButton";
            this.DecreasePickupTimeButton.Size = new System.Drawing.Size(42, 32);
            this.DecreasePickupTimeButton.TabIndex = 12;
            this.DecreasePickupTimeButton.Text = "-";
            this.DecreasePickupTimeButton.UseVisualStyleBackColor = true;
            this.DecreasePickupTimeButton.Click += new System.EventHandler(this.DecreasePickupTimeButton_Click);
            // 
            // DecreaseAmountButton
            // 
            this.DecreaseAmountButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecreaseAmountButton.Location = new System.Drawing.Point(340, 257);
            this.DecreaseAmountButton.Name = "DecreaseAmountButton";
            this.DecreaseAmountButton.Size = new System.Drawing.Size(42, 32);
            this.DecreaseAmountButton.TabIndex = 14;
            this.DecreaseAmountButton.Text = "-";
            this.DecreaseAmountButton.UseVisualStyleBackColor = true;
            this.DecreaseAmountButton.Click += new System.EventHandler(this.DecreaseAmountButton_Click);
            // 
            // IncreaseAmountButton
            // 
            this.IncreaseAmountButton.Location = new System.Drawing.Point(281, 257);
            this.IncreaseAmountButton.Name = "IncreaseAmountButton";
            this.IncreaseAmountButton.Size = new System.Drawing.Size(42, 32);
            this.IncreaseAmountButton.TabIndex = 13;
            this.IncreaseAmountButton.Text = "+";
            this.IncreaseAmountButton.UseVisualStyleBackColor = true;
            this.IncreaseAmountButton.Click += new System.EventHandler(this.IncreaseAmountButton_Click);
            // 
            // DestinationTB
            // 
            this.DestinationTB.Location = new System.Drawing.Point(148, 147);
            this.DestinationTB.Name = "DestinationTB";
            this.DestinationTB.Size = new System.Drawing.Size(253, 22);
            this.DestinationTB.TabIndex = 16;
            // 
            // DestionLabel
            // 
            this.DestionLabel.AutoSize = true;
            this.DestionLabel.Location = new System.Drawing.Point(43, 150);
            this.DestionLabel.Name = "DestionLabel";
            this.DestionLabel.Size = new System.Drawing.Size(83, 17);
            this.DestionLabel.TabIndex = 15;
            this.DestionLabel.Text = "Destination:";
            // 
            // RequestChaufferMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 363);
            this.Controls.Add(this.DestinationTB);
            this.Controls.Add(this.DestionLabel);
            this.Controls.Add(this.DecreaseAmountButton);
            this.Controls.Add(this.IncreaseAmountButton);
            this.Controls.Add(this.DecreasePickupTimeButton);
            this.Controls.Add(this.IncreasePickupTimeButton);
            this.Controls.Add(this.PaymentTypeCB);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.LocationTB);
            this.Controls.Add(this.PickupTimeTB);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.PaymentTypeLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.PickupTimeLabel);
            this.Name = "RequestChaufferMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PickupTimeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label PaymentTypeLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox PickupTimeTB;
        private System.Windows.Forms.TextBox LocationTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox PaymentTypeCB;
        private System.Windows.Forms.Button IncreasePickupTimeButton;
        private System.Windows.Forms.Button DecreasePickupTimeButton;
        private System.Windows.Forms.Button DecreaseAmountButton;
        private System.Windows.Forms.Button IncreaseAmountButton;
        private System.Windows.Forms.TextBox DestinationTB;
        private System.Windows.Forms.Label DestionLabel;
    }
}