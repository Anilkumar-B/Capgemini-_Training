using System;

public class Book
{
    string Title;
    string Author;
    string ISBN;


    //Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        ISBN = "000-0000000000";
    }

    // Constructor with Title and Author
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        //ISBN = "000-0000000000"; // Default ISBN
    }

    // Constructor with Title, Author, and ISBN
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
    }

    public static void TestBooks()
    {
         //Using Default Constructor
        Book book1 = new Book();
        book1.DisplayBookInfo();

        // Using Constructor with Title and Author
        Book book2 = new Book("C_#", "Suraj");
        book2.DisplayBookInfo();

        // Using Constructor with Title, Author, and ISBN
        Book book3 = new Book("C_#", "Vishnu","9944454");
        book3.DisplayBookInfo();
    }
}
