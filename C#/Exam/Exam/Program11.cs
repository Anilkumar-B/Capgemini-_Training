using System;

public class ComplexNumber
{
    public double Real { get; }
    public double Imaginary { get; }

    // Constructor
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"{Real} + {Imaginary}i");
    }
}
