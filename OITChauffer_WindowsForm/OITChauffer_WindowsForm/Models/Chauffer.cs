using OITChauffer_WindowsForm.DataTypes;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OITChauffer_WindowsForm.Models
{

    public class Chauffer : IUser
    {
        [Key]
        public int ChaufferId { get; set; }

        [Required]
        [DisplayName(displayName: "First Name")]
        [MaxLength(length: 255)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName(displayName: "Last Name")]
        [MaxLength(length: 255)]
        public string LastName { get; set; }

        [DisplayName(displayName: "Vehicle Type")]
        public VehicleType VehicleType { get; set; }

        [Required]
        [DisplayName(displayName: "License Plate Number")]
        public string LicensePlateNumber { get; set; }

        [Required]
        [DisplayName(displayName: "User Name")]
        [MaxLength(length: 255)]
        public string UserName { get; set; }

        [Required]
        [DisplayName(displayName: "Password")]
        [MaxLength(length: 255)]
        public string Password { get; set; }

        // this will be the record of completed and in progress rides, driver uses this DB to find a rider
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RideRequest> RideRequests { get; set; }

        // this will be the record of completed and in progress rides, driver needs access to supply their ETA to rider
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetId()
        {
            return ChaufferId;
        }

        public string GetLicensePlateNumber()
        {
            return LicensePlateNumber;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public bool IsChauffer()
        {
            return true;
        }

        public bool IsRider()
        {
            return false;
        }

        VehicleType IUser.GetVehicleType()
        {
            return VehicleType;
        }
    }
}
