using System;

namespace FastFoodSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name;
            double hoursWorked, payRate, stateTax, federalTax, ficaTax, grossPay, netPay;

            // Get user input for name
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            // Get user input for hours worked with error handling
            Console.WriteLine("Enter the number of hours you worked this month:");
            while (!double.TryParse(Console.ReadLine(), out hoursWorked) || hoursWorked < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number of hours worked:");
            }

            // Get user input for pay rate with error handling
            Console.WriteLine("Enter your pay rate:");
            while (!double.TryParse(Console.ReadLine(), out payRate) || payRate < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid pay rate:");
            }

            // Calculate salary and taxes
            CalculateSalary(hoursWorked, payRate, out stateTax, out federalTax, out ficaTax, out grossPay, out netPay);

            // Display results
            DisplayResults(name, grossPay, stateTax, federalTax, ficaTax, netPay);

            // Wait for user input before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void CalculateSalary(double hoursWorked, double payRate, out double stateTax, out double federalTax, out double ficaTax, out double grossPay, out double netPay)
        {
            // Constants for tax rates
            const double STATE_TAX_RATE = 0.0307;
            const double FEDERAL_TAX_RATE = 0.15;
            const double FICA_TAX_RATE = 0.0886;

            // Calculate gross pay
            grossPay = hoursWorked * payRate;

            // Calculate taxes
            stateTax = grossPay * STATE_TAX_RATE;
            federalTax = grossPay * FEDERAL_TAX_RATE;
            ficaTax = grossPay * FICA_TAX_RATE;

            // Calculate net pay
            netPay = grossPay - stateTax - federalTax - ficaTax;
        }

        static void DisplayResults(string name, double grossPay, double stateTax, double federalTax, double ficaTax, double netPay)
        {
            // Display results with formatted currency
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Gross Pay: {grossPay:C}");
            Console.WriteLine($"State Tax: {stateTax:C}");
            Console.WriteLine($"Federal Tax: {federalTax:C}");
            Console.WriteLine($"FICA Tax: {ficaTax:C}");
            Console.WriteLine($"Net Pay: {netPay:C}");
        }
    }
}