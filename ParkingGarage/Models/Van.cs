using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Models
{
    class Van : IVehicle
    {
        private Dimensions Dimensions { get; set; }
        private string Registration { get; set; }

        public Dimensions GetDimensions()
        {
            return Dimensions;
        }

        public string GetRegistration()
        {
            return Registration;
        }

        public bool CanFitInSpace(ParkingSpace parkingSpace)
        {
            return (Dimensions.GetWidth() <= parkingSpace.GetDimensions().GetWidth() &&
                    Dimensions.GetLength() <= parkingSpace.GetDimensions().GetLength() &&
                    Dimensions.GetHeight() <= parkingSpace.GetDimensions().GetHeight());
        }

    }
}
