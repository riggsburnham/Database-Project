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
    public partial class RideRequestsMenu : Form
    {
        private OITChauffer _dbContext;
        public RideRequestsMenu()
        {
            _dbContext = new OITChauffer();
            InitializeComponent();

            // populate CurrentRequestsLV
            CurrentRequestsLV.Items.Clear();
            foreach (var rr in _dbContext.RideRequests)
            {
                var fullName = _dbContext.Riders.SingleOrDefault(
                    r => r.RiderId == rr.RiderId).GetFullName();
                    
                var row = new string[] { rr.RideRequestId.ToString(), fullName , rr.PickupAddress, rr.DestinationAddress };
                var lvi = new ListViewItem(row);
                lvi.Tag = rr;
                CurrentRequestsLV.Items.Add(lvi);
            }
        }
        public static RideRequest Request { get; set; }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            if (CurrentRequestsLV.SelectedItems.Count > 0)
            {
                var selectedRequestId = Int32.Parse(CurrentRequestsLV.SelectedItems[0].Text);

                Request = _dbContext.RideRequests.SingleOrDefault(
                        rr => rr.RideRequestId == selectedRequestId
                        );
                RequesteeDetailsMenu requesteeDetailsMenu = new RequesteeDetailsMenu();
                requesteeDetailsMenu.Show();
            }
            else
            {
                MessageBox.Show("Please select a request in order to view its details");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var chaufferMainMenu = (ChaufferMainMenu)Tag;
            chaufferMainMenu.Show();
            Close();
        }

        private static Payment Payment { get; set; }
        private void ChuafferButton_Click(object sender, EventArgs e)
        {
            if (CurrentRequestsLV.SelectedItems.Count > 0)
            {
                var selectedRequestId = Int32.Parse(CurrentRequestsLV.SelectedItems[0].Text);

                Request = _dbContext.RideRequests.SingleOrDefault(
                        rr => rr.RideRequestId == selectedRequestId
                        );

                Payment = _dbContext.Payments.SingleOrDefault(
                        p => p.RideRequestId == Request.RideRequestId
                        );

                // starting chauffer creates a notification
                var notification = new Notification
                {
                    DriverFirstName = HomePage.CurrentUser.FirstName,
                    VehicleType = HomePage.CurrentUser.GetVehicleType(),
                    LicensePlateNum = HomePage.CurrentUser.GetLicensePlateNumber(),
                    ETA = Convert.ToDateTime(ETADTP.Text),
                    ChaufferId = HomePage.CurrentUser.GetId(),
                    RiderId = Request.RiderId,
                    RideRequestId = Request.RideRequestId
                };

                // puts a chuafferId to the ride request
                Request.ChaufferId = HomePage.CurrentUser.GetId();
                Request.RideStatus = DataTypes.RideStatus.InProgress;
               

                // return to previous screen and update DB
                _dbContext.Notifications.Add(notification);
                _dbContext.SaveChanges();

                var chaufferMainMenu = (ChaufferMainMenu)Tag;
                chaufferMainMenu.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Please select a request in order to chauffer them");
            }
        }
    }
}
