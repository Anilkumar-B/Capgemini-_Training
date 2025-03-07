using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_prgms
{
    public class UGStudent
    {
        // Properties of UGStudent
        public string Name { get; set; }
        public int RollNo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of UGStudent objects

            List<UGStudent> students = new List<UGStudent>
        {
            new UGStudent() { Name = "Anu", RollNo = 1 },
            new UGStudent() { Name = "Bnu", RollNo = 2 },
            new UGStudent() { Name = "Cnu", RollNo = 3 },
            new UGStudent() { Name = "Dnu", RollNo = 4 },
            new UGStudent() { Name = "Enu", RollNo = 5 }
        };

            // LINQ query to filter students with RollNo >= 2 and select their names
            var filteredNames = from student in students
                                where student.RollNo >= 2
                                select student.Name;

            // Display filtered names
            Console.WriteLine("Students with RollNo >= 2:");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }

            // Keep the console open (for debugging purposes)
            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey();
        }
    }

}