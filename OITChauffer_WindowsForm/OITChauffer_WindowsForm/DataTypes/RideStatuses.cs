using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OITChauffer_WindowsForm.DataTypes
{
       public enum RideStatus
       {
            [Display(Name = "In Progress")]
            InProgress = 0,
            [Display(Name = "Complete")]
            Complete = 1,
            [Display(Name = "Unfulfilled")]
            Unfulfilled = 2
       }
}
