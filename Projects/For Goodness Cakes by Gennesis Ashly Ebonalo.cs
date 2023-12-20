using System;
using System.Reflection;

class FORGOODNESSCAKES
{
    static void Main()
    {
        // Module 1 - Getting started

        // Feature 1- Program Structure
        Console.WriteLine("##################################");
        Console.WriteLine("# Welcome to FOR GOODNESS CAKES! #");
        Console.WriteLine("##################################");


        // Feature 2- Basic Concepts (Output)
        Console.WriteLine("Enjoy our fresh and tasty cake and shake made by Gennesis.");

        // Freature 3- Variables
        int numberOfCakes = 18;
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.WriteLine($"|> We have {numberOfCakes} cakes available with different flavor and toppings.  |");

        // Freature 4- Data Types
        double slicePrice = 2.24;
        Console.WriteLine($"|> A slice costs ${slicePrice}.                                            |");


        // Feature 5- Doing Math
        int cakeSlicePerBox = 7;
        double totalBoxUsed = numberOfCakes * cakeSlicePerBox;
        Console.WriteLine($"|> We use {totalBoxUsed} box daily.                                           |");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        // Module 2 - Operators and Strings

        // Feature 1- Arithmetic Operators
        int sweetPrice = 15;
        int totalRevenue = numberOfCakes * sweetPrice;
        Console.WriteLine($"Today's revenue: ${totalRevenue}");

        // Feature 2- Assignment Operators
        totalRevenue += 20;
        Console.WriteLine($"Updated revenue: ${totalRevenue}");

        // Feature 3- User Input
        Console.Write("Please enter your name: ");
        string customerName = Console.ReadLine();
        Console.WriteLine($"Hi dear, {customerName} our costumer!");

        // Feature 4- More on Strings
        Console.WriteLine("Sweetest Special Treat (CAKE CORNER):\n\t 1. Strawberry Cake (RedVelvet Flavor)\n\t 2. Bravo Cake (Chocolate Flavor)\n\t 3. Jelly Cake (Vanilla Flavor)");
        Console.WriteLine("If not interested with our special treat, feel free to choose other option with the same flavor of our special treats.");
        Console.WriteLine("Sweetest Special Treat (SHAKE CORNER):\n\t 1. Mango Graham Shake\n\t 2. Mixed Fruit Shake\n\t 3. Oreo Cookie Shake");

        // Feature 5- Concatenation and Interpolation
        string specialTreat = "CAKE and SHAKE";
        Console.WriteLine("Taste our " + specialTreat + " with toppings of real fruits.");

        // Module 3 - Decision Making

        // Feature 1- Comparison Operators
        Console.Write("How many cake slices would you like to order? Enter a number: ");
        int slicesOrdered = int.Parse(Console.ReadLine());

        if (slicesOrdered > 0)
        {
            Console.WriteLine($"Thank you for ordering {slicesOrdered} cake slices. Enjoy your treat!");
        }
        else
        {
            Console.WriteLine("Invalid quantity. Please enter a valid number of cake slices to order.");
        }

        // Feature 2- if Statement
        Console.Write("Are you a cake lover or a shake enthusiast? (cake/shake): ");
        string preference = Console.ReadLine();

        if (preference.ToLower() == "cake")
        {
            Console.WriteLine("Fantastic! Our cakes are made with love and the finest ingredients.");
        }

        // Feature 3- else-if Statement
         else if (preference.ToLower() == "shake")
        {
            Console.WriteLine("Awesome! Our shakes are a delightful blend of flavors.");
        }

        // Feature 4- else statement
        else
        {
            Console.WriteLine("Invalid choice. Please choose between cake and shake.");
        }
        
        // Feature 5- Logical Operators
        Console.Write("Are you interested in a cake slice AND a shake? (yes/no): ");
        string interest = Console.ReadLine();

        if (interest.ToLower() == "yes" && preference.ToLower() == "cake")
        {
            Console.WriteLine("Perfect! A cake slice and a shake will make your experience even sweeter.");
        }
        else
        {
            Console.WriteLine("No problem! Feel free to explore our other delightful options.");
        }
        
        // Feature 6- switch Operator
        Console.WriteLine("Which flavor of cake would you like?");
        Console.WriteLine("1. Chocolate");
        Console.WriteLine("2. Vanilla");
        Console.WriteLine("3. Red Velvet");
        Console.Write("Enter the corresponding number: ");

        int flavorChoice = int.Parse(Console.ReadLine());

        switch (flavorChoice)
        {
            case 1:
                Console.WriteLine("Indulge in the rich and decadent Chocolate cake!");
                break;
            case 2:
                Console.WriteLine("Enjoy the classic goodness of our Vanilla cake!");
                break;
            case 3:
                Console.WriteLine("Experience the luxurious taste of our Red Velvet cake!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid flavor.");
                break;
        }

        // Feature 7- Ternary Operators
        string discountMessage = (slicesOrdered >= 8) ? "You are discounted. Enjoy every bite of slices." : "Regular price offered. Feel free to comeback if you want more.";

        Console.WriteLine(discountMessage);

        // Module 4- Loops

        // Feature 1- for Loop
        for (int l = 1; l <= 5; l++)
        {
            Console.WriteLine($"Order {l} is ready.");
        }

        // Freature 2- while Loop
        int availableCakes = 3;
        while (availableCakes > 0)
        {
            Console.WriteLine($"{availableCakes} cakes available.");
            availableCakes--;
        }
        // Feature 3- Break and Continue
        for (int l = 1; l <= 5; l++)
        {
            if (l % 2 == 0)
            {
                continue; 
            }

            Console.WriteLine($"Order {l} is ready.");

            if (l == 8)
            {
                break; 

            }
            // Module 5- Methods

            // Feature 1- Methods
            GreetCustomer(customerName);

            // Feature 2- Parameters and Arguments
            DisplaySpecialTreat(specialTreat);

            // Feature 3- Returning from Methods
            double totalCost = CalculateTotalCost(sweetPrice, numberOfCakes);
            Console.WriteLine($"Total cost for today: ${totalCost}");

            // Feature 4- Custom Methods
            static void GreetCustomer(string name)
            {
                Console.WriteLine($"Welcome, {name}! Enjoy your sweet time at FOR GOODNESS CAKES.");
            }

            static void DisplaySpecialTreat(string treat)
            {
                Console.WriteLine($"Today's special: {treat} with a fresh fruit topping.");
            }

            static double CalculateTotalCost(int price, int quantity)
            {
                return price * quantity;
            }
        }
    }
}
