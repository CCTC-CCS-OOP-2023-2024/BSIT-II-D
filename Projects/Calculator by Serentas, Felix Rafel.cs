using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;
            int userPin;
            double accountBalance = 1000.00;
            int userChoice;
            double depositAmount;
            double withdrawalAmount;

            Console.WriteLine("Welcome to the ATM!");
            Console.Write("Please enter your PIN: ");
            userPin = Convert.ToInt32(Console.ReadLine());

            if (userPin != pin)
            {
                Console.WriteLine("Invalid PIN. Exiting program.");
                return;
            }

            do
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Make a deposit");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine($"Your account balance is: ${accountBalance}");
                        break;
                    case 2:
                        Console.Write("Enter the amount you would like to deposit: ");
                        depositAmount = Convert.ToDouble(Console.ReadLine());
                        accountBalance += depositAmount;
                        Console.WriteLine($"You have successfully deposited ${depositAmount}. Your new balance is: ${accountBalance}");
                        break;
                    case 3:
                        Console.Write("Enter the amount you would like to withdraw: ");
                        withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawalAmount > accountBalance)
                        {
                            Console.WriteLine("Insufficient funds. Cannot complete withdrawal.");
                        }
                        else
                        {
                            accountBalance -= withdrawalAmount;
                            Console.WriteLine($"You have successfully withdrawn ${withdrawalAmount}. Your new balance is: ${accountBalance}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (userChoice != 4);
        }
    }
}