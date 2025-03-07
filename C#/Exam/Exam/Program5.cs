using System;

public class Vehicle
{
    public virtual void Start() // Base method with virtual keyword
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

public class Car : Vehicle
{
    public override void Start() // Overriding Start() method
    {
        Console.WriteLine("Car is starting with a key ignition...");
    }
}

public class Bike : Vehicle
{
    public override void Start() // Overriding Start() method
    {
        Console.WriteLine("Bike is starting with a self-start button...");
    }
}

// Test Method for Demonstration
public static class VehicleTester
{
    public static void TestVehicles()
    {
        Vehicle myCar = new Car();
        myCar.Start(); // Calls overridden method in Car

        Vehicle myBike = new Bike();
        myBike.Start(); // Calls overridden method in Bike
    }
}
