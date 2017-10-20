using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Models
{
    interface IVehicle
    {
        Dimensions GetDimensions();
        string GetRegistration();
    }
}
