public class User
{
    protected string Username;
    protected string Role;

    public User(string username, string role)
    {
        Username = username;
        Role = role;
    }

    public virtual void AccessControl()
    {
        Console.WriteLine($"{Username} ({Role}): Accessing system...");
    }
}
