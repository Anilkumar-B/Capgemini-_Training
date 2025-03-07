using System;

public abstract class Shape
{
    public abstract double CalculateArea();
    // Abstract Method

    public void DisplayArea()
    {
        Console.WriteLine($"Area: {CalculateArea()}");
    }
}

// Circle Class
public class Circle : Shape
{
    double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle Class
public class Rectangle : Shape
{
    double Width;
    double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Test Method for Demonstration
public static class ShapeTester
{
    public static void run()
    {
        Shape circle = new Circle(5);
        Console.WriteLine("Circle:");
        circle.DisplayArea();

        Shape rectangle = new Rectangle(4, 6);
        Console.WriteLine("Rectangle:");
        rectangle.DisplayArea();
    }
}
