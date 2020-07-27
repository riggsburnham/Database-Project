namespace OITChauffer_WindowsForm.Views
{
    partial class RequesteeDetailsMenu
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
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("FullName");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("PickupTime");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Location");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Destination");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Type");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Amount");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Status");
            this.RiderDetailsLV = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RiderDetailsLV
            // 
            this.RiderDetailsLV.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.RiderDetailsLV.GridLines = true;
            this.RiderDetailsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RiderDetailsLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.RiderDetailsLV.Location = new System.Drawing.Point(33, 20);
            this.RiderDetailsLV.MultiSelect = false;
            this.RiderDetailsLV.Name = "RiderDetailsLV";
            this.RiderDetailsLV.Scrollable = false;
            this.RiderDetailsLV.Size = new System.Drawing.Size(375, 262);
            this.RiderDetailsLV.TabIndex = 6;
            this.RiderDetailsLV.UseCompatibleStateImageBehavior = false;
            this.RiderDetailsLV.View = System.Windows.Forms.View.Details;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(304, 300);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 36);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RequesteeDetailsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 351);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RiderDetailsLV);
            this.Name = "RequesteeDetailsMenu";
            this.Text = "RequesteeDetailsMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView RiderDetailsLV;
        private System.Windows.Forms.Button BackButton;
    }
}