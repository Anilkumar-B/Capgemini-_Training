using System;
using System.Diagnostics;

namespace Day2_Programs
{
    public class Maths
    {
        // Base class method should be marked 'virtual' to allow overriding
        public virtual string Display()
        {
            return "I am a parent class";
        }
    }

    public class Algebra : Maths
    {
        // Child class method should use 'override' to properly override the parent class method
        public override string Display()
        {
            return "I am a child class";
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    Maths obj1 = new Maths();
        //    Console.WriteLine(obj1.Display());  // Calls the base class method

        //    Algebra obj2 = new Algebra();
        //    Console.WriteLine(obj2.Display());  // Calls the overridden method in the child class

        //    Maths obj3 = new Algebra();
        //    Console.WriteLine(obj3.Display());  // Runtime polymorphism: Calls the overridden method in the child class

        //    Console.ReadLine();  // Keeps console open until the user presses a key
        //}
        static void Main(String[] args)
        {
            var pros = from p in Process.GetProcesses()
                       select new { p.ProcessName, p.WorkingSet64 };
            foreach (var pro in pros)
            {
                Console.WriteLine(pro.ProcessName);
            }
            Console.ReadLine();
        }
    }
}


