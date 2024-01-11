using System;

class BurgerKingProgram
{
    static void Main()
    {
        // Variables and Data Types
        string appName = "Burger King App";
        int customerAge = 0;
        double totalPrice = 0.0;

        // Introduction
        Console.WriteLine($"Welcome to {appName}!");

        // User Input
        Console.Write("Enter your name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        // Parsing user input
        if (!int.TryParse(ageInput, out customerAge))
        {
            Console.WriteLine("Invalid age input. Please enter a valid number.");
            return;
        }

        // if Statement
        if (customerAge < 18)
        {
            Console.WriteLine("Welcome, young customer!");
        }
        else
        {
            Console.WriteLine("Hello, adult customer!");
        }

        // Menu Loop
        while (true)
        {
            // Display Menu
            DisplayMenu();

            // User Input
            Console.Write("Enter your choice (1-3, 0 to exit): ");
            string input = Console.ReadLine();

            // Parsing user input
            int userChoice;
            if (!int.TryParse(input, out userChoice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            // switch Statement
            switch (userChoice)
            {
                case 1:
                    // Method call with parameters
                    totalPrice += OrderBurger("Whopper", 5.99);
                    break;
                case 2:
                    totalPrice += OrderBurger("Cheeseburger", 3.49);
                    break;
                case 3:
                    totalPrice += OrderBurger("Chicken Royale", 4.99);
                    break;
                case 0:
                    Console.WriteLine("Exiting the Burger King App. Thank you!");
                    DisplayTotalPrice(totalPrice);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method with parameters and returning a value
    static double OrderBurger(string burgerName, double price)
    {
        Console.WriteLine($"You ordered a {burgerName} for ${price:F2}.");
        return price;
    }

    // Display Menu method
    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Whopper - $5.99");
        Console.WriteLine("2. Cheeseburger - $3.49");
        Console.WriteLine("3. Chicken Royale - $4.99");
        Console.WriteLine("0. Exit");
    }

    // Method with parameters
    static void DisplayTotalPrice(double total)
    {
        Console.WriteLine($"Total Price: ${total:F2}");
    }
}
