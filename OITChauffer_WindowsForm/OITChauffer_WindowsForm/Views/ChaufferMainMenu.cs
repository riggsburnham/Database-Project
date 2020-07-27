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
    public partial class ChaufferMainMenu : Form
    {
        public ChaufferMainMenu()
        {
            InitializeComponent();
            WelcomeLabel.Text = "Welcome " + HomePage.CurrentUser.GetUserName();
        }

        private void CurrentRideRequestsButton_Click(object sender, EventArgs e)
        {
            RideRequestsMenu rideRequestsMenu = new RideRequestsMenu();
            rideRequestsMenu.Show();
            rideRequestsMenu.Tag = this;
            Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var homePage = (HomePage)Tag;
            homePage.Show();
            Close();
            HomePage.CurrentUser = null;
        }

        private void PastPaymentsButton_Click(object sender, EventArgs e)
        {
            PastPaymentsMenu pastPaymentsMenu = new PastPaymentsMenu();
            pastPaymentsMenu.Show();
            pastPaymentsMenu.Tag = this;
            Hide();
        }
    }
}
