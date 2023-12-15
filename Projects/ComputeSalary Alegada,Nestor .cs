using System;

class Program
{
    // Module 1 - Getting started
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to the Salary Calculator!");

        // Basic Concepts (Output)
        Console.WriteLine("This program calculates a worker's salary.");

        // Variables
        string workerName;
        double hoursWorked;

        // Data Types
        // Using double for hoursWorked to allow decimal values
        // Doing Math
        double hourlyRate = 15.50; // Example hourly rate

        // Module 2 - Operators and Strings
        // User Input
        Console.Write("Enter worker's name: ");
        workerName = Console.ReadLine();

        // Handling strings with escape characters
        Console.WriteLine($"Hello, {workerName}! \n\t We are here to calculate your salary.");

        Console.Write("Enter hours worked this week: ");
        // Parsing input to double, assuming valid input
        hoursWorked = double.Parse(Console.ReadLine());

        // Module 3 - Decision Making
        // Comparison Operators
        double regularHours = hoursWorked;
        double overtimeHours = 0;

        if (hoursWorked > 40)
        {
            // If hours worked exceed 40, calculate regular and overtime hours
            regularHours = 40;
            overtimeHours = hoursWorked - 40;
        }

        // Module 4 - Loops
        // Loop to ensure valid input for hours worked
        while (hoursWorked < 0)
        {
            Console.WriteLine("Invalid input. Hours worked cannot be negative.");
            Console.Write("Enter hours worked this week: ");
            hoursWorked = double.Parse(Console.ReadLine());
        }

        // Module 5 - Methods
        // Displaying results using methods
        DisplayWorkSummary(workerName, regularHours, overtimeHours);
        double weeklySalary = CalculateSalary(regularHours, overtimeHours, hourlyRate);
        DisplaySalary(workerName, weeklySalary);
        DisplayOvertimePay(overtimeHours, hourlyRate);

        // Keeping the console open until user input
        Console.ReadLine();
    }

    // Method to calculate salary
    static double CalculateSalary(double regularHours, double overtimeHours, double rate)
    {
        double regularPay = regularHours * rate;
        double overtimePay = overtimeHours * (rate * 1.5);

        return regularPay + overtimePay;
    }

    // Method to display worker's work summary
    static void DisplayWorkSummary(string name, double regularHours, double overtimeHours)
    {
        Console.WriteLine($"\nWork Summary for {name}:");
        Console.WriteLine($"Regular Hours: {regularHours:F2} hours");
        Console.WriteLine($"Overtime Hours: {overtimeHours:F2} hours");
    }

    // Method to display worker's salary
    static void DisplaySalary(string name, double salary)
    {
        Console.WriteLine($"\nWorker: {name}");
        Console.WriteLine($"Weekly Salary: ${salary:F2}");
    }

    // Method to display overtime pay details
    static void DisplayOvertimePay(double overtimeHours, double rate)
    {
        if (overtimeHours > 0)
        {
            double overtimePay = overtimeHours * (rate * 1.5);
            Console.WriteLine($"\nOvertime Pay: ${overtimePay:F2}");
        }
    }
}