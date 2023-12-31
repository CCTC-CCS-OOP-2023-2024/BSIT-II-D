using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeMessage();
            DisplayMenuOptions();
            HandleUserChoice();
        }

        // Strings, Concatenation, Variables
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Our Restaurant!\n");
        }

        // Variables, Data Types, Arithmetic Operators, Ternary Operator
        static void DisplayMenuOptions()
        {
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Exit\n");
        }

        // User Input, if-else Statements, while Loop
        static void HandleUserChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Enter your choice (1-3): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewMenu();
                        break;
                    case 2:
                        PlaceOrder();
                        break;
                    case 3:
                        Console.WriteLine("\nThank you for visiting!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }
            }
        }

        // More on Strings, \t for tab, Parameters and Arguments
        static void ViewMenu()
        {
            Console.WriteLine("\nOur Menu:\n");
            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine("======================");
            Console.WriteLine("1. Burger\t\t$5");
            Console.WriteLine("2. Pizza\t\t$8");
            Console.WriteLine("3. Pasta\t\t$7");
            Console.WriteLine("4. Salad\t\t$4");
            Console.WriteLine("5. Drink\t\t$2\n");
        }

        // Logical Operators, while Loop, break and continue
        static void PlaceOrder()
        {
            bool isOrdering = true;
            while (isOrdering)
            {
                Console.WriteLine("\nPlace Your Order:");
                Console.Write("Enter item number: ");
                int itemNumber = Convert.ToInt32(Console.ReadLine());

                if (itemNumber < 1 || itemNumber > 5)
                {
                    Console.WriteLine("\nInvalid item number. Please try again.");
                    continue;
                }

                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                double totalPrice = CalculatePrice(itemNumber, quantity);
                Console.WriteLine($"\nTotal Price: ${totalPrice}");

                Console.Write("\nWould you like to order more items? (yes/no): ");
                string continueOrder = Console.ReadLine().ToLower();

                isOrdering = continueOrder == "yes";
            }
        }

        // Methods, Returning from Methods
        static double CalculatePrice(int itemNumber, int quantity)
        {
            double price = 0;

            switch (itemNumber)
            {
                case 1:
                    price = 5;
                    break;
                case 2:
                    price = 8;
                    break;
                case 3:
                    price = 7;
                    break;
                case 4:
                    price = 4;
                    break;
                case 5:
                    price = 2;
                    break;
            }

            return price * quantity;
        }
    }
}