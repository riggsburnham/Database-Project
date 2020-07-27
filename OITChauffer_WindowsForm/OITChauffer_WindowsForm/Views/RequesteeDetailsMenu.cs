using OITChauffer_WindowsForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OITChauffer_WindowsForm.Views
{
    public partial class RequesteeDetailsMenu : Form
    {
        private static Rider Requestee { get; set; }
        private static Payment Payment { get; set; }
        private OITChauffer _dbContext;
        public RequesteeDetailsMenu()
        {
            _dbContext = new OITChauffer();
            InitializeComponent();

            Requestee = _dbContext.Riders.SingleOrDefault(
                    r => r.RiderId == RideRequestsMenu.Request.RiderId
                    );

            Payment = _dbContext.Payments.SingleOrDefault(
                    p => p.RideRequestId == RideRequestsMenu.Request.RideRequestId
                    );
            RiderDetailsLV.Columns.Add("Details", -2, HorizontalAlignment.Center);
            RiderDetailsLV.Items[0].Text = "Full Name: " + Requestee.GetFullName();
            RiderDetailsLV.Items[1].Text = "Pickup Time: " + RideRequestsMenu.Request.DesiredPickupTime;
            RiderDetailsLV.Items[2].Text = "Location: " + RideRequestsMenu.Request.PickupAddress;
            RiderDetailsLV.Items[3].Text = "Destination: " + RideRequestsMenu.Request.DestinationAddress;
            RiderDetailsLV.Items[4].Text = "Type: " + Payment.PaymentType.ToString();
            RiderDetailsLV.Items[5].Text = "Amount: " + Payment.Amount.ToString();
            RiderDetailsLV.Items[6].Text = "Status: " + RideRequestsMenu.Request.RideStatus;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
