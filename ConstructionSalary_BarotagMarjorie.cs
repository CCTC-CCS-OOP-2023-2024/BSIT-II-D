using System;

class ConstructionSalaryCalculator
{
    const decimal DefaultHourlyRate = 20;

    static void Main()
    {
        Console.WriteLine("Welcome to the Construction Salary Calculator!");
        Console.WriteLine("--------------------------------------------");

        Console.Write("Enter the number of workers: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfWorkers) && numberOfWorkers > 0)
        {
            for (int i = 1; i <= numberOfWorkers; i++)
            {
                Console.WriteLine($"\nWorker {i}:");

                Console.Write("Enter the name of the worker: ");
                string workerName = Console.ReadLine();

                Console.Write("Enter the number of hours worked this week: ");
                if (int.TryParse(Console.ReadLine(), out int hoursWorked) && hoursWorked >= 0)
                {
                    Console.Write("Enter the hourly rate (press Enter to use the default rate): ");
                    string rateInput = Console.ReadLine();
                    decimal hourlyRate = string.IsNullOrWhiteSpace(rateInput) ? DefaultHourlyRate : decimal.Parse(rateInput);

                    decimal salary = CalculateSalary(hoursWorked, hourlyRate);

                    Console.WriteLine($"{workerName}, your salary for this week is ${salary:0.00}.");
                }
                else
                {
                    Console.WriteLine("Invalid input for hours worked. Please enter a non-negative number.");
                    i--; // Retry input for the current worker
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the number of workers. Please enter a positive integer.");
        }

        Console.WriteLine("\nThank you for using the Construction Salary Calculator!");
    }

    static decimal CalculateSalary(int hoursWorked, decimal hourlyRate)
    {
        decimal salary = hoursWorked * hourlyRate;
        return salary;
    }
}
