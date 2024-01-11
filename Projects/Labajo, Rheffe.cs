using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Welcome to Tech Shop!!");

        
        int TechSold = 20;
        double pricePerTech= 12.99;
        string techType = "RTX 4090";

        
        double totalRevenue = TechSold * pricePerTech;

        
        Console.WriteLine($"tech Type: {techType}\nTech Sold: {TechSold}\nPrice per Tech: ${pricePerTech}");

        
        string greeting = "Thank you for choosing Tech Shop";
        Console.WriteLine(greeting);

        
        if (TechSold > 0)
        {
            Console.WriteLine("Tech is available.");
        }
        else if (TechSold == 0)
        {
            Console.WriteLine("Out of stock.");
        }
        else
        {
            Console.WriteLine("Invalid tech quantity.");
        }

        
        bool isDiscountAvailable = true;
        if (TechSold > 10 && isDiscountAvailable)
        {
            Console.WriteLine("You qualify for a discount!");
        }

        string customerRating = "Excellent";
        switch (customerRating)
        {
            case "Excellent":
                Console.WriteLine("Thank you for your excellent rating!");
                break;
            case "Good":
                Console.WriteLine("We appreciate your positive feedback!");
                break;
            default:
                Console.WriteLine("We value your feedback!");
                break;
        }

        
        string status = (TechSold > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Serving customer {i}");
        }

        
        int restockCount = 0;
        while (restockCount < 2)
        {
            Console.WriteLine($"Restocking tech supplies. Restock count: {restockCount + 1}");
            restockCount++;
        }

        
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even tech
            Console.WriteLine($"Serving tech {i}");
        }

        double discountedTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.1);
        Console.WriteLine($"Discounted Total Revenue: ${discountedTotalRevenue}");
    }

    
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
    }
}