using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingGarage.Models
{
    class Garage
    {
        public List<GarageFloor> FloorList { get; set; }

        public Garage()
        {
            FloorList = new List<GarageFloor>();
        }

        public GarageFloor GetFloor(int floorNumber)
        {
            return FloorList[floorNumber];
        }

        public int GetFloorNumber(GarageFloor floor)
        {
            return FloorList.IndexOf(floor);
        }

        public void AddFloor(GarageFloor floor)
        {
            FloorList.Add(floor);
        }

        public List<ParkingSpace> IsSpace(Car car)
        {
            var availableSpaces = new List<ParkingSpace>();
            foreach (var floor in FloorList)
            {
                foreach (var space in floor.ParkingSpaces)
                {
                    if (!space.IsOccupied() && car.CanFitInSpace(space))
                    {
                        availableSpaces.Add(space);
                    }
                }
            }
            return availableSpaces;
        }

        public GarageFloor GetFloorFromSpace(ParkingSpace space)
        {
            return FloorList.Find(f => f.ParkingSpaces.Contains(space));
        }
    }
}
