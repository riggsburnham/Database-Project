using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OITChauffer_WindowsForm.Views
{
    public partial class SystemAdminMainMenu : Form
    {
        private OITChauffer _dbContext;
        public SystemAdminMainMenu()
        {
            _dbContext = new OITChauffer();
            InitializeComponent();

            // update all riders view
            foreach(var r in _dbContext.Riders)
            {
                var row = new string[]
                {
                    r.RiderId.ToString(),
                    r.FirstName,
                    r.LastName,
                    r.UserName
                };
                var lvi = new ListViewItem(row);
                lvi.Tag = r;
                AllRidersLV.Items.Add(lvi);
            }

            // update all chauffers view
            foreach (var c in _dbContext.Chauffers)
            {
                var row = new string[]
                {
                    c.ChaufferId.ToString(),
                    c.FirstName,
                    c.LastName,
                    c.VehicleType.GetType()
                        .GetMember(c.VehicleType.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .GetName(),
                    c.LicensePlateNumber,
                    c.UserName
                };
                var lvi = new ListViewItem(row);
                lvi.Tag = c;
                AllChauffersLV.Items.Add(lvi);
            }

            // update all ride requests view
            foreach (var rr in _dbContext.RideRequests)
            {
                var row = new string[]
                {
                    rr.RideRequestId.ToString(),
                    rr.RiderId.ToString(),
                    rr.ChaufferId.ToString(),
                    rr.DesiredPickupTime.ToString(),
                    rr.PickupAddress,
                    rr.DestinationAddress,
                    rr.RideStatus.GetType()
                        .GetMember(rr.RideStatus.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .GetName()
                };
                var lvi = new ListViewItem(row);
                lvi.Tag = rr;
                AllRideRequestsLV.Items.Add(lvi);
            }

            // update all notfications view
            foreach (var n in _dbContext.Notifications)
            {
                var row = new string[]
                {
                    n.NotificationId.ToString(),
                    n.ChaufferId.ToString(),
                    n.RiderId.ToString(),
                    n.RideRequestId.ToString(),
                    n.DriverFirstName,
                    n.VehicleType.GetType()
                        .GetMember(n.VehicleType.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .GetName(),
                    n.LicensePlateNum,
                    n.ETA.ToString()
                };
                var lvi = new ListViewItem(row);
                lvi.Tag = n;
                AllNotificationsLV.Items.Add(lvi);
            }

            // update all payments view
            foreach (var p in _dbContext.Payments)
            {
                var row = new string[] 
                {
                    p.PaymentId.ToString(),
                    p.RideRequestId.ToString(),
                    p.PaymentType.GetType()
                        .GetMember(p.PaymentType.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .GetName(),
                    p.Amount.ToString()
                };
                var lvi = new ListViewItem(row);
                lvi.Tag = p;
                AllPaymentsLV.Items.Add(lvi);
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var homePage = (HomePage)Tag;
            homePage.Show();
            Close();
            HomePage.CurrentUser = null;
        }
    }
}
