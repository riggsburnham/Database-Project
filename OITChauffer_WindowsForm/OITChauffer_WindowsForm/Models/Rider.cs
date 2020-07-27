using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OITChauffer_WindowsForm.DataTypes;

namespace OITChauffer_WindowsForm.Models
{
    public class Rider : IUser
    {
        [Key]
        public int RiderId { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        public Rider()
        {
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public int GetId()
        {
            return RiderId;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.NoVehicle;
        }

        public string GetLicensePlateNumber()
        {
            return "empty";
        }

        public bool IsRider()
        {
            return true;
        }

        public bool IsChauffer()
        {
            return false;
        }
    }

}
