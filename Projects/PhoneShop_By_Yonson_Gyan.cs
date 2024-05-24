using System;

namespace PhoneShop
{
    class Program
    {
        // Module 5 - Methods
        static void Main(string[] args)
        {
            // Module 1 - Getting started
            // Program Structure, Basic Concepts (Output), Variables, Data Types, Doing Math

            Console.WriteLine("Welcome to the Phone Shop!");

            string[] phoneModels = {
                "iPhone 14", "Samsung Galaxy S23", "Google Pixel 7", "Huawei P50", "OnePlus 9",
                "Sony Xperia 5 III", "Oppo Find X3 Pro", "Xiaomi Mi 11", "Nokia 8.3", "Realme GT",
                "Asus ROG Phone 5", "Vivo X60 Pro", "Motorola Edge Plus", "LG Velvet", "ZTE Axon 30"
            };
            double[] phonePrices = {
                59999.99, 49999.99, 39999.99, 29999.99, 34999.99,
                41999.99, 45999.99, 37999.99, 28999.99, 31999.99,
                64999.99, 32999.99, 36999.99, 25999.99, 27999.99
            }; // Prices in PHP

            DisplayPhones(phoneModels, phonePrices);

            // Module 2 - Operators and Strings
            // Arithmetic Operators, Assignment Operators, User Input, More on Strings (\n \t @), Concatenation and Interpolation

            Console.Write("\nEnter the number of the phone you want to buy (1-15): ");
            int phoneChoice = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter the quantity you want to purchase: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalCost = CalculateTotalCost(phonePrices[phoneChoice], quantity);

            // Module 3 - Decision Making
            // Comparison Operators, if Statement, else if Statement, else Statement, Logical Operators, switch Statement, Ternary Operator

            if (totalCost > 50000)
            {
                Console.WriteLine("You're eligible for a discount!");
                totalCost *= 0.9; // 10% discount
            }
            else if (totalCost > 25000)
            {
                Console.WriteLine("You're eligible for a small discount!");
                totalCost *= 0.95; // 5% discount
            }
            else
            {
                Console.WriteLine("No discounts available.");
            }

            Console.WriteLine($"Your total cost is: PHP {totalCost:F2}");

            // Module 4 - Loops
            // for Loop, while Loop, break and continue

            for (int i = 0; i < phoneModels.Length; i++)
            {
                Console.WriteLine($"Checking stock for {phoneModels[i]}...");
                if (CheckStock(phoneModels[i]))
                {
                    Console.WriteLine($"{phoneModels[i]} is in stock.");
                }
                else
                {
                    Console.WriteLine($"{phoneModels[i]} is out of stock.");
                    continue;
                }
            }

            // Module 5 - Methods (continued)
            // Methods, Parameters and Arguments, Returning from Methods

            PrintReceipt(phoneModels[phoneChoice], quantity, totalCost);

            Console.WriteLine("Thank you for shopping with us!");
        }

        static void DisplayPhones(string[] models, double[] prices)
        {
            Console.WriteLine("Available Phones:");
            for (int i = 0; i < models.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {models[i]} - PHP {prices[i]:F2}");
            }
        }

        static double CalculateTotalCost(double price, int quantity)
        {
            return price * quantity;
        }

        static bool CheckStock(string model)
        {
            // For simplicity, all models are in stock
            return true;
        }

        static void PrintReceipt(string model, int quantity, double totalCost)
        {
            Console.WriteLine("\nReceipt:");
            Console.WriteLine($"Phone Model: {model}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Cost: PHP {totalCost:F2}");
        }
    }
}
