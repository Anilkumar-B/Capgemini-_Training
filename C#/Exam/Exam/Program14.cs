using System;

public sealed class SecuritySystem
{
    private string SecurityLevel;

    public SecuritySystem(string level)
    {
        SecurityLevel = level;
    }

    public void DisplaySecurityLevel()
    {
        Console.WriteLine($"Security Level: {SecurityLevel}");
    }

    public static void Execute()
    {
        SecuritySystem system = new SecuritySystem("High");
        system.DisplaySecurityLevel();

        // Uncommenting the below line will cause an error because SecuritySystem is sealed.
        // class AdvancedSecuritySystem : SecuritySystem { }
    }
}
