using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OITChauffer_WindowsForm.DataTypes
{
    public enum PaymentType
    {
        [Display(Name = "Cash")]
        Cash = 0,
        [Display(Name = "Credit")]
        Credit = 1,
        [Display(Name = "Debit")]
        Debit = 2,
        [Display(Name = "Check")]
        Check = 3
    }
}
