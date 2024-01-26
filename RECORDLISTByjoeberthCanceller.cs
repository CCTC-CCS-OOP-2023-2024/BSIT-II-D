using System;

class Program
{
    static void Main()
    {
        // Output
        Console.WriteLine("RECORDLIST");

        // Get user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your height in feet: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Output using user input
        DisplayPersonInfo(name, age, height);

        // Comparison Operators
        if (age > 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else if (age > 12)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are a child.");
        }

        // Logical Operators
        Console.Write("Are you a student? (yes/no): ");
        bool isStudent = Console.ReadLine().ToLower() == "yes";

        Console.Write("Do you have a job? (yes/no): ");
        bool hasJob = Console.ReadLine().ToLower() == "yes";

        if (isStudent && !hasJob)
        {
            Console.WriteLine("You are a student without a job.");
        }

        // Switch Statement
        Console.Write("Enter the day of the week: ");
        string day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("It's the start of the week.");
                break;
            case "Friday":
                Console.WriteLine("It's almost the weekend!");
                break;
            default:
                Console.WriteLine("It's a regular day.");
                break;
        }

        // Ternary Operator
        Console.Write("Enter a number (x): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        string result = CompareNumbers(x, y);
        Console.WriteLine(result);

        // For Loop
        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // While Loop with break and continue
        Console.WriteLine("\nWhile Loop with break and continue:");
        int counter = 0;
        while (counter < 10)
        {
            counter++;

            if (counter % 2 == 0)
            {
                // Skip even numbers
                continue;
            }

            if (counter == 7)
            {
                // Exit the loop when counter is 7
                break;
            }

            Console.WriteLine($"Counter: {counter}");
        }
    }

    // Method to display person information
    static void DisplayPersonInfo(string personName, int personAge, double personHeight)
    {
        Console.WriteLine($"Name: {personName}, Age: {personAge}, Height: {personHeight} feet");
    }

    // Method to compare numbers and return a string
    static string CompareNumbers(int num1, int num2)
    {
        return (num1 > num2) ? "x is greater than y" : "y is greater than or equal to x";
    }
}

