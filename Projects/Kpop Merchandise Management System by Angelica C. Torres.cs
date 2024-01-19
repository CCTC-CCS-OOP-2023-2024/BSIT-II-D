using System;

class KpopMerch
{
    static void Main()
    {
        
        // Basic Concepts (Output)
        Console.WriteLine("Kpop Merchandise Management System");
        
        
        // Module 1 - Getting started
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("                KPOP GROUP                ");
        Console.WriteLine("      SEVENTEEN          ITZY             ");
        Console.WriteLine("      BTS                BLACKPINK        ");
        Console.WriteLine("------------------------------------------");

        // Variables
        Console.Write("Enter the name of the kpop group:");
        string name = Console.ReadLine();

        Console.Write("Enter the number of merchandise sold:");
        int sold = int.Parse(Console.ReadLine());

        double expenses = CalculateExpenses(sold);
        double revenue = CalculateRevenue(sold);
        double profit = CalculateProfit(revenue, expenses);

        DisplayResults(name, sold, revenue, expenses, profit);
    }


    static double CalculateExpenses(int sold)
    {
        double rate = 5.0;
        double expenses = sold * rate;
        return expenses;
    }


    static double CalculateRevenue(int sold)
    {
        double unitPrice = 20.0;
        double revenue = sold * unitPrice;
        return revenue;
    }


    static double CalculateProfit(double revenue, double expenses)
    {
        double profit = revenue - expenses;
        return profit;
    }


    static void DisplayResults(string name, int sold, double revenue, double expenses, double profit)
    
    {
        
        Console.WriteLine("\nResults for {0}", name);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Number of merchandise sold: {0}", sold);
        Console.WriteLine("Total revenue: ${0}", revenue);
        Console.WriteLine("Total expenses: ${0}", expenses);
        Console.WriteLine("Net profit: ${0}", profit);

        // if Statement
        if (profit > 0)
        {
            Console.WriteLine("Congratulations! {0} made a profit.", name);
        }
        // else if Statement
        else if (profit < 0)
        {
            Console.WriteLine("Attention! {0} incurred a loss.", name);
        }
        // else Statement
        else
        {
            Console.WriteLine("The financial status of {0} is neutral.", name);
            
        }
    }
}
