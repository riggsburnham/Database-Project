using OITChauffer_WindowsForm.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OITChauffer_WindowsForm.Views
{
    public partial class NotificationsMenu : Form
    {
        private OITChauffer _dbContext;
        public NotificationsMenu()
        {
            _dbContext = new OITChauffer();
            InitializeComponent();

            // populate NotifcationsLV
            NotificationsLV.Items.Clear();
            foreach(var n in _dbContext.Notifications)
            {
                var chauffer = _dbContext.Chauffers.SingleOrDefault(
                        c => n.ChaufferId == c.ChaufferId    
                    );
                var request = _dbContext.RideRequests.SingleOrDefault(
                        r => r.RideRequestId == n.RideRequestId
                    );

                if (n.RiderId == HomePage.CurrentUser.GetId())
                {
                    var row = new string[]
                    {
                        n.NotificationId.ToString(),
                        chauffer.FirstName,
                        chauffer.VehicleType.ToString(),
                        chauffer.LicensePlateNumber,
                        n.ETA.ToString(),
                        request.RideStatus.GetType()
                            .GetMember(request.RideStatus.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName()
                };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = n;
                    NotificationsLV.Items.Add(lvi);
                }
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var riderMainMenu = (RiderMainMenu)Tag;
            riderMainMenu.Show();
            Close();
        }

        private void CompleteChaufferButton_Click(object sender, EventArgs e)
        {
            if (NotificationsLV.SelectedItems.Count > 0)
            {
                var notificationId = Int32.Parse(NotificationsLV.SelectedItems[0].Text);
                var notification = _dbContext.Notifications.SingleOrDefault(
                        n => n.NotificationId == notificationId
                    );
                var request = _dbContext.RideRequests.SingleOrDefault(
                            r => r.RideRequestId == notification.RideRequestId
                        );

                if(request.RideStatus != DataTypes.RideStatus.Complete)
                {
                    request.RideStatus = DataTypes.RideStatus.Complete;

                    // update db
                    _dbContext.SaveChanges();

                    // close window
                    var riderMainMenu = (RiderMainMenu)Tag;
                    riderMainMenu.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Notification has already been completed");
                }
            }
            else
            {
                MessageBox.Show("Please select a notification in order to complete it");
            } 
        }
    }
}
