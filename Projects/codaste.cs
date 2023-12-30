using System;

public class Myclothingshop
{
    public static int order, all = 0, amount, menu1, menu2, menu3;
    public static readonly int louis_Vuitton_PRICE = 66360,
        hermes_internatonal_PRICE = 45000,
        burbery_PRICE = 35000,
        marc_jacobs_PRICE = 20000,
        balmain_PRICE = 20000,
        levis_PRICE = 10000,
        lee_PRICE = 1500,
        wrangler_PRICE = 4000,
        AG_jeans_PRICE = 4500,
        puma_PRICE = 3000,
        adidas_PRICE = 10000,
        skechers_PRICE = 5000;

    public static void Main(string[] args)
    {
        //do while statement
        do
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n"+
                             "=          main brand                 \n"+
                             "=   1.t-shirt brand   2.jeans brand   \n"+
                             "=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                             "=   3.shoes brand     4.exit          \n"+
                             "=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
           

            Console.Write("Enter your order here: ");
            order = int.Parse(Console.ReadLine());

            switch (order)
            {
                case 1:
                    Menu1();
                    break;
                case 2:
                    Menu2();
                    break;
                case 3:
                    Menu3();
                    break;
                default:
                    Console.WriteLine("Invalid selection\n");
                    break;
            }
           
            if (overall > MAX_ORDER_AMOUNT)
            {
                Console.WriteLine("You've reached the maximum order amount. Cannot add more items.");
            }
            else if (overall < MIN_ORDER_AMOUNT)
            {
                Console.WriteLine("Minimum order amount not reached. Please add more items to your order.");
            }
            else
            {
                Console.WriteLine($"Your current order total is: {overall}");
            }

            Console.WriteLine("Thank you");
            Console.WriteLine($"Your Overall Bill: {all}\n");

        } while (order != 4);

        Console.WriteLine("Final Summary:");
    }

    //t-shirt brand
    public static void Menu1()
    {
        Console.WriteLine(">>>>>>>>>>>>>>>.............");
        Console.WriteLine("-  1. louis_Vuitton 66360    -");
        Console.WriteLine("-  2. hermes_internatonal 45000   -");
        Console.WriteLine("-  3.   burbery 35000       -");
        Console.WriteLine("-  4.   marc_jacobs 20000      -");
        Console.WriteLine("-  5. balmain 20000     -");
        Console.WriteLine(">>>>>>>>>>>>>>>.............");
        Console.Write("Select Your t-shirt: ");
        menu1 = int.Parse(Console.ReadLine());

        switch (menu1)
        {
            case 1:
                Console.Write("Enter Quantityy: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} louis_Vuitton\n");
                all += louis_Vuitton_PRICE * amount;
                break;
            case 2:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} hermes_internatonal\n");
                all += hermes_internatonal_PRICE * amount;
                break;
            case 3:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} burbery\n");
                all += burbery_PRICE * amount;
                break;
            case 4:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} marc_jacobs\n");
                all += marc_jacobs_PRICE * amount;
                break;
            case 5:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} balmain\n");
                all += balmain_PRICE * amount;
                break;
            default:
                Console.WriteLine("Invalid selection");
                break;
        }
       
        if (overall > MAX_ORDER_AMOUNT)
            {
                Console.WriteLine("You've reached the maximum order amount. Cannot add more items.");
            }
            else if (overall < MIN_ORDER_AMOUNT)
            {
                Console.WriteLine("Minimum order amount not reached. Please add more items to your order.");
            }
            else
            {
                Console.WriteLine($"Your current order total is: {overall}");
            }
    }

    public static void Menu2()
    {
        Console.WriteLine(">>>>>>>>>>>.............");
        Console.WriteLine("-  1. levis 10000      -");
        Console.WriteLine("-  2.  lee  1500       -");
        Console.WriteLine("-  3.  wrangler 4000   -");
        Console.WriteLine("-  4. AG_jeans  4500   -");
        Console.WriteLine("<<<<<<<<<<<<............");
        Console.Write("Select Your jeans: ");
        menu2 = int.Parse(Console.ReadLine());

        switch (menu2)
        {
            case 1:
                Console.Write(" Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} levis\n");
                all += levis_PRICE * amount;
                break;
            case 2:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount}  lee\n");
                all += lee_PRICE * amount;
                break;
            case 3:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} wrangler\n");
                all += wrangler_PRICE * amount;
                break;
            case 4:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} AG_jeans\n");
                all += AG_jeans_PRICE * amount;
                break;
            default:
                Console.WriteLine("Invalid selection");
                break;
        }
       
        if (overall > MAX_ORDER_AMOUNT)
            {
                Console.WriteLine("You've reached the maximum order amount. Cannot add more items.");
            }
            else if (overall < MIN_ORDER_AMOUNT)
            {
                Console.WriteLine("Minimum order amount not reached. Please add more items to your order.");
            }
            else
            {
                Console.WriteLine($"Your current order total is: {overall}");
            }
    }

    public static void Menu3()
    {
        Console.WriteLine(">>>>>>>>>>>...........");
        Console.WriteLine("-  1.puma 3000    -");
        Console.WriteLine("-  2.adidas 10000      -");
        Console.WriteLine("-  3.skechers 5000   -");
        Console.WriteLine("<<<<<<<<<<<...........");
        Console.Write("Select Your shoes: ");
        menu3 = int.Parse(Console.ReadLine());

        switch (menu3)
        {
            case 1:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} puma\n");
                all += puma_PRICE * amount;
                break;
            case 2:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} adidas\n");
                all += adidas_PRICE * amount;
                break;
            case 3:
                Console.Write("Enter Quantity: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ordered {amount} skechers\n");
                all += skechers_PRICE * amount;


                break;
            default:
                Console.WriteLine("Invalid selection\n");
                break;
        }
       
        if (overall > MAX_ORDER_AMOUNT)
            {
                Console.WriteLine("You've reached the maximum order amount. Cannot add more items.");
            }
            else if (overall < MIN_ORDER_AMOUNT)
            {
                Console.WriteLine("Minimum order amount not reached. Please add more items to your order.");
            }
            else
            {
                Console.WriteLine($"Your current order total is: {overall}");
            }
}
}
