using System;

namespace Exam
{
    public class BankAccount
    {
        private double balance; // Private field (Encapsulation)

        // Constructor to set initial balance
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Enter a positive value.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else if (amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount}. New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Enter a positive value.");
            }
        }

        // Method to check balance
        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: ${balance}");
        }

        // Method to handle user interaction
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        Deposit(depositAmount);
                        break;

                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        Withdraw(withdrawAmount);
                        break;

                    case 3:
                        ShowBalance();
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the banking system. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
