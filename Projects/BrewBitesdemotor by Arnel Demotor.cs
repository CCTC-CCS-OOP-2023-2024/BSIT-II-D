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
        Console.WriteLine("-Enjoy our cozy atmosphere.-");

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
    }
}