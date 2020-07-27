using OITChauffer_WindowsForm.DataTypes;
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
    public partial class RequestChaufferMenu : Form
    {
        private OITChauffer _dbContext;
        public RequestChaufferMenu()
        {
            InitializeComponent();

            _dbContext = new OITChauffer();

            // Round up to the nearest half hour
            var currentTime = DateTime.Now;
            if (currentTime.Minute < 30 && currentTime.Minute != 0)
            {
                var timeIncrement = 30 - currentTime.Minute;
                currentTime = currentTime.AddMinutes(timeIncrement);
            }
            else if (currentTime.Minute > 30)
            {
                var timeIncrement = 60 - currentTime.Minute;
                currentTime = currentTime.AddMinutes(timeIncrement);
            }
            PickupTimeTB.Text = currentTime.ToShortTimeString();

            // They can only edit the pickuptime through the buttons
            PickupTimeTB.Enabled = false;

            // Get all vehicle types and populate combo box
            var values = Enum.GetValues(typeof(PaymentType));
            foreach (PaymentType pt in values)
            {
                PaymentTypeCB.Items.Add(pt.ToString());
            }
            // set combo box as a dropdown list so it wont allow input
            this.PaymentTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;

            // Can only edit price through buttons
            AmountTB.Enabled = false;
            AmountTB.Text = "0.00";
        }

        private void IncreasePickupTimeButton_Click(object sender, EventArgs e)
        {
            var currentPickupTime = Convert.ToDateTime(PickupTimeTB.Text);
            currentPickupTime = currentPickupTime.AddMinutes(5);
            PickupTimeTB.Text = currentPickupTime.ToShortTimeString();
        }

        private void DecreasePickupTimeButton_Click(object sender, EventArgs e)
        {
            var currentPickupTime = Convert.ToDateTime(PickupTimeTB.Text);
            currentPickupTime = currentPickupTime.AddMinutes(-5);
            PickupTimeTB.Text = currentPickupTime.ToShortTimeString();
        }

        private void IncreaseAmountButton_Click(object sender, EventArgs e)
        {
            var currentAmount = Double.Parse(AmountTB.Text);
            currentAmount += 5;
            AmountTB.Text = currentAmount.ToString("n2");
        }

        private void DecreaseAmountButton_Click(object sender, EventArgs e)
        {
            var currentAmount = Double.Parse(AmountTB.Text);
            currentAmount -= 5;
            AmountTB.Text = currentAmount.ToString("n2");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (
                PickupTimeTB.Text == string.Empty ||
                LocationTB.Text == string.Empty ||
                DestinationTB.Text == string.Empty ||
                PaymentTypeCB.Text == string.Empty ||
                AmountTB.Text == string.Empty
                )
            {
                MessageBox.Show("Please Fill Out All Fields");
            }
            else
            {

                // ride requests also have payments
                var rideRequest = new RideRequest
                {
                    RiderId = HomePage.CurrentUser.GetId(),
                    PickupAddress = LocationTB.Text,
                    DestinationAddress = DestinationTB.Text,
                    DesiredPickupTime = Convert.ToDateTime(PickupTimeTB.Text),
                    RideStatus = RideStatus.Unfulfilled,
                    ChaufferId = null
                };

                // set up payment.
                var payment = new Payment
                {
                    RideRequestId = rideRequest.RideRequestId,
                    PaymentType = (PaymentType)Enum.Parse(typeof(PaymentType), PaymentTypeCB.Text),
                    Amount = Decimal.Parse(AmountTB.Text),
                };

                // update database
                _dbContext.RideRequests.Add(rideRequest);
                _dbContext.Payments.Add(payment);
                _dbContext.SaveChanges();

                // close window
                var riderMainMenu = (RiderMainMenu)Tag;
                riderMainMenu.Show();
                Close();
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var riderMainMenu = (RiderMainMenu)Tag;
            riderMainMenu.Show();
            Close();
        }


    }
}
