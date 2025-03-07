using System;

public class Admin : User
{
    public Admin(string username) : base(username, "Admin") { }

    public override void AccessControl()
    {
        Console.WriteLine($"{Username} ({Role}): Full access granted. Can manage users and settings.");
    }
}
