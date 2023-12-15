using System;

class WebDeveloper
{
    static void Main()
    {
        const int MaxDevelopers = 5;
        WebDeveloper[] developers = new WebDeveloper[MaxDevelopers];

        for (int i = 0; i < MaxDevelopers; i++)
        {
            developers[i] = CreateDeveloper();
        }

        DisplaySummaryReport(developers);
    }

    static WebDeveloper CreateDeveloper()
    {
        Console.WriteLine("Enter the name of the web developer:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the hours worked this week:");
        int hoursWorked = int.Parse(Console.ReadLine());

        return new WebDeveloper(name, hoursWorked);
    }

    static void DisplaySummaryReport(WebDeveloper[] developers)
    {
        Console.WriteLine("\nSummary Report:");

        foreach (var developer in developers)
        {
            Console.WriteLine($"{developer.Name}'s Salary: {developer.Salary:C}");
        }

        decimal totalSalary = CalculateTotalSalary(developers);
        Console.WriteLine($"\nTotal Salary for All Developers: {totalSalary:C}");
    }

    static decimal CalculateTotalSalary(WebDeveloper[] developers)
    {
        decimal totalSalary = 0;

        foreach (var developer in developers)
        {
            totalSalary += developer.Salary;
        }

        return totalSalary;
    }

    class WebDeveloper
    {
        public string Name { get; private set; }
        public int HoursWorked { get; private set; }
        public decimal Salary { get; private set; }

        public WebDeveloper(string name, int hoursWorked)
        {
            Name = name;
            HoursWorked = hoursWorked;
            Salary = CalculateSalary(hoursWorked);
        }

        private decimal CalculateSalary(int hoursWorked)
        {
            const decimal HourlyRate = 30.00M;
            const int WeeklyHours = 40;
            const decimal OvertimeRate = 1.5M;

            decimal salary;

            if (hoursWorked <= WeeklyHours)
            {
                salary = hoursWorked * HourlyRate;
            }
            else
            {
                int regularHours = WeeklyHours;
                int overtimeHours = hoursWorked - WeeklyHours;

                salary = regularHours * HourlyRate + overtimeHours * HourlyRate * OvertimeRate;
            }

            return salary;
        }
    }
}