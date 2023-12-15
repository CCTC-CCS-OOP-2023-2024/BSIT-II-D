using System;

class ATM
{
    static void Main()
    {
        Console.WriteLine("Welcome to the ATM!");

        // Initialize account balance
        double accountBalance = 1000;

        // Main menu
        while (true)
        {
            Console.WriteLine("\n1. View Balance");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Deposit Money");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewBalance(accountBalance);
                    break;
                case 2:
                    WithdrawMoney(ref accountBalance);
                    break;
                case 3:
                    DepositMoney(ref accountBalance);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewBalance(double balance)
    {
        Console.WriteLine($"\nYour current balance is: ${balance}");
    }

    static void WithdrawMoney(ref double balance)
    {
        Console.Write("\nEnter the amount to withdraw: $");
        double amount = double.Parse(Console.ReadLine());

        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrew ${amount}. Your new balance is: ${balance}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
        }
        else
        {
            Console.WriteLine("Insufficient funds. Unable to withdraw.");
        }
    }

    static void DepositMoney(ref double balance)
    {
        Console.Write("\nEnter the amount to deposit: $");
        double amount = double.Parse(Console.ReadLine());

        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited ${amount}. Your new balance is: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
        }
    }
}
