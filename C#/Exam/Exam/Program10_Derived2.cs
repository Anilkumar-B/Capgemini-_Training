using System;

public class Customer : User
{
    public Customer(string username) : base(username, "Customer") { }

    public override void AccessControl()
    {
        Console.WriteLine($"{Username} ({Role}): Limited access granted. Can browse and purchase.");
    }
}
