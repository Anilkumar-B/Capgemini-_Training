using System;

namespace Exam

{
    // Abstract Product
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    // Concrete Product 1
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }

    // Concrete Product 2
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a Bike");
        }
    }

    // Factory Class
    public class VehicleFactory
    {
        public static Vehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                return new Car();
            }
            else if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                return new Bike();
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
