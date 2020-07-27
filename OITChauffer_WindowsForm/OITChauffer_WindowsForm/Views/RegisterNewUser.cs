using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OITChauffer_WindowsForm.DataTypes;
using OITChauffer_WindowsForm.Models;

namespace OITChauffer_WindowsForm.Views
{
    public partial class RegisterNewUser : Form
    {
        private OITChauffer _dbContext;
        public RegisterNewUser()
        {
            InitializeComponent();

            _dbContext = new OITChauffer();

            // Get all vehicle types and populate combo box
            var values = Enum.GetValues(typeof(VehicleType));
            foreach(VehicleType vt in values)
            {
                if (vt != VehicleType.NoVehicle)
                {
                    VehicleTypeCB.Items.Add(vt.ToString());
                }
            }
            // set combo box as a dropdown list so it wont allow input
            this.VehicleTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;

            // make all chauffer steps unaccessible untill the user indicates they are a chauffer
            VehicleTypeCB.Enabled = false;
            VehicleTypeClearButton.Enabled = false;
            LicensePlateNumberTB.Enabled = false;

            // have password text box hide inputed characters
            PasswordTB.PasswordChar = '*';

        }

        private void VehicleTypeClearButton_Click(object sender, EventArgs e)
        {
            this.VehicleTypeCB.SelectedIndex = -1;
        }

        private void ChaufferYesNoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ChaufferYesNoCB.Checked)
            {
                // allow input
                VehicleTypeCB.Enabled = true;
                VehicleTypeClearButton.Enabled = true;
                LicensePlateNumberTB.Enabled = true;

            }
            else
            {
                // dont allow input
                VehicleTypeCB.Enabled = false;
                VehicleTypeClearButton.Enabled = false;
                LicensePlateNumberTB.Enabled = false;
                this.VehicleTypeCB.SelectedIndex = -1;
                LicensePlateNumberTB.Text = string.Empty;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // create the user, if they have already been created notify that they are in the system!
            bool success = false;
            if (ChaufferYesNoCB.Checked)
            {
                // The User is registering as a chauffer
                if (
                    FirstNameTB.Text == string.Empty ||
                    LastNameTB.Text == string.Empty ||
                    UserNameTB.Text == string.Empty ||
                    PasswordTB.Text == string.Empty ||
                    VehicleTypeCB.SelectedIndex == -1 ||
                    LicensePlateNumberTB.Text == string.Empty
                    )
                {
                    MessageBox.Show("Please Fill Out All Fields");
                }
                else
                {
                    var chauffer = new Chauffer
                    {
                        FirstName = FirstNameTB.Text,
                        LastName = LastNameTB.Text,
                        UserName = UserNameTB.Text,
                        Password = PasswordTB.Text,
                        VehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), VehicleTypeCB.Text),
                        LicensePlateNumber = LicensePlateNumberTB.Text
                    };
                    _dbContext.Chauffers.Add(chauffer);
                    _dbContext.SaveChanges();
                    success = true;
                }  
            }
            else
            {
                // The user is registering as a rider
                if (
                    FirstNameTB.Text == string.Empty ||
                    LastNameTB.Text == string.Empty ||
                    UserNameTB.Text == string.Empty ||
                    PasswordTB.Text == string.Empty
                    )
                {
                    MessageBox.Show("Please Fill Out All Fields");
                }
                else
                {
                    var rider = new Rider
                    {
                        FirstName = FirstNameTB.Text,
                        LastName = LastNameTB.Text,
                        UserName = UserNameTB.Text,
                        Password = PasswordTB.Text
                    };
                    _dbContext.Riders.Add(rider);
                    _dbContext.SaveChanges();
                    success = true;
                }       
            }

            // if successful update the DB and close
            if (success == true)
            {
                var homePage = (HomePage)Tag;
                homePage.Show();
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var homePage = (HomePage)Tag;
            homePage.Show();
            Close();
        }
    }
}
