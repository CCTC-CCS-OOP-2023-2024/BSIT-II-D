using System;
using System.Collections.Generic;

class Program
{
    static List<string> recipeNotes = new List<string>();

    static void Main()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Welcome to Recipe Notes Program!");
        Console.WriteLine("--------------------------------");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1.View Recipe Notes");
            Console.WriteLine("2. Add New Recipe Note");
            Console.WriteLine("3. Exit");

            int choice = GetUserChoice(1, 3);

            switch (choice)
            {
                case 1:
                    ViewRecipeNotes();
                    break;

                case 2:
                    AddRecipeNote();
                    break;

                case 3:
                    Console.WriteLine("Exiting Recipe Notes.\nThank you for using recipe note!!");
                    return;
            }
        }
    }

    static void ViewRecipeNotes()
    {
        Console.WriteLine("\n--- Recipe Notes ---");
        if (recipeNotes.Count == 0)
        {
            Console.WriteLine("No recipe notes available.");
        }
        else
        {
            for (int i = 0; i < recipeNotes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipeNotes[i]}");
            }
        }
    }

    static void AddRecipeNote()
    {
        Console.WriteLine("\nEnter your recipe note:");
        string newNote = Console.ReadLine();
        recipeNotes.Add(newNote);
        Console.WriteLine("Recipe added successfully!");
    }

    static int GetUserChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write("Enter choice: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }
    }

    static void DoingMathExample()
    {
        int num1 = 10;
        int num2 = 5;
        int sum = num1 + num2;
        int difference = num1 - num2;

        Console.WriteLine($"Sum: {sum}, Difference: {difference}");
    }

    static void DataTypesExample()
    {
        int intValue = 42;
        double doubleValue = 3.14;
        char charValue = 'A';

        Console.WriteLine($"Int: {intValue}, Double: {doubleValue}, Char: {charValue}");
    }

    static void ElseIfExample()
    {
        int number = 7;

        if (number > 10)
        {
            Console.WriteLine("Number is greater than 10");
        }
        else if (number > 5)
        {
            Console.WriteLine("Number is greater than 5");
        }
        else
        {
            Console.WriteLine("Number is 5 or less");
        }
    }

    static void ConcatenationAndInterpolationExample()
    {
        string name = "Alice";
        int age = 30;

        string messageConcatenation = "Name: " + name + ", Age: " + age;
        string messageInterpolation = $"Name: {name}, Age: {age}";

        Console.WriteLine(messageConcatenation);
        Console.WriteLine(messageInterpolation);
    }


    static void TernaryOperatorExample()
    {
        int number = 15;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"Number {number} is {result}");
    }
}
