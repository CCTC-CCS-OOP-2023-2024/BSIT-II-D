using System;

namespace EShopSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Module 1 - Getting started
            Console.WriteLine("Program Structure");
            Console.WriteLine("Basic Concepts (Output)");
            VariablesExample();
            DataTypesExample();
            DoingMathExample();

            // Module 2 - Operators and Strings
            ArithmeticOperatorsExample();
            AssignmentOperatorsExample();
            UserInputExample();
            MoreOnStringsExample();
            ConcatenationAndInterpolationExample();

            // Module 3 - Decision Making
            ComparisonOperatorsExample();
            IfStatementExample();
            ElseIfStatementExample();
            ElseStatementExample();
            LogicalOperatorsExample();
            SwitchStatementExample();
            TernaryOperatorExample();

            // Module 4 - Loops
            ForLoopExample();
            WhileLoopExample();
            BreakAndContinueExample();

            // Module 5 - Methods
            CalculateSalaryExample();
        }

        // Module 1 - Getting started
        static void VariablesExample()
        {
            Console.WriteLine("Variables");
            double hoursWorked = 0; // Variable to store hours worked
            Console.WriteLine($"Hours worked: {hoursWorked}");
        }

        static void DataTypesExample()
        {
            Console.WriteLine("Data Types");
            double hourlyRate = 10.0; // Variable to store hourly rate
            Console.WriteLine($"Hourly rate: ${hourlyRate}");
        }

        static void DoingMathExample()
        {
            Console.WriteLine("Doing Math");
            double hoursWorked = 40;
            double hourlyRate = 10.0;
            double totalSalary = hoursWorked * hourlyRate;
            Console.WriteLine($"Total salary: ${totalSalary}");
        }

        // Module 2 - Operators and Strings
        static void ArithmeticOperatorsExample()
        {
            Console.WriteLine("Arithmetic Operators");
            double a = 10.0;
            double b = 3.0;
            Console.WriteLine($"Sum: {a + b}, Difference: {a - b}, Product: {a * b}, Quotient: {a / b}, Remainder: {a % b}");
        }

        static void AssignmentOperatorsExample()
        {
            Console.WriteLine("Assignment Operators");
            double totalHoursWorked = 0;
            totalHoursWorked += 8;
            Console.WriteLine($"Total hours worked after using += operator: {totalHoursWorked}");
        }

        static void UserInputExample()
        {
            Console.WriteLine("User Input");
            Console.Write("Enter your name: ");
            string workerName = Console.ReadLine();
            Console.WriteLine($"Hello, {workerName}!");
        }

        static void MoreOnStringsExample()
        {
            Console.WriteLine("More on Strings");
            Console.WriteLine("This is a multi-line\nstring with a tab \tand a new line.");
        }

        static void ConcatenationAndInterpolationExample()
        {
            Console.WriteLine("Concatenation and Interpolation");
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Concatenation: " + firstName + " " + lastName);
            Console.WriteLine($"Interpolation: {firstName} {lastName}");
        }

        // Module 3 - Decision Making
        static void ComparisonOperatorsExample()
        {
            Console.WriteLine("Comparison Operators");
            double hoursWorked = 40;
            Console.WriteLine($"{hoursWorked} > 35: {hoursWorked > 35}");
        }

        static void IfStatementExample()
        {
            Console.WriteLine("if Statement");
            double hoursWorked = 40;
            if (hoursWorked >= 40)
            {
                Console.WriteLine("You have worked a full week.");
            }
        }

        static void ElseIfStatementExample()
        {
            Console.WriteLine("else if Statement");
            double hoursWorked = 30;
            if (hoursWorked > 40)
            {
                Console.WriteLine("You have worked overtime.");
            }
            else if (hoursWorked < 40)
            {
                Console.WriteLine("You have not completed a full week.");
            }
        }

        static void ElseStatementExample()
        {
            Console.WriteLine("else Statement");
            double hoursWorked = 35;
            if (hoursWorked >= 40)
            {
                Console.WriteLine("You have worked a full week.");
            }
            else
            {
                Console.WriteLine("You have not worked a full week.");
            }
        }

        static void LogicalOperatorsExample()
        {
            Console.WriteLine("Logical Operators");
            bool isFullTime = true;
            bool isOvertime = false;
            Console.WriteLine($"AND: {isFullTime && isOvertime}, OR: {isFullTime || isOvertime}, NOT: {!isOvertime}");
        }

        static void SwitchStatementExample()
        {
            Console.WriteLine("Switch Statement");
            double daysWorked = 5;
            switch (daysWorked)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }
        }

        static void TernaryOperatorExample()
        {
            Console.WriteLine("Ternary Operator");
            double hoursWorked = 42;
            string message = (hoursWorked > 40) ? "Overtime" : "Regular hours";
            Console.WriteLine($"You worked {message}.");
        }

        // Module 4 - Loops
        static void ForLoopExample()
        {
            Console.WriteLine("for Loop");
            double totalHoursWorked = 0;
            for (int day = 1; day <= 5; day++)
            {
                Console.Write($"Enter hours worked on day {day}: ");
                double hours = Convert.ToDouble(Console.ReadLine());
                totalHoursWorked += hours;
            }
            Console.WriteLine($"Total hours worked for the week: {totalHoursWorked}");
        }

        static void WhileLoopExample()
        {
            Console.WriteLine("while Loop");
            double totalHoursWorked = 0;
            int day = 1;
            while (day <= 5)
            {
                Console.Write($"Enter hours worked on day {day}: ");
                double hours = Convert.ToDouble(Console.ReadLine());
                totalHoursWorked += hours;
                day++;
            }
            Console.WriteLine($"Total hours worked for the week: {totalHoursWorked}");
        }

        static void BreakAndContinueExample()
        {
            Console.WriteLine("break and continue");
            double totalHoursWorked = 0;
            for (int day = 1; day <= 5; day++)
            {
                Console.Write($"Enter hours worked on day {day} (enter -1 to stop): ");
                double hours = Convert.ToDouble(Console.ReadLine());

                if (hours == -1)
                {
                    Console.WriteLine("Calculation stopped by user.");
                    break;
                }

                if (hours < 0 || hours > 24)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of hours.");
                    day--; // Decrement day to re-enter the current day
                    continue;
                }

                totalHoursWorked += hours;
            }

            Console.WriteLine($"Total hours worked for the week: {totalHoursWorked}");


