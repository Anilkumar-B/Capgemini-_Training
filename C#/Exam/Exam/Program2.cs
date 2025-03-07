using System;

namespace Exam
{
    public class Student
    {
        private string name;  // Private field for Name
        private int rollNo;   // Private field for RollNo

        // Property for Name with validation
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // Ensure name is not empty
                    name = value;
                else
                    Console.WriteLine("Invalid Name! Name cannot be empty.");
            }
        }

        // Property for RollNo with validation
        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0) // Ensure roll number is positive
                    rollNo = value;
                else
                    Console.WriteLine("Invalid Roll Number! It must be positive.");
            }
        }

        // Method to get user input
        public void GetStudentDetails()
        {
            while (true)
            {
                Console.Write("Enter Student Name: ");
                string inputName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputName))
                {
                    Name = inputName;
                    break; // Exit loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid Name! Name cannot be empty. Please enter again.");
                }
            }

            // Validate Roll Number Input
            while (true)
            {
                Console.Write("Enter Roll Number: ");
                if (int.TryParse(Console.ReadLine(), out int inputRollNo) && inputRollNo > 0)
                {
                    RollNo = inputRollNo;
                    break; // Exit loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid Roll Number! It must be a positive integer. Please enter again.");
                }
            }
        }

        // Method to display student details
        public void ShowDetails()
        {
            Console.WriteLine($"\nStudent Details:\nName: {name}\nRoll No: {rollNo}");
        }

        // Method to execute student input and display details
        public void Run()
        {
            GetStudentDetails();
            ShowDetails();
        }
    }
}
