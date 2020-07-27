using OITChauffer_WindowsForm.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OITChauffer_WindowsForm.Models
{
    public interface IUser
    {
        string FirstName { get; set; }
        string GetUserName();
        string GetFullName();
        int GetId();

        bool IsRider();
        bool IsChauffer();

        VehicleType GetVehicleType();

        string GetLicensePlateNumber();
    }
}
