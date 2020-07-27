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
    public partial class HomePage : Form
    {
        public static IUser CurrentUser;

        private OITChauffer _dbContext;
        public HomePage()
        {
            InitializeComponent();
            _dbContext = new OITChauffer();
            // have password text box hide inputed characters
            PasswordTB.PasswordChar = '*';
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterNewUser registerNewUser = new RegisterNewUser();
            registerNewUser.Show();
            registerNewUser.Tag = this;
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // make sure they have the correct username and password
            var rider = _dbContext.Riders.SingleOrDefault(
                r => r.UserName.Equals(UserNameTB.Text) && r.Password.Equals(PasswordTB.Text)
                );
            var chauffer = _dbContext.Chauffers.SingleOrDefault(
                c => c.UserName.Equals(UserNameTB.Text) && c.Password.Equals(PasswordTB.Text)
                );
            var admin = _dbContext.SystemAdmins.SingleOrDefault(
                c => c.UserName.Equals(UserNameTB.Text) && c.Password.Equals(PasswordTB.Text)
                );

            if (rider == null && chauffer == null && admin == null)
            {
                MessageBox.Show("The information you entered is incorrect, Please try again.");
            }

            if (rider != null)
            {
                // for now goto rider MM for testing
                CurrentUser = rider;
                RiderMainMenu riderMainMenu = new RiderMainMenu();
                riderMainMenu.Show();
                riderMainMenu.Tag = this;
                UserNameTB.Text = string.Empty;
                PasswordTB.Text = string.Empty;
                Hide();
            }
            else if (chauffer != null)
            {
                CurrentUser = chauffer;
                ChaufferMainMenu chaufferMainMenu = new ChaufferMainMenu();
                chaufferMainMenu.Show();
                chaufferMainMenu.Tag = this;
                UserNameTB.Text = string.Empty;
                PasswordTB.Text = string.Empty;
                Hide();
            }
            else if (admin != null)
            {
                CurrentUser = admin;
                SystemAdminMainMenu adminMainMenu = new SystemAdminMainMenu();
                adminMainMenu.Show();
                adminMainMenu.Tag = this;
                UserNameTB.Text = string.Empty;
                PasswordTB.Text = string.Empty;
                Hide();
            }

        }
    }
}
