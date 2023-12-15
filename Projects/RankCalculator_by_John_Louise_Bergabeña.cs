//This programs aims to calculate a User's rank based on the wins and losses
// that the user inputs, these ranks are based on a real ranking System
//present in the game League of Legends (LOL) where i took the inspiration from
//Code Made by: John Louise Bergabeña - BSIT 2D
//In compliance with the Finals Requirement for OOP
using System;

class RankCalculator
{
    static void Main()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Calculate and display the user's rank");
            Console.WriteLine("2. Calculate and display the user's score (LP)");
            Console.WriteLine("3. Exit the program");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter the number of wins:");
                        int wins = GetIntegerInput(Console.ReadLine());

                        Console.WriteLine("Enter the number of losses:");
                        int losses = GetIntegerInput(Console.ReadLine());

                        double rank = CalculateRank(wins, losses);

                        Console.WriteLine($"Your rank is: {RankName(rank)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Enter the number of wins:");
                        int wins = GetIntegerInput(Console.ReadLine());

                        Console.WriteLine("Enter the number of losses:");
                        int losses = GetIntegerInput(Console.ReadLine());

                        int score = CalculateScore(wins, losses);

                        Console.WriteLine($"You have: {score} LP");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    Console.WriteLine("Exiting the program...");
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static double CalculateRank(int wins, int losses)
    {
        if (wins == 0 && losses == 0)
        {
            return 0;
        }

        double winRate = (double)wins / (wins + losses);

        return (winRate * 100) / (1 - winRate);
    }

    static int CalculateScore(int wins, int losses)
    {
        return wins * 2 + losses;
    }

    static string RankName(double rank)
    {
        if (rank < 2500)
        {
            return "Bronze";
        }
        else if (rank < 3500)
        {
            return "Silver";
        }
        else if (rank < 4500)
        {
            return "Gold";
        }
        else if (rank < 5500)
        {
            return "Platinum";
        }
        else if (rank < 6500)
        {
            return "Diamond";
        }
        else if (rank < 7500)
        {
            return "Emerald";
        }
        else if (rank < 8500)
        {
            return "Master";
        }
        else if (rank < 9500)
        {
            return "Grandmaster";
        }
        else if (rank < 10000)
        {
            return "Challenger";
        }
        else
        {
            return "Sovereign";
        }
    }

    static int GetIntegerInput(string input)
    {
        int number;

        if (int.TryParse(input, out number))
        {
            return number;
        }
        else
        {
            throw new ArgumentException("Invalid input. Please enter a number.");
        }
    }
}
