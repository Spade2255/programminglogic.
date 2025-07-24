using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Name: [Your Name]
        Title: IT-1050 - Lab 1
        */

        // Step 2: Basic Output
        Console.WriteLine("Name: John Doe");
        Console.WriteLine("Course: IT-1050 - Lab 1");

        // Step 3: Declare and Use Variables
        int favoriteNumber = 7;
        string favoriteLanguage = "C#";
        double programsWritten = 5.5;
        bool hasExperience = true;

        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine("Favorite Programming Language: " + favoriteLanguage);
        Console.WriteLine("Programs Written Before: " + programsWritten);
        Console.WriteLine("Has Programming Experience: " + hasExperience);

        // Step 4: Use Constants
        const string SCHOOL_NAME = "Cuyahoga Community College";
        Console.WriteLine("School Name: " + SCHOOL_NAME);

        // Step 5: Type Casting
        double originalValue = 9.78;
        int castedValue = (int)originalValue;

        int age = 30;
        string ageAsString = Convert.ToString(age);
        string experienceAsString = Convert.ToString(hasExperience);

        Console.WriteLine("Double (original): " + originalValue);
        Console.WriteLine("Int (casted): " + castedValue);
        Console.WriteLine("Int to String: " + ageAsString);
        Console.WriteLine("Bool to String: " + experienceAsString);

        // Step 6: User Input and Type Conversion
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, " + userName + "! You are " + userAge + " years old.");

        // Step 7: Arithmetic Operators
        int num1 = 12;
        int num2 = 8;

        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num2 - 2): " + (num2 - 2));
        Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("Division (num2 / 2): " + (num2 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));

        // Step 8: Floating Point Precision
        float floatValue = 1.123456789f;
        double doubleValue = 1.123456789;

        Console.WriteLine("Float value: " + floatValue);
        Console.WriteLine("Double value: " + doubleValue);

        // Step 9: Increment and Decrement
        int counter = 10;
        counter++;
        Console.WriteLine("After Increment: " + counter);
        counter--;
        Console.WriteLine("After Decrement: " + counter);
    }
}

