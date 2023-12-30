using System;

class CallCenterAgentSalary
{
    const int RegularHours = 40;
    const int BaseSalary = 50000;
    const int ExtraSalaryPerHour = 500;
    const double TaxRate = 0.15;

    static void Main()
    {
        Console.WriteLine("Welcome to the Call Center Agent Salary Calculator!");

        Console.Write("Enter the agent's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the total hours worked this week: ");
        if (int.TryParse(Console.ReadLine(), out int hoursWorked))
        {
            if (hoursWorked >= 0)
            {
                int totalSalary = CalculateSalary(BaseSalary, ExtraSalaryPerHour, hoursWorked);
                double taxDeduction = CalculateTaxDeduction(totalSalary);

                Console.WriteLine($"Agent Name: {name}");
                Console.WriteLine($"Total Hours Worked: {hoursWorked}");
                Console.WriteLine($"Base Salary: ${BaseSalary}");
                Console.WriteLine($"Overtime Pay: ${CalculateOvertimePay(BaseSalary, ExtraSalaryPerHour, hoursWorked)}");
                Console.WriteLine($"Extra Salary: ${hoursWorked * ExtraSalaryPerHour}");
                Console.WriteLine($"Total Salary (before tax): ${totalSalary}");
                Console.WriteLine($"Tax Deduction ({TaxRate * 100}%): ${taxDeduction}");
                Console.WriteLine($"Total Salary (after tax): ${totalSalary - taxDeduction}");

                DisplayEarningsSummary(totalSalary - taxDeduction);
            }
            else
            {
                Console.WriteLine("Invalid input for hours worked. Please enter a non-negative integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for hours worked. Please enter a valid integer.");
        }
    }

    static int CalculateSalary(int baseSalary, int extraSalaryPerHour, int hoursWorked)
    {
        if (hoursWorked <= RegularHours)
        {
            return baseSalary;
        }
        else
        {
            int extraHours = hoursWorked - RegularHours;
            return baseSalary + (extraHours * extraSalaryPerHour);
        }
    }

    static double CalculateTaxDeduction(int totalSalary)
    {
        return totalSalary * TaxRate;
    }

    static int CalculateOvertimePay(int baseSalary, int extraSalaryPerHour, int hoursWorked)
    {
        if (hoursWorked > RegularHours)
        {
            int overtimeHours = hoursWorked - RegularHours;
            return overtimeHours * extraSalaryPerHour;
        }
        return 0;
    }

    static void DisplayEarningsSummary(double netEarnings)
    {
        Console.WriteLine("Earnings Summary:");
        Console.WriteLine($"Congratulations, {netEarnings:C} is your net earnings after tax deduction!");
        // Add more personalized messages or incentives based on earnings if desired.
    }
}
