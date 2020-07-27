using OITChauffer_WindowsForm.DataTypes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OITChauffer_WindowsForm.Models
{

    public class RideRequest
    {
        [Key]
        public int RideRequestId { get; set; }

        public Rider Rider { get; set; }
        public int RiderId { get; set; }

        public Chauffer Chauffer { get; set; }
        public int? ChaufferId { get; set; }

        [Required]
        [DisplayName(displayName: "Pickup Address")]
        [MaxLength(length: 255)]
        public string PickupAddress { get; set; }

        [Required]
        [DisplayName(displayName: "Destination Address")]
        [MaxLength(length: 255)]
        public string DestinationAddress { get; set; }

        [Required]
        [DisplayName(displayName: "Pickup Time")]
        public DateTime DesiredPickupTime { get; set; }

        public RideStatus RideStatus { get; set; }
    }

}
