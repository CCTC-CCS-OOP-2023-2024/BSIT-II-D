using System;

class CozyCoffeeShop
{
    static void Main()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter the number of hours you worked this week:");
        int hours = int.Parse(Console.ReadLine());

        CalculateMaterials(name, hours);
        DisplayBonusInformation(hours);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static void CalculateMaterials(string name, int hours)
    {
        double plastic = 0;
        double metal = 0;
        double glass = 0;

        if (hours >= 0 && hours <= 20)
        {
            plastic = hours * 2;
            metal = hours * 3;
            glass = hours * 1;
        }
        else if (hours > 20 && hours <= 40)
        {
            plastic = hours * 1.5;
            metal = hours * 2.5;
            glass = hours * 0.5;
        }
        else if (hours > 40 && hours <= 60)
        {
            plastic = hours * 1;
            metal = hours * 2;
            glass = hours * 0.5;
        }
        else if (hours > 60)
        {
            plastic = hours * 0.5;
            metal = hours * 1;
            glass = hours * 0.25;
        }

        Console.WriteLine("\nName: " + name);
        Console.WriteLine("Hours worked this week: " + hours);
        Console.WriteLine("Plastic needed: " + plastic);
        Console.WriteLine("Metal needed: " + metal);
        Console.WriteLine("Glass needed: " + glass);
    }

    static void DisplayBonusInformation(int hours)
    {
        if (hours > 40)
        {
            Console.WriteLine("\nCongratulations! You qualify for a bonus.");
            Console.WriteLine("Bonus details: Additional 5% pay for extra hours.");
        }
    }
}
