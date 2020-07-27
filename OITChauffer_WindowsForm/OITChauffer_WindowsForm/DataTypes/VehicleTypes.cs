using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OITChauffer_WindowsForm.DataTypes
{
    public enum VehicleType
    {
        [Display(Name = "Sedan")]
        Sedan = 0,
        [Display(Name = "Wagon")]
        Wagon = 1,
        [Display(Name = "SUV")]
        SUV = 2,
        [Display(Name = "Truck")]
        Truck = 3,
        [Display(Name = "Sports")]
        Sports = 4,
        [Display(Name = "Hybrid")]
        Hybrid = 5,
        [Display(Name = "No Vehicle")]
        NoVehicle = 6
    }
}
