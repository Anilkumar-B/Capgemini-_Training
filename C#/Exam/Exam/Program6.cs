using System;

public class Person
{
    protected string Name;
    protected int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void GetDetails() // Virtual method
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    private string StudentID;

    public Student(string name, int age, string studentID) : base(name, age)
    {
        StudentID = studentID;
    }

    public override void GetDetails() // Overriding method
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Student ID: {StudentID}");
    }
}

public class Teacher : Person
{
    private string Subject;

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public override void GetDetails() // Overriding method
    {
        Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}

// Test Method for Demonstration
public static class PersonTester
{
    public static void TestPersons()
    {
        Person student = new Student("Alice", 20, "S12345");
        student.GetDetails(); // Calls overridden method in Student

        Person teacher = new Teacher("Mr. John", 40, "Mathematics");
        teacher.GetDetails(); // Calls overridden method in Teacher
    }
}
