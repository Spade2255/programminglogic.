using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Simple For Loop
            Console.WriteLine("Problem 1: Numbers 1 to 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Problem 2: Even Numbers from 1 to 20
            Console.WriteLine("\nProblem 2: Even Numbers from 1 to 20");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            // Problem 3: While Loop Countdown
            Console.WriteLine("\nProblem 3: Countdown from 5 to 1");
            int count = 5;
            while (count >= 1)
            {
                Console.WriteLine(count);
                count--;
            }

            // Problem 4: Multiples of 10 from 10 to 1000
            Console.WriteLine("\nProblem 4: Multiples of 10 from 10 to 1000");
            int number = 10;
            while (number <= 1000)
            {
                Console.WriteLine(number);
                number += 10;
            }

            // Problem 5: Seasons of the Year
            Console.WriteLine("\nProblem 5: Seasons of the Year");
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }

            // Problem 6: Days of the Week (1–7)
            Console.WriteLine("\nProblem 6: Day of the Week Lookup");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.Write("Enter a number from 1 to 7: ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine($"Day {dayNumber} is {days[dayNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }

            // Problem 7: Favorite Books and Authors
            Console.WriteLine("\nProblem 7: Favorite Books and Authors");
            string[] books = { "1984", "To Kill a Mockingbird", "The Hobbit" };
            string[] authors = { "George Orwell", "Harper Lee", "J.R.R. Tolkien" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{books[i]} by {authors[i]}");
            }

            // Problem 8: Temperature Tracker
            Console.WriteLine("\nProblem 8: Temperature Tracker");
            int[] temperatures = { 68, 74, 59, 80, 72 };
            Array.Sort(temperatures);
            Console.WriteLine("Sorted Temperatures:");
            foreach (int temp in temperatures)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine($"Lowest Temp: {temperatures[0]}");
            Console.WriteLine($"Highest Temp: {temperatures[temperatures.Length - 1]}");

            // Problem 9: Reverse Countdown
            Console.WriteLine("\nProblem 9: Reverse Countdown");
            int[] countdown = { 5, 4, 3, 2, 1 };
            Array.Reverse(countdown);
            for (int i = 0; i < countdown.Length; i++)
            {
                Console.WriteLine(countdown[i]);
            }
        }
    }
}
