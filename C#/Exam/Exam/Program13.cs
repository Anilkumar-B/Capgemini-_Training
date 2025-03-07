using System;

public class Bank
{
    private string AccountHolder;
    private double Balance;
    private static double InterestRate = 5.0; // Default Interest Rate

    public Bank(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public static void SetInterestRate(double rate)
    {
        InterestRate = rate;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
    }

    public static void Execute()
    {
        // Creating two accounts
        Bank acc1 = new Bank("Alice", 1000);
        Bank acc2 = new Bank("Bob", 2000);

        Console.WriteLine("Before Changing Interest Rate:");
        acc1.DisplayAccountInfo();
        acc2.DisplayAccountInfo();

        // Changing Interest Rate
        Bank.SetInterestRate(6.5);

        Console.WriteLine("\nAfter Changing Interest Rate:");
        acc1.DisplayAccountInfo();
        acc2.DisplayAccountInfo();
    }
}
