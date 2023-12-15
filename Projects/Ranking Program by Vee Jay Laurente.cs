


using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Welcome to Ranking of Heroes!");
        Console.WriteLine("Enter your score for 3 categories (each on a new line):");

       
        int category1 = int.Parse(Console.ReadLine());
        int category2 = int.Parse(Console.ReadLine());
        int category3 = int.Parse(Console.ReadLine());

      
        int totalScore = category1 + category2 + category3;
        int averageScore = totalScore / 3;

    
        Console.WriteLine($"The average ranking is {averageScore}.");

        if (averageScore >= 90)
        {
            Console.WriteLine("Your rank is: S");
        }
        else if (averageScore >= 80)
        {
            Console.WriteLine("Your rank is: A");
        }
        else if (averageScore >= 70)
        {
            Console.WriteLine("Your rank is: B");
        }
        else if (averageScore >= 60)
        {
            Console.WriteLine("Your rank is: C");
        }
        else
        {
            Console.WriteLine("Your rank is: D");
        }
    }
}