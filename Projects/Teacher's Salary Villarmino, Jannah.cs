
using System;

namespace SalaryCalculator
{
    class Program
    {
        const double HOURLY_RATE = 10.0;
        const int MIN_HOURS = 10;
        const int MAX_HOURS = 60;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Teacher Salary Calculator!");

            // Input teacher's name
            Console.WriteLine("Enter the teacher's name:");
            string name = Console.ReadLine();

            // Input and validate hours worked
            int hoursWorked;
            do
            {
                Console.WriteLine("Enter the number of hours worked this week (between 10 and 60):");
            } while (!int.TryParse(Console.ReadLine(), out hoursWorked) || hoursWorked < MIN_HOURS || hoursWorked > MAX_HOURS);

            // Calculate salary
            double salary = CalculateSalary(hoursWorked);

            // Display results
            DisplayHeader("Salary Details");
            Console.WriteLine($"Teacher: {name}");
            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Hourly Rate: ${HOURLY_RATE:F2}");
            Console.WriteLine($"Total Salary: ${salary:F2}");

            // Additional features (you can customize or add more)
            DisplayHeader("Additional Features");

            // Calculate and display monthly salary
            double monthlySalary = CalculateMonthlySalary(salary);
            Console.WriteLine($"Monthly Salary: ${monthlySalary:F2}");

            // Check if the teacher is eligible for a bonus
            bool isEligibleForBonus = IsEligibleForBonus(hoursWorked);
            Console.WriteLine($"Eligible for Bonus: {isEligibleForBonus}");

            // Provide feedback based on the hours worked
            ProvideFeedback(hoursWorked);

            // End of program
            DisplayHeader("End of Program");
            Console.WriteLine("Thank you for using the Teacher Salary Calculator!");
        }

        static double CalculateSalary(int hoursWorked)
        {
            // Calculate salary based on hourly rate
            return hoursWorked * HOURLY_RATE;
        }

        static double CalculateMonthlySalary(double weeklySalary)
        {
            // Assuming a month has four weeks
            const int WEEKS_IN_MONTH = 4;
            return weeklySalary * WEEKS_IN_MONTH;
        }

        static bool IsEligibleForBonus(int hoursWorked)
        {
            // Determine bonus eligibility based on hours worked
            const int BONUS_THRESHOLD = 40;
            return hoursWorked > BONUS_THRESHOLD;
        }

        static void ProvideFeedback(int hoursWorked)
        {
            // Provide feedback based on hours worked
            if (hoursWorked < 20)
            {
                Console.WriteLine("Consider working more hours to maximize your earnings.");
            }
            else if (hoursWorked > 40)
            {
                Console.WriteLine("Great job! You are putting in extra effort. Keep it up!");
            }
            else
            {
                Console.WriteLine("You are maintaining a balanced workload. Good job!");
            }
        }

        static void DisplayHeader(string title)
        {
            // Display section headers
            Console.WriteLine();
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"   {title}");
            Console.WriteLine(new string('=', 30));
        }
    }
}
