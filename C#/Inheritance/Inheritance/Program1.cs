using System;

namespace Inheritance
{
    // Base class
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }

    // Derived class Bike
    class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }
    }

}



    