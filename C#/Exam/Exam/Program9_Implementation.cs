using System;

public class Report : IPrintable, ISerializable
{
    private string content;

    public Report(string content)
    {
        this.content = content;
    }

    public void Print()
    {
        Console.WriteLine("Printing Report: " + content);
    }

    public void Save()
    {
        Console.WriteLine("Saving Report to file: " + content);
    }
}
