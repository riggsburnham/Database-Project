using OITChauffer_WindowsForm.DataTypes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OITChauffer_WindowsForm.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        [DisplayName(displayName: "Chauffer Name")]
        [MaxLength(length: 255)]
        public string DriverFirstName { get; set; }

        [Required]
        [DisplayName(displayName: "Vehicle Type")]
        public VehicleType VehicleType { get; set; }

        [Required]
        [DisplayName(displayName: "License Plate Number")]
        [MaxLength(length: 255)]
        public string LicensePlateNum { get; set; }

        [Required]
        [DisplayName(displayName: "Estimated Time of Arrival")]
        public DateTime ETA { get; set; }

        public Chauffer Chauffer { get; set; }
        public int ChaufferId { get; set; }

        public Rider Rider { get; set; }
        public int? RiderId { get; set; }

        public RideRequest RideRequest { get; set; }
        public int? RideRequestId { get; set; }
    }

}
