using System;
using ParkingGarage.Models;

namespace ParkingGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            GarageFloor garageFloor = new GarageFloor();
            Dimensions dimensions = new Dimensions(1,1,1);
            ParkingSpace parkingSpace = new ParkingSpace(dimensions);

            garageFloor.AddSpace(parkingSpace);

            for (int i = 0; i < 1; i++)
            {
                garage.AddFloor(garageFloor);
            }

            Car car = new Car(dimensions, "DRIV3R");

            garage.FloorList[0].ParkingSpaces[0].AddVehicle(car);

            foreach (var space in garage.IsSpace(car))
            {
                Console.WriteLine("There is a space on floor");
                Console.WriteLine(garage.GetFloorNumber(garage.GetFloorFromSpace(space)));
            };

        }
    }
}
