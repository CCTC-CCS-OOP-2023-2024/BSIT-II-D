using System;
using System.Collections.Generic;

class VideoGameStore
{
    static void Main()
    {
        int option;
        int age;
        string name;
        double total = 0;
        List<string> purchasedGames = new List<string>();

        List<string> gameNames = new List<string> { "Assassin's Creed", "Call of Duty", "Persona 5 Royal", "God of War", "Red Dead Redemption 2" }; // Game names
        List<double> gamePrices = new List<double> { 59.99, 69.99, 79.99, 89.99, 99.99 }; // Game prices

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the DVG Store!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Purchase Video Game");
            Console.WriteLine("2. Exit");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter your name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter your age:");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age >= 18)
                    {
                        Console.WriteLine("Enter the game number to purchase:");
                        int gameNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the quantity of the game to purchase:");
                        double quantity;

                        // Validate that the input is a positive integer
                        while (!double.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
                        {
                            Console.WriteLine("Invalid quantity. Please enter a positive integer.");
                        }

                        // Validate that the game number is within range
                        if (gameNumber >= 1 && gameNumber <= gameNames.Count)
                        {
                            total += quantity * gamePrices[gameNumber - 1];
                            purchasedGames.Add($"{gameNames[gameNumber - 1]} (x{quantity})");
                            Console.WriteLine($"{name}, thank you for your purchase!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid game number. Please try again.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you are not old enough to make a purchase.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine("Thank you for visiting the Video Game Store! Your total is $" + total);
                    Console.WriteLine("Here are the games you purchased:");
                    foreach (string game in purchasedGames)
                    {
                        Console.WriteLine(game);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        } while (option != 2);
    }
}