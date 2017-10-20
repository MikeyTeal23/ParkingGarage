using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Models
{
    class GarageFloor : Garage
    {
        public List<ParkingSpace> ParkingSpaces { get; set; }

        public GarageFloor()
        {
            ParkingSpaces = new List<ParkingSpace>();
        }

        public void AddSpace(ParkingSpace parkingSpace)
        {
            ParkingSpaces.Add(parkingSpace);
        }
    }
}
