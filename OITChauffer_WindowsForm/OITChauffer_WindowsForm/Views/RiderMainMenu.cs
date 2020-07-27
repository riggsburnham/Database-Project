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
    public partial class RiderMainMenu : Form
    {
        public RiderMainMenu()
        {
            InitializeComponent();
            WelcomeLabel.Text = "Welcome " + HomePage.CurrentUser.GetUserName();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var homePage = (HomePage)Tag;
            homePage.Show();
            Close();
            HomePage.CurrentUser = null;
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void RequestChaufferButton_Click(object sender, EventArgs e)
        {
            RequestChaufferMenu requestChaufferMenu = new RequestChaufferMenu();
            requestChaufferMenu.Show();
            requestChaufferMenu.Tag = this;
            Hide();
        }

        private void ViewRequestNotificationsButton_Click(object sender, EventArgs e)
        {
            NotificationsMenu notificationsMenu = new NotificationsMenu();
            notificationsMenu.Show();
            notificationsMenu.Tag = this;
            Hide();
        }

        private void ViewPastPaymentsButton_Click(object sender, EventArgs e)
        {
            PastPaymentsMenu pastPaymentsMenu = new PastPaymentsMenu();
            pastPaymentsMenu.Show();
            pastPaymentsMenu.Tag = this;
            Hide();
        }
    }
}
