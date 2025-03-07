using System.ComponentModel;

namespace Polymorphism_Practice
{
    internal class Program
    {

        //program 1 ex 1
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public double Add(double a, double b)
            {
                return a + b;
            }
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
        }

        //program 1 ex 2
        class ATM
        {
            public void Withdraw(int last4DigitscardNumber, int pin)
            {
                Console.WriteLine("Withdraw successful using Card.");
            }
            public void Withdraw(string qrCode)
            {
                Console.WriteLine("Withdraw successful using QR Code.");
            }
            public void Withdraw(long mobileNumber, int otp)
            {
                Console.WriteLine("Withdraw successful using Mobile Number.");
            }
        }

        //program 1 ex 3
        class Payment
        {
            public virtual void ProcessPayment()
            {
                Console.WriteLine("Processing payment...");
            }
        }

        class CreditCard : Payment
        {
            public override void ProcessPayment()
            {
                Console.WriteLine("Payment processed using Credit Card.");
            }
        }

        class UPI : Payment
        {
            public override void ProcessPayment()
            {
                Console.WriteLine("Payment processed using UPI.");
            }
        }

        class Crypto : Payment
        {
            public override void ProcessPayment()
            {
                Console.WriteLine("Payment processed using Cryptocurrency.");
            }
        }

        // Program 2 ex 1

        class SmartHome
        {
            // Turn on a device (TV, Lights, etc.)
            public void TurnOn(string device)
            {
                Console.WriteLine($"{device} is now ON.");
            }

            // Turn on a device with specific settings (TV with Volume)
            public void TurnOn(string device, int volume)
            {
                Console.WriteLine($"{device} is now ON with volume set to {volume}.");
            }

            // Turn on a device with mode (Lights with 'Dim' or 'Bright' mode)
            public void TurnOn(string device, string mode)
            {
                Console.WriteLine($"{device} is now ON in {mode} mode.");
            }
        }

        // Program 2 ex 2

        class Vehicle
        {
            public virtual void Move()
            {
                Console.WriteLine("Vehicle is moving...");
            }
        }

        class Car : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Car is driving on the road.");
            }
        }

        class Boat : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Boat is sailing on water.");
            }
        }

        class Airplane : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Airplane is flying in the sky.");
            }
        }
        class ShoppingCart
        {
            public void CalculateTotal(int price)
            {
                Console.WriteLine("Calculating total without discount is " + price );
            }
            public void CalculateTotal(int price,int discount)
            {
                Console.WriteLine("Calculating total with discount is "+ price*(discount/100));
            } 
        }




        static void Main(string[] args)
            {
                //Calculator calculator = new Calculator();
                //Console.WriteLine(calculator.Add(1, 4));

                //ATM atm = new ATM();
                //atm.Withdraw(1234, 1234);  // Card withdrawal
                //atm.Withdraw("QR12345");     // QR withdrawal
                //atm.Withdraw(9876543210, 5678);  // Mobile withdrawal


                Payment payment = new Payment();

                payment = new CreditCard();
                payment.ProcessPayment();  // Calls CreditCard's method

                payment = new UPI();
                payment.ProcessPayment();  // Calls UPI's method

                payment = new Crypto();
                payment.ProcessPayment();  // Calls Crypto's method


                SmartHome home = new SmartHome();

                home.TurnOn("TV");                 // Calls first method
                home.TurnOn("TV", 5);              // Calls second method
                home.TurnOn("Lights", "Dim");      // Calls third method

                Vehicle myVehicle= new Vehicle();
                myVehicle.Move();  // Calls Vehicle's Move method

                myVehicle = new Car();
                myVehicle.Move();  // Calls Car's Move method

                myVehicle = new Boat();
                myVehicle.Move();  // Calls Boat's Move method

                myVehicle = new Airplane();
                myVehicle.Move();  // Calls Airplane's Move method


        }


    }
}
