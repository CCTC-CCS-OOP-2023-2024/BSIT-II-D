using System;
using System.Collections.Generic;

namespace BikeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeMessage();
            DisplayBikeCategories();
            HandleUserChoice();
        }

        // Variables, Data Types, Strings, Concatenation
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Our Bike Shop!\n");
        }

        static void DisplayBikeCategories()
        {
            Console.WriteLine("Bike Categories:\n");
            Console.WriteLine("1. Mountain Bikes");
            Console.WriteLine("2. Road Bikes");
            Console.WriteLine("3. Hybrid Bikes");
            Console.WriteLine("4. Kids Bikes");
            Console.WriteLine("5. Exit\n");
        }

        // User Input, if-else Statements, while Loop
        static void HandleUserChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Enter your choice (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        DisplayBikeModels(choice);
                        break;
                    case 5:
                        Console.WriteLine("\nThank you for visiting our Bike Shop!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }
            }
        }

        static void DisplayBikeModels(int category)
        {
            Console.WriteLine("\nModels in the selected category:\n");
            List<string> models = GetBikeModelsByCategory(category);
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {models[i]}");
            }

            Console.WriteLine($"{models.Count + 1}. Back to categories");
            Console.WriteLine($"{models.Count + 2}. Exit");

            HandleModelSelection(models);
        }

        static List<string> GetBikeModelsByCategory(int category)
        {
            // Sample models for demonstration
            switch (category)
            {
                case 1:
                    return new List<string> { "Mountain X1", "Mountain Y2", "Mountain Z3" };
                case 2:
                    return new List<string> { "Road R1", "Road R2", "Road R3" };
                case 3:
                    return new List<string> { "Hybrid H1", "Hybrid H2", "Hybrid H3" };
                case 4:
                    return new List<string> { "Kids K1", "Kids K2", "Kids K3" };
                default:
                    return new List<string>();
            }
        }

        static void HandleModelSelection(List<string> models)
        {
            int choice;
            while (true)
            {
                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice > 0 && choice <= models.Count)
                {
                    DisplayBikeDetails(models[choice - 1]);
                }
                else if (choice == models.Count + 1)
                {
                    DisplayBikeCategories();
                    return;
                }
                else if (choice == models.Count + 2)
                {
                    Console.WriteLine("\nThank you for shopping with us!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please try again.");
                }
            }
        }

        static void DisplayBikeDetails(string model)
        {
            Console.WriteLine($"\nDetails for {model}:\n");
            // Fetch details from a database or other source for the given model
            Console.WriteLine($"Price: ${CalculatePrice(model)}");
            Console.WriteLine("Features: ..."); // Add more details if needed

            Console.Write("\nWould you like to add this to your cart? (yes/no): ");
            string addToCart = Console.ReadLine().ToLower();

            if (addToCart == "yes")
            {
                // Add to cart logic can be implemented here
                Console.WriteLine($"{model} added to cart!");
            }
        }

        static double CalculatePrice(string model)
        {
            // Dummy price calculation for demonstration
            if (model.Contains("Mountain"))
                return 500;
            if (model.Contains("Road"))
                return 400;
            if (model.Contains("Hybrid"))
                return 450;
            if (model.Contains("Kids"))
                return 300;
            return 0;
        }
    }
}