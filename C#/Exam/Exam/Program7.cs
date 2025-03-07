using System;

public class Calculator
{
    // Method Overloading - Add with two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method Overloading - Add with three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method Overloading - Add with two double values
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Test Method for Demonstration
    public static void TestCalculator()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Addition of two integers: " + calc.Add(5, 10));
        Console.WriteLine("Addition of three integers: " + calc.Add(3, 7, 2));
        Console.WriteLine("Addition of two double values: " + calc.Add(4.5, 2.3));
    }
}
