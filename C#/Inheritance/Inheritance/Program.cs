namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Brand = "Toyota", Speed = 120, NumberOfDoors = 4 };
            Bike bike = new Bike { Brand = "Yamaha", Speed = 80, HasCarrier = true };

            car.DisplayInfo();
            Console.WriteLine($"Number of Doors: {car.NumberOfDoors}\n");

            bike.DisplayInfo();
            Console.WriteLine($"Has Carrier: {bike.HasCarrier}");
        }
    }
}
