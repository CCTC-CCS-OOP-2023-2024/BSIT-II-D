using System;

class NumberGuessingGame
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Number Guessing Game");

        // Generate a random number between 1 and 100
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        // Variables
        int guess;
        int attempts = 0;
        bool isGuessed = false;

        // Game Loop
        while (!isGuessed)
        {
            // Basic Concepts (Output)
            Console.Write("Enter Your Guess: ");

            // User Input
            string input = Console.ReadLine();

            // More on Strings
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please Enter a Valid Number!");
                continue;
            }

            // Data Types
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number!");
                continue;
            }

            // Doing Math
            attempts++;

            // Comparison Operators
            if (guess == secretNumber)
            {
                Console.WriteLine($"CONGRATULATIONS! YOU GUESSED THE NUMBER IN {attempts} ATTEMPTS!");
                isGuessed = true;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low. Try again!");
            }
            else
            {
                Console.WriteLine("Too high. Try again!");
            }
        }

        // Returning from Methods
        DisplayGoodbye();

        Console.ReadKey();
    }

    // Example of a method with no parameters and no return value
    static void DisplayGoodbye()
    {
        Console.WriteLine("ARIGATOGOZAIMUCH FOR PLAYING (MWAMWA KA SAKIN) !!!");
    }
}
