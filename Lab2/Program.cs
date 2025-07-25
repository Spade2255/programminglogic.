using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------
            // Part 1: Operator Practice
            // ----------------------------------
            int a = 10, b = 5, c = 15;

            bool result1 = a > b;
            bool result2 = a < c;
            bool result3 = a > b && a > c;
            bool result4 = a > b || a > c;

            Console.WriteLine("Part 1: Operator Practice");
            Console.WriteLine($"a > b: {result1}");
            Console.WriteLine($"a < c: {result2}");
            Console.WriteLine($"a > b && a > c: {result3}");
            Console.WriteLine($"a > b || a > c: {result4}");
            Console.WriteLine();

            // ----------------------------------
            // Part 2: Boolean Logic
            // ----------------------------------
            bool isRaining = true;
            bool haveUmbrella = false;

            Console.WriteLine("Part 2: Boolean Logic");
            if (isRaining && !haveUmbrella)
            {
                Console.WriteLine("Take an umbrella!");
            }
            else
            {
                Console.WriteLine("You're good to go!");
            }
            Console.WriteLine();

            // ----------------------------------
            // Part 3: Movie Ticket Pricing
            // ----------------------------------
            Console.WriteLine("Part 3: Movie Ticket Pricing");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else
            {
                Console.WriteLine("Senior ticket: $6");
            }
            Console.WriteLine();

            // ----------------------------------
            // Part 4: Day of the Week
            // ----------------------------------
            Console.WriteLine("Part 4: Day of the Week");
            Console.Write("Enter a number (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
