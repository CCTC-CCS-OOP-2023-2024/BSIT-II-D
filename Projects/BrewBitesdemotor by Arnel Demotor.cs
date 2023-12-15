using System;

class ARNELBREWBITES
{
    static void Main()
    {
        // Module 1 - Getting started
        Console.WriteLine("***************************");
        Console.WriteLine("** Welcome to BREWBITES! **");
        Console.WriteLine("***************************");


        // Basic Concepts (Output)
        Console.WriteLine("^.^ Enjoy our cozy atmosphere ^.^");

        // Variables
        int numberOfTables = 10;
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"|*We have {numberOfTables} tables.            |");

        // Data Types
        double coffeePrice = 2.5;
        Console.WriteLine($"|*A cup of coffee costs ${coffeePrice}.   |");


        // Doing Math
        int sugarPacketsPerCoffee = 2;
        double totalSugarUsed = numberOfTables * sugarPacketsPerCoffee;
        Console.WriteLine($"|*We use {totalSugarUsed} sugar packets daily.|");
        Console.WriteLine("---------------------------------");
       
        // Module 2 - Operators and Strings
        // Arithmetic Operators
        int espressoPrice = 3;
        int totalRevenue = numberOfTables * espressoPrice;
        Console.WriteLine($"Today's revenue: ${totalRevenue}");

        // Assignment Operators
        totalRevenue += 20;
        Console.WriteLine($"Updated revenue: ${totalRevenue}");

        // User Input
        Console.Write("Enter your name: ");
        string customerName = Console.ReadLine();
        Console.WriteLine($"Hello, {customerName}!");

        // More on Strings
        Console.WriteLine("Specials:\n\t1. Latte\n\t 2. Cappuccino");
    
       // Concatenation and Interpolation
        string specialDrink = "Latte";
        Console.WriteLine("Try our " + specialDrink + " with a hint of vanilla.");

        // Module 3 - Decision Making
        // Comparison Operators
        int ageRequirement = 18;
        Console.Write("Enter your age: ");
        int customerAge = int.Parse(Console.ReadLine());

        // if Statement
        if (customerAge >= ageRequirement)
        {
            Console.WriteLine("You're welcome to enjoy our drinks!");
        }
        // else if Statement
        else if (customerAge >= 16)
        {
            Console.WriteLine("You can have non-alcoholic beverages.");
        }
        // else Statement
        else
        {
            Console.WriteLine("Sorry, BREWBITES is for adults only.");
        }

        // Logical Operators
        bool isStudent = false;
        bool hasStudentDiscount = true;

        if (customerAge >= 18 && !isStudent)
        {
            Console.WriteLine("Regular pricing applies.");
        }
        else if (isStudent && hasStudentDiscount)
        {
            Console.WriteLine("Enjoy a student discount!");
        }

        // switch Statement
        Console.Write("Select a drink (1 or 2): ");
        int drinkChoice = int.Parse(Console.ReadLine());

        switch (drinkChoice)
        {
            case 1:
                Console.WriteLine("You chose a Latte.");
                break;
            case 2:
                Console.WriteLine("You chose a Cappuccino.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        // Ternary Operator
        string discountMessage = (customerAge >= 60) ? "Senior discount available." : "No senior discount.";

        Console.WriteLine(discountMessage);

        // Module 4 - Loops
        // for Loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Table {i} is ready.");
        }

        // while Loop
        int availableTables = 5;
        while (availableTables > 0)
        {
            Console.WriteLine($"{availableTables} tables available.");
            availableTables--;
        }

        // break and continue
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                continue; // Skip even numbers
            }

            Console.WriteLine($"Table {i} is ready.");

            if (i == 7)
            {
                break; // Stop after table 7

            }
        }


        // Module 5 - Methods
        // Methods
        GreetCustomer(customerName);

        // Parameters and Arguments
        DisplayDrinkSpecial(specialDrink);

        // Returning from Methods
        double totalCost = CalculateTotalCost(espressoPrice, numberOfTables);
        Console.WriteLine($"Total cost for today: ${totalCost}");
    }

    // Custom Methods
    static void GreetCustomer(string name)
    {
        Console.WriteLine($"Welcome, {name}! Enjoy your time at BREWBITES.");
    }

    static void DisplayDrinkSpecial(string drink)
    {
        Console.WriteLine($"Today's special: {drink} with a hint of vanilla.");
    }

    static double CalculateTotalCost(int price, int quantity)
    {
        return price * quantity;
    


    }
}
