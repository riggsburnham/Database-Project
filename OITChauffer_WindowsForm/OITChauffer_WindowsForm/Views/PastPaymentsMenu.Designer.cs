namespace OITChauffer_WindowsForm.Views
{
    partial class PastPaymentsMenu
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
            this.PastPaymentsLV = new System.Windows.Forms.ListView();
            this.AmountCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PastPaymentsLV
            // 
            this.PastPaymentsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AmountCH,
            this.TypeCH,
            this.FromCH,
            this.ToCH});
            this.PastPaymentsLV.GridLines = true;
            this.PastPaymentsLV.Location = new System.Drawing.Point(28, 29);
            this.PastPaymentsLV.Name = "PastPaymentsLV";
            this.PastPaymentsLV.Size = new System.Drawing.Size(516, 181);
            this.PastPaymentsLV.TabIndex = 0;
            this.PastPaymentsLV.UseCompatibleStateImageBehavior = false;
            this.PastPaymentsLV.View = System.Windows.Forms.View.Details;
            // 
            // AmountCH
            // 
            this.AmountCH.Text = "Amount";
            this.AmountCH.Width = 128;
            // 
            // TypeCH
            // 
            this.TypeCH.Text = "Type";
            this.TypeCH.Width = 128;
            // 
            // FromCH
            // 
            this.FromCH.Text = "From";
            this.FromCH.Width = 128;
            // 
            // ToCH
            // 
            this.ToCH.Text = "To";
            this.ToCH.Width = 128;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(416, 231);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 41);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PastPaymentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 305);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PastPaymentsLV);
            this.Name = "PastPaymentsMenu";
            this.Text = "PastPaymentsMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PastPaymentsLV;
        private System.Windows.Forms.ColumnHeader AmountCH;
        private System.Windows.Forms.ColumnHeader TypeCH;
        private System.Windows.Forms.ColumnHeader FromCH;
        private System.Windows.Forms.ColumnHeader ToCH;
        private System.Windows.Forms.Button BackButton;
    }
}