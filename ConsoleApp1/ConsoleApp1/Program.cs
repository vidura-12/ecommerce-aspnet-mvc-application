using System;

namespace myfirst
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

          
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("You didn't enter a valid name!");
                return; 
            }

           
            Console.WriteLine("How many times should I greet you?");
            string countInput = Console.ReadLine();
            int count;

            
            if (!int.TryParse(countInput, out count) || count <= 0)
            {
                Console.WriteLine("You entered an invalid number!");
                return; 
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Hello, {name}!"); 
            }


        }
    }
}
