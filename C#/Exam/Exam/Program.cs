
using System;

namespace Exam
{
    internal class Program
    {
        static void Main()
        {
            //Program1

            //Console.Write("Enter initial balance: ");
            //double initialBalance = Convert.ToDouble(Console.ReadLine());
            //// Create a BankAccount object and run the banking system
            //BankAccount myAccount = new BankAccount(initialBalance);
            //myAccount.Run(); // Calls the method that handles all operations

            //Program2

            //Student student = new Student();
            //student.Run(); // Calls the method to handle input and display details

            //Program3

            //Book.TestBooks();

            //Program4

            //ShapeTester.run();

            //Program5

            //VehicleTester.TestVehicles();

            //Program6

            //PersonTester.TestPersons();

            //Program7

            //Calculator.TestCalculator();

            //Program8

            //IPlayable music = new MusicPlayer();
            //music.Play();

            //IPlayable video = new VideoPlayer();
            //video.Play();

            //Program9

            //Report report = new Report("Monthly Sales Report");

            //IPrintable printable = report;
            //printable.Print();

            //ISerializable serializable = report;
            //serializable.Save();

            //Program10


            //User admin = new Admin("Alice");
            //User customer = new Customer("Bob");

            //admin.AccessControl();
            //customer.AccessControl();

            //Program11

            //ComplexNumber num1 = new ComplexNumber(3, 4);
            //ComplexNumber num2 = new ComplexNumber(1, 2);

            //ComplexNumber result = num1 + num2; // Using overloaded + operator
            //result.Display();

            //Program12

            //Department.Execute();


            //Program13

            //Bank.Execute();

            //Program14

            //SecuritySystem.Execute();

            //Program15

            //Button.Execute();

            //Program16

            //Vehicle vehicle = VehicleFactory.GetVehicle("Car");

            //// Drive the created vehicle
            //vehicle.Drive();

            //Program17

            //// Basic File Logger
            //ILogger logger = new FileLogger();
            //logger.Log("This is a basic log message.");

            //// Add Timestamp Decorator
            //ILogger timestampLogger = new TimestampLogger(logger);
            //timestampLogger.Log("This log has a timestamp.");

            //// Add Error Categorization Decorator
            //ILogger errorLogger = new ErrorCategorizationLogger(logger);
            //errorLogger.Log("This is an error log message.");

            //// Combine Timestamp and Error Categorization Decorators
            //ILogger timestampErrorLogger = new TimestampErrorLogger(logger);

            //timestampErrorLogger.Log("This log has both timestamp and error categorization.");


            //Program18

            // Access the ConfigurationManager Singleton instance
            //ConfigurationManager configManager1 = ConfigurationManager.Instance;
            //ConfigurationManager configManager2 = ConfigurationManager.Instance;

            //// Check if both references are pointing to the same instance
            //Console.WriteLine(ReferenceEquals(configManager1, configManager2)); // Output: True

            //// Set a configuration value
            //configManager1.SetConfiguration("AppMode", "Production");

            //// Get a configuration value
            //string appMode = configManager1.GetConfiguration("AppMode");
            //Console.WriteLine($"App Mode: {appMode}");

            //Program19

            //NotificationService notificationService = new NotificationService();

            //// Create observers (Email and SMS Notifiers)
            //EmailNotifier emailNotifier = new EmailNotifier();
            //SMSNotifier smsNotifier = new SMSNotifier();

            //// Attach observers to the notification service
            //notificationService.Attach(emailNotifier);
            //notificationService.Attach(smsNotifier);

            //// Set a message, which will notify all observers
            //notificationService.SetMessage("You have a new message!");

            //// Detach the SMS notifier and set a new message
            //notificationService.Detach(smsNotifier);
            //notificationService.SetMessage("New notification without SMS.");

            //Program20

            decimal totalAmount = 1000;

            // Create shopping cart with the total amount
            ShoppingCart cart = new ShoppingCart(totalAmount);

            // Show options for discount strategies
            Console.WriteLine("Select a discount strategy:");
            Console.WriteLine("1. No Discount");
            Console.WriteLine("2. Percentage Discount");
            Console.WriteLine("3. Fixed Amount Discount");
            Console.Write("Enter your choice (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            // Apply discount strategy based on user input
            switch (choice)
            {
                case 1:
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
                case 2:
                    Console.Write("Enter the percentage discount: ");
                    decimal percentage = decimal.Parse(Console.ReadLine());
                    cart.SetDiscountStrategy(new PercentageDiscount(percentage));
                    break;
                case 3:
                    Console.Write("Enter the fixed discount amount: ");
                    decimal fixedAmount = decimal.Parse(Console.ReadLine());
                    cart.SetDiscountStrategy(new FixedAmountDiscount(fixedAmount));
                    break;
                default:
                    Console.WriteLine("Invalid choice, applying no discount.");
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
            }

            // Calculate the total after applying the discount
            decimal finalAmount = cart.CalculateTotal();
            Console.WriteLine($"The final amount after discount is: {finalAmount:C}");



    }
    }
}
