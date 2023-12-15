using System;

class Program
{
    static int amount = 0;
    static int dish;

    static void Main(string[] args)
    {
        ServeCustomers(3); // Example: Serve 3 customers
    }

    static void ServeCustomers(int numberOfCustomers)
    {
        for (int customerNumber = 1; customerNumber <= numberOfCustomers; customerNumber++)
        {
            Console.WriteLine($"Customer {customerNumber}");

            do
            {
                DisplayMenu();

                Console.Write("Select a number: ");
                dish = Convert.ToInt32(Console.ReadLine());

                switch (dish)
                {
                    case 1:
                        MainDish();
                        break;
                    case 2:
                        Beverages();
                        break;
                    case 3:
                        Desserts();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (dish <= 4);

            Console.Write("Serve another customer? (y/n): ");
            string serveAnother = Console.ReadLine();
            if (serveAnother.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Thank you for serving customers. Exiting program. Goodbye!");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("***********************************\n" +
                          $"** ***************************** **\n" +
                          "** FoodHeji's Restaurant **\n" +
                          "** Select:1 Main Dish **\n" +
                          "** Select:2 Beverages **\n" +
                          "** Select:3 Desserts **\n" +
                          "** Select:4 Exit **\n" +
                          $"** ***************************** **\n" +
                          "***********************************\n");
    }

    static void MainDish()
    {
        do
        {
            DisplayMainDishMenu();

            Console.Write("Enter the dish number (1, 2, 3, or 5 to exit): ");
            dish = Convert.ToInt32(Console.ReadLine());

            if (dish == 1 || dish == 2 || dish == 3)
            {
                ProcessMainDishChoice(dish);
            }
            else if (dish == 5)
            {
                break;
            }

        } while (dish != 5);
    }

    static void DisplayMainDishMenu()
    {
        Console.WriteLine("************************************\n" +
                          $"** ****************************** **\n" +
                          "** Main Dish Price **\n" +
                          "** 1: Meatballs = 59 **\n" +
                          "** 2: Beef Enchiladas = 199 **\n" +
                          "** 3: Frito Pie = 156 **\n" +
                          "** Press 5: Back to the Menu **\n" +
                          $"** ****************************** **\n" +
                          "************************************\n");
    }

    static void ProcessMainDishChoice(int choice)
    {
        Console.Write($"Enter the Number of Serving/s for {GetMainDishName(choice)}: ");
        int servings = Convert.ToInt32(Console.ReadLine());
        int totalAmount = servings * GetMainDishPrice(choice);
        AddToOrder(totalAmount);
    }

    static string GetMainDishName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Meatballs";
            case 2:
                return "Beef Enchiladas";
            case 3:
                return "Frito Pie";
            default:
                return string.Empty;
        }
    }

    static int GetMainDishPrice(int choice)
    {
        switch (choice)
        {
            case 1:
                return 59;
            case 2:
                return 199;
            case 3:
                return 156;
            default:
                return 0;
        }
    }

    static void Beverages()
    {
        do
        {
            DisplayBeveragesMenu();

            Console.Write("Enter the dish (1 for apple cider, 2 for cocktail, 3 for royal, 5 to exit): ");
            dish = Convert.ToInt32(Console.ReadLine());

            if (dish == 1 || dish == 2 || dish == 3)
            {
                ProcessBeveragesChoice(dish);
            }
            else if (dish == 5)
            {
                break;
            }

        } while (dish != 5);
    }

    static void DisplayBeveragesMenu()
    {
        Console.WriteLine("************************************\n" +
                          $"** ****************************** **\n" +
                          "** Beverages Price **\n" +
                          "** 1: Apple Cider = 53 **\n" +
                          "** 2: Cocktail = 259 **\n" +
                          "** 3: Royal = 15 **\n" +
                          "** Press 5: Back to the Menu **\n" +
                          $"** ****************************** **\n" +
                          "************************************\n");
    }

    static void ProcessBeveragesChoice(int choice)
    {
        Console.Write($"Enter the quantity for {GetBeveragesName(choice)}: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        int totalAmount = quantity * GetBeveragesPrice(choice);
        AddToOrder(totalAmount);
    }

    static string GetBeveragesName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Apple Cider";
            case 2:
                return "Cocktail";
            case 3:
                return "Royal";
            default:
                return string.Empty;
        }
    }

    static int GetBeveragesPrice(int choice)
    {
        switch (choice)
        {
            case 1:
                return 53;
            case 2:
                return 259;
            case 3:
                return 15;
            default:
                return 0;
        }
    }

    static void Desserts()
    {
        do
        {
            DisplayDessertsMenu();

            Console.Write("Select a number: ");
            dish = Convert.ToInt32(Console.ReadLine());

            if (dish == 1 || dish == 2 || dish == 3)
            {
                ProcessDessertsChoice(dish);
            }
            else if (dish == 5)
            {
                break;
            }

        } while (dish == 5);
    }

    static void DisplayDessertsMenu()
    {
        Console.WriteLine("************************************\n" +
                          $"** ****************************** **\n" +
                          "** Desserts Price **\n" +
                          "** 1: Cake = 65 **\n" +
                          "** 2: Cupcakes = 89 **\n" +
                          "** 3: Choco Ice Cream = 75 **\n" +
                          "** Press 5: Back to the Menu **\n" +
                          $"** ****************************** **\n" +
                          "************************************\n");
    }

    static void ProcessDessertsChoice(int choice)
    {
        Console.Write($"Enter the Number of Serving/s for {GetDessertsName(choice)}: ");
        int servings = Convert.ToInt32(Console.ReadLine());
        int totalAmount = servings * GetDessertsPrice(choice);
        AddToOrder(totalAmount);
    }

    static string GetDessertsName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Cake";
            case 2:
                return "Cupcakes";
            case 3:
                return "Choco Ice Cream";
            default:
                return string.Empty;
        }
    }

    static int GetDessertsPrice(int choice)
    {
        switch (choice)
        {
            case 1:
                return 65;
            case 2:
                return 89;
            case 3:
                return 75;
            default:
                return 0;
        }
    }

    static void AddToOrder(int totalAmount)
    {
        amount += totalAmount;
        Console.WriteLine($"Added to your order. Your current total: {amount}");
    }
}