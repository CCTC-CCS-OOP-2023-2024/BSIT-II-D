using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Hello, C#!");

        
        int integerValue = 10;
        double doubleValue = 5.5;
        char charValue = 'A';
        bool boolValue = true;

       
        int sum = integerValue + 20;
        double product = doubleValue * 3.0;

        
        int remainder = 15 % 7;

        
        int x = 5;
        x += 10;

       
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        
        string multilineString = "This is a multiline\nstring with a tab:\tTabbed!";
        string verbatimString = @"C:\Users\John\Documents";

       
        string greeting = "Hello, " + userName + "!";
        string interpolatedGreeting = $"Hello, {userName}!";

       
        bool isEqual = integerValue == 10;

       
        if (isEqual)
        {
            Console.WriteLine("The value is 10.");
        }

       
        else if (integerValue > 10)
        {
            Console.WriteLine("The value is greater than 10.");
        }

        
        else
        {
            Console.WriteLine("The value is less than 10.");
        }

       
        bool condition1 = true;
        bool condition2 = false;

        if (condition1 && condition2)
        {
            Console.WriteLine("Both conditions are true.");
        }
        else if (condition1 || condition2)
        {
            Console.WriteLine("At least one condition is true.");
        }

      
        int dayOfWeek = 3;
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Saturday");
                break;
            case 2:
                Console.WriteLine("Sunday");
                break;
            // ... (cases for other days)
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        
        string result = (integerValue > 5) ? "Greater than 5" : "Not greater than 5";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

       
        int counter = 0;
        while (counter < 3)
        {
            Console.WriteLine(counter);
            counter++;
        }

        
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                break; // exit the loop when i is 5

            if (i % 2 == 0)
                continue; // skip even numbers

            Console.WriteLine(i);
        }

      
        SayHello();
        int resultFromMethod = AddNumbers(3, 5);
        Console.WriteLine($"Result from method: {resultFromMethod}");

      
        DisplayMessage("This is a custom message.");

        double squaredValue = Square(4);
        Console.WriteLine($"Square of 4 is: {squaredValue}");
    }

   
    static void SayHello()
    {
        Console.WriteLine("Hello from the method!");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    static double Square(double number)
    {
        return number * number;
    }
}
