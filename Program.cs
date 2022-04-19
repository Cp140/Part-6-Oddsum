using System;

namespace Part_6__Oddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double count;
            double added;
            //Variable Values
            count = 0;
            added = 1;

            Console.WriteLine("This Application sums odd numbers.");
            Console.WriteLine("Enter a number to sum the numbers to.");
            double.TryParse(Console.ReadLine(), out count);
            Console.WriteLine("--------------------");

            for (int i = 1; i <= count; i++)
            {
            //Odd Counter
                Console.WriteLine($"{added}");
                added = added + 2;
            }
            Console.WriteLine("--------------------");
        }
    }
}
