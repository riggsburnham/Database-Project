using OITChauffer_WindowsForm.DataTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OITChauffer_WindowsForm.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [DisplayName(displayName: "Payment Type")]
        public PaymentType PaymentType { get; set; }

        [DisplayName(displayName: "Payment amount")]
        public decimal Amount { get; set; }
        public RideRequest RideRequest { get; set; }
        public int RideRequestId { get; set; }


    }

}
