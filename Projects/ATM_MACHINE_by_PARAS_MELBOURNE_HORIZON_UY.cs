using System;

class Program
{
    static void Main()
    {
        // Variables and Data Types
        int accountNumber;
        double accountBalance = 1000.0;

        // Doing Math
        double depositAmount, withdrawalAmount;

        // More on Strings (\n \t @)
        string welcomeMessage = "Welcome to the ATM Machine!\n";
        string instructions = "Options:\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Exit\n";

        // User Input
        Console.Write("Enter your account number: ");
        if (int.TryParse(Console.ReadLine(), out accountNumber))
        {
            Console.WriteLine($"Welcome, Account #{accountNumber}!\n");

            // Menu
            Console.WriteLine(instructions);
            int choice = int.Parse(Console.ReadLine());

            // if Statement
            if (choice == 1)
            {
                Console.WriteLine($"Your current balance: ${accountBalance}\n");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the deposit amount: $");
                if (double.TryParse(Console.ReadLine(), out depositAmount))
                {
                    accountBalance += depositAmount;
                    Console.WriteLine($"Deposit successful! New balance: ${accountBalance}\n");
                }
                else
                {
                    Console.WriteLine("Invalid input for deposit amount.\n");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter the withdrawal amount: $");
                if (double.TryParse(Console.ReadLine(), out withdrawalAmount))
                {
                    if (withdrawalAmount <= accountBalance)
                    {
                        accountBalance -= withdrawalAmount;
                        Console.WriteLine($"Withdrawal successful! New balance: ${accountBalance}\n");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for withdrawal amount.\n");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the ATM. Goodbye!\n");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }

            // Logical Operators
            bool isLowBalance = accountBalance < 500;
            bool isHighBalance = accountBalance > 2000;

            if (isLowBalance)
            {
                Console.WriteLine("Low balance alert! Consider depositing more funds.\n");
            }
            else if (isHighBalance)
            {
                Console.WriteLine("You have a healthy account balance!\n");
            }

            // switch Statement
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your current balance: ${accountBalance}\n");
                    break;
                case 2:
                    Console.Write("Enter the deposit amount: $");
                    double deposit = double.Parse(Console.ReadLine());
                    accountBalance += deposit;
                    Console.WriteLine($"Deposit successful! New balance: ${accountBalance}\n");
                    break;
                case 3:
                    Console.Write("Enter the withdrawal amount: $");
                    double withdrawal = double.Parse(Console.ReadLine());
                    if (withdrawal > accountBalance)
                    {
                        Console.WriteLine("Insufficient funds!\n");
                    }
                    else
                    {
                        accountBalance -= withdrawal;
                        Console.WriteLine($"Withdrawal successful! New balance: ${accountBalance}\n");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }

            // Ternary Operator
            string accountStatus = (accountBalance > 0) ? "Active" : "Inactive";
            Console.WriteLine($"Account status: {accountStatus}\n");

            // for Loop
            Console.WriteLine("Transaction History:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Transaction #{i}");
            }

            // while Loop
            int pinAttempts = 3;
            while (pinAttempts > 0)
            {
                Console.Write("Enter your PIN: ");
                string enteredPIN = Console.ReadLine();

                if (enteredPIN == "1234")
                {
                    Console.WriteLine("PIN accepted. Access granted!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Attempts remaining: " + --pinAttempts + "\n");
                }
            }

            // break and continue
            Console.WriteLine("Multiples of 5:");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 5 != 0)
                    continue;

                Console.Write($"{i} ");
            }

            // Methods
            DisplayTransactionHistory(accountNumber);

            double updatedBalance = ProcessWithdrawal(accountBalance, 50.0);
            Console.WriteLine($"Updated balance after withdrawal: ${updatedBalance}\n");

            Console.WriteLine("End of program.");
        }
        else
        {
            Console.WriteLine("Invalid input for the account number. Please try again.\n");
        }
    }

    // Method to display transaction history
    static void DisplayTransactionHistory(int accountNumber)
    {
        Console.WriteLine($"\nTransaction history for Account #{accountNumber}:");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Transaction #{i}");
        }
    }

    // Method to process a withdrawal and return the updated balance
    static double ProcessWithdrawal(double currentBalance, double withdrawalAmount)
    {
        if (withdrawalAmount > currentBalance)
        {
            Console.WriteLine("Insufficient funds for withdrawal.");
            return currentBalance;
        }

        currentBalance -= withdrawalAmount;
        Console.WriteLine($"Withdrawal successful! New balance: ${currentBalance}");
        return currentBalance;
    }
}