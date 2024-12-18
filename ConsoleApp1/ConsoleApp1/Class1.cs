using System;

namespace ConsoleApp1
{
    class Class1
    {
        // Properties with public access
        public int Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize properties
        public Class1(int name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Class1
            Class1 person = new Class1(123, 25);

            // Access properties
            Console.WriteLine("Initial Details:");
            person.DisplayDetails();

            // Modify properties using setters
            person.Name = 456; // Now public access allows this
            person.Age = 30;

            Console.WriteLine("Updated Details:");
            person.DisplayDetails();
        }
    }
}
