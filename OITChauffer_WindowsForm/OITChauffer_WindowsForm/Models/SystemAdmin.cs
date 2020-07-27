using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OITChauffer_WindowsForm.DataTypes;

namespace OITChauffer_WindowsForm.Models
{
    public class SystemAdmin : IUser
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [DisplayName(displayName: "First Name")]
        [MaxLength(length: 255)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName(displayName: "Last Name")]
        [MaxLength(length: 255)]
        public string LastName { get; set; }

        [Required]
        [DisplayName(displayName: "User Name")]
        [MaxLength(length: 255)]
        public string UserName { get; set; }

        [Required]
        [DisplayName(displayName: "Password")]
        [MaxLength(length: 255)]
        public string Password { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetId()
        {
            return AdminId;
        }

        public string GetLicensePlateNumber()
        {
            return "empty";
        }

        public string GetUserName()
        {
            return UserName;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.NoVehicle;
        }

        public bool IsChauffer()
        {
            return false;
        }

        public bool IsRider()
        {
            return false;
        }
    }
}
