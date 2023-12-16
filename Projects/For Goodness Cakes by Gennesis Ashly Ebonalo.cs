using System;

class FORGOODNESSCAKES
{
    static void Main()
    {
        // Module 1 - Getting started

        // Feature 1- Program Structure
        Console.WriteLine("##################################");
        Console.WriteLine("# Welcome to FOR GOODNESS CAKES! #");
        Console.WriteLine("##################################");


        // Basic Concepts (Output)
        Console.WriteLine("Enjoy our fresh and tasty cake made by Gennesis.");

        // Variables
        int numberOfCakes = 18;
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.WriteLine($"|> We have {numberOfCakes} cakes available with different flavor and toppings.  |");

        // Data Types
        double slicePrice = 85.2;
        Console.WriteLine($"|> A slice costs ${slicePrice}.                                            |");


        // Doing Math
        int cakeSlicePerBox = 7;
        double totalBoxUsed = numberOfCakes * cakeSlicePerBox;
        Console.WriteLine($"|> We use {totalBoxUsed} box daily.                                           |");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        // Module 2 - Operators and Strings

        // Arithmetic Operators
        int sweetPrice = 75;
        int totalRevenue = numberOfCakes * sweetPrice;
        Console.WriteLine($"Today's revenue: ${totalRevenue}");

        // Assignment Operators
        totalRevenue += 20;
        Console.WriteLine($"Updated revenue: ${totalRevenue}");

        // User Input
        Console.Write("Please enter your name: ");
        string customerName = Console.ReadLine();
        Console.WriteLine($"Hi dear, {customerName} our costumer!");

        // More on Strings
        Console.WriteLine("Sweetest Special Treat (CAKE CORNER):\n\t 1. Strawberry Cake\n\t 2.Bravo Cake\n\t 3. Jelly Cake");
        Console.WriteLine("Sweetest Special Treat (SHAKE CORNER):\n\t 1. Mango Graham Shake\n\t 2. Mixed Fruit Shake\n\t 3. Oreo Cookie Shake");

        // Concatenation and Interpolation
        string specialTreat = "CAKE AND SHAKE";
        Console.WriteLine("Taste our " + specialTreat + " with toppings of real fruits.");
    }
}
