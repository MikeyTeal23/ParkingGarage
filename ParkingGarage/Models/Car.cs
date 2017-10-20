using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Models
{
    class Car : IVehicle
    {
        private Dimensions Dimensions { get; set; }
        private string Registration { get; set; }

        public Car(Dimensions dimensions, string registration)
        {
            Dimensions = dimensions;
            Registration = registration;
        }

        public Car() {}

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
