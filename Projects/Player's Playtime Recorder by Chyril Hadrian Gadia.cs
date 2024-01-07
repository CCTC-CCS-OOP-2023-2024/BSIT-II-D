using System;

class PlayerPlaytime
{
    static void Main()
    {
        // Introduction and user input
        Console.WriteLine("Welcome to the Player Playtime Recorder!");
        Console.WriteLine("Enter the name of the Player:");
        string name = Console.ReadLine();

        // Validate and get hours played
        int hours;
        do
        {
            Console.WriteLine("Enter the hours played this week:");
        } while (!int.TryParse(Console.ReadLine(), out hours) || hours < 0);

        // Calculate credits
        decimal credit = CalculateCredit(hours);

        // Display results
        Console.WriteLine("===========================================");
        Console.WriteLine("Summary for " + name);
        Console.WriteLine("Total hours played: " + hours);
        Console.WriteLine("The credit of " + name + " is " + credit.ToString("C"));
    }

    static decimal CalculateSalary(int hours)
    {
        // Constants and default values
        decimal playPerHour = 20.0m;
        int maxHours = 40;
        decimal overtimeMultiplier = 1.5m;

        // Validate input
        if (hours <= 0)
        {
            Console.WriteLine("Invalid input. Hours worked must be greater than 0.");
            return 0;
        }

        // Calculate regular and overtime credits
        int regularHours = Math.Min(hours, maxHours);
        decimal overtimeHours = Math.Max(0, hours - maxHours);
        decimal overtimePay = overtimeHours * (creditPerHour * overtimeMultiplier);
        decimal regularPay = regularHours * creditPerHour;

        // Total credit
        decimal totalCredit = regularPay + overtimePay;

        // Display breakdown
        Console.WriteLine("Credit Breakdown:");
        Console.WriteLine("Regular Hours: " + regularHours);
        Console.WriteLine("Regular Credit: " + regularCredit.ToString("C"));
        Console.WriteLine("Overtime Hours: " + overtimeHours);
        Console.WriteLine("Overtime Credit: " + overtimeCredit.ToString("C"));
        Console.WriteLine("-------------------------------------------");

        return totalCredits;
    }
}
