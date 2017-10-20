using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Models
{
     class ParkingSpace
    {
        public IVehicle ParkedVehicle { get; set; }
        public Dimensions Dimensions { get; }

        public ParkingSpace(Dimensions dimensions)
        {
            ParkedVehicle = new Car();
            Dimensions = dimensions;
        }

        public bool IsOccupied()
        {
            return ParkedVehicle == new Car();
        }

        public IVehicle GetParkedVehicle()
        {
            return ParkedVehicle;
        }

        public Dimensions GetDimensions()
        {
            return Dimensions;
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (!IsOccupied())
            {
                ParkedVehicle = vehicle;
            }
            else
            {
                Console.WriteLine("This space already contains a vehicle!");
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (IsOccupied())
            {
                ParkedVehicle = new Car();
            }
            else
            {
                Console.WriteLine("This space is already empty!");
            }
        }

        
    }
}
