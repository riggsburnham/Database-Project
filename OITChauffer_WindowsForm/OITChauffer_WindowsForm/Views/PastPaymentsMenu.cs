using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OITChauffer_WindowsForm.Views
{
    public partial class PastPaymentsMenu : Form
    {
        private OITChauffer _dbContext;
        public PastPaymentsMenu()
        {
            _dbContext = new OITChauffer();
            InitializeComponent();

            // figure out if they are a rider or a chauffer
            List<int> rideRequestIds = new List<int>();
            foreach (var rr in _dbContext.RideRequests)
            {
                if (HomePage.CurrentUser.IsRider())
                {
                    // the user is a rider do rider stuff
                    rideRequestIds.Add(rr.RideRequestId);
                }
                else if (HomePage.CurrentUser.IsChauffer())
                {
                    // the user is a chauffer do chauffer stuff
                    rideRequestIds.Add(rr.RideRequestId);
                }
            }

            foreach(var p in _dbContext.Payments)
            {
                if (rideRequestIds.Contains(p.RideRequestId))
                {
                    var request = _dbContext.RideRequests.SingleOrDefault(
                            rr => rr.RideRequestId == p.RideRequestId
                        );

                    if (request.RiderId == HomePage.CurrentUser.GetId() || 
                        request.ChaufferId == HomePage.CurrentUser.GetId())
                    {
                        var rider = _dbContext.Riders.SingleOrDefault(
                            r => r.RiderId == request.RiderId
                        );
                        var chauffer = _dbContext.Chauffers.SingleOrDefault(
                                r => r.ChaufferId == request.ChaufferId
                            );
                        string[] row;
                        if (chauffer == null)
                        {
                            row = new string[]
                            {
                                p.Amount.ToString(),
                                p.PaymentType.GetType()
                                    .GetMember(p.PaymentType.ToString())
                                    .First()
                                    .GetCustomAttribute<DisplayAttribute>()
                                    .GetName(),
                                rider.GetFullName(),
                                "Chauffer Unassigned"
                            };
                        }
                        else
                        {
                            row = new string[]
                            {
                                p.Amount.ToString(),
                                p.PaymentType.GetType()
                                    .GetMember(p.PaymentType.ToString())
                                    .First()
                                    .GetCustomAttribute<DisplayAttribute>()
                                    .GetName(),
                                rider.GetFullName(),
                                chauffer.GetFullName()
                            };
                        }
                        var lvi = new ListViewItem(row);
                        lvi.Tag = p;
                        PastPaymentsLV.Items.Add(lvi);
                    }
                        
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (HomePage.CurrentUser.IsRider())
            {
                // the user is a rider do rider stuff
                var riderMainMenu = (RiderMainMenu)Tag;
                riderMainMenu.Show();
                Close();
            }
            else if (HomePage.CurrentUser.IsChauffer())
            {
                // the user is a chauffer do chauffer stuff
                var chaufferMainMenu = (ChaufferMainMenu)Tag;
                chaufferMainMenu.Show();
                Close();
            }
            
        }
    }
}
