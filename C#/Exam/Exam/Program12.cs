using System;

public class Manager
{
    public string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }
}

public class Department
{
    public string DeptName { get; set; }
    public Manager DeptManager { get; set; }

    public Department(string deptName, Manager manager)
    {
        DeptName = deptName;
        DeptManager = manager;
    }

    public Department ShallowCopy()
    {
        return (Department)this.MemberwiseClone();
    }

    public Department DeepCopy()
    {
        return new Department(this.DeptName, new Manager(this.DeptManager.Name));
    }

    public void Display()
    {
        Console.WriteLine($"Department: {DeptName}, Manager: {DeptManager.Name}");
    }

    public static void Execute()
    {
        Manager mgr1 = new Manager("Alice");
        Department dept1 = new Department("HR", mgr1);

        Department shallowCopy = dept1.ShallowCopy();
        Department deepCopy = dept1.DeepCopy();

        Console.WriteLine("Before Modification:");
        dept1.Display();
        shallowCopy.Display();
        deepCopy.Display();

        dept1.DeptManager.Name = "Bob";

        Console.WriteLine("\nAfter Modifying Original Manager's Name:");
        dept1.Display();
        shallowCopy.Display();
        deepCopy.Display();
    }
}
