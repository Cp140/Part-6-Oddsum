using System;

namespace Part_6__Oddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables.
            double count;
            double added;
            double total;
            //Variable Values.
            count = 0;
            added = 1;
            total = 1;

            //Explanes program
            Console.WriteLine("This application sums odd numbers.");
            Console.WriteLine("Enter a number to sum the numbers to.");

            //Takes user input
            double.TryParse(Console.ReadLine(), out count);

            Console.WriteLine("--------------------");
            Console.WriteLine($"{added}"); // Prints inital number one.
            for (int i = 2; i <= count; i++)
            {
            //Odd Counter.
                added = added + 2;
                total = total + added;
                Console.WriteLine($"{added}");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine($"The total is {total}");
            Console.WriteLine("--------------------");
        }
    }
}
