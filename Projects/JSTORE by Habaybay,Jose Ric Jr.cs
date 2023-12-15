using System;

public class JSTORE
{
	public static int order, allprod = 0, amount, menu1, menu2, menu3;
	public static readonly int Nike_pce = 800, Adidas_pce = 600, Vans_pce = 500,
		Rels_pce = 100, Phew_pce = 250, Wats_pce = 500, Pain_pce = 280,
		Slight_pce = 400, Prime_pce = 500;

	public static void Main(string[] args)
	{
		do
		{
			Console.WriteLine("====================");
			Console.WriteLine("*      JSTORE       *");
			Console.WriteLine("|   1.Shoes         |");
			Console.WriteLine("|   2.Watch         |");
			Console.WriteLine("|   3.Tshirt        |");
			Console.WriteLine("|   4.Exit          |");
			Console.WriteLine("=====================");

			Console.Write("Purchase your order: ");
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
			Console.WriteLine("Thank You\n");
			break;
			}

			Console.WriteLine($"Total Bill: {allprod}\n");

		} while (order != 4);


	}


	public static void Menu1()
	{
		Console.WriteLine("=====================");
		Console.WriteLine("  1. Nike,800      ");
		Console.WriteLine("  2. Adidas,600    ");
		Console.WriteLine("  3. Vans,500      ");
		Console.WriteLine("=====================");
		Console.Write("Select Shoes: ");
		menu1 = int.Parse(Console.ReadLine());

		switch (menu1)
		{
		case 1:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Nike\n");
		allprod += Nike_pce * amount;
		break;
		case 2:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Adidas\n");
		allprod += Adidas_pce * amount;
		break;
		case 3:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Vans\n");
		allprod += Vans_pce * amount;
		break;

		default:
		Console.WriteLine("Invalid");
		break;
		}
	}

	public static void Menu2()
	{
		Console.WriteLine("==================");
		Console.WriteLine("  1. Rels,100  ");
		Console.WriteLine("  2. Phew,250  ");
		Console.WriteLine("  3. Wats,500  ");
		Console.WriteLine("==================");
		Console.Write("Select Watch: ");
		menu2 = int.Parse(Console.ReadLine());

		switch (menu2)
		{
		case 1:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Rels\n");
		allprod += Rels_pce * amount;
		break;
		case 2:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Phew\n");
		allprod += Phew_pce * amount;
		break;
		case 3:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Wats\n");
		allprod += Wats_pce * amount;
		break;

		default:
		Console.WriteLine("Invalid");
		break;
		}
	}

	public static void Menu3()
	{
		Console.WriteLine("==================");
		Console.WriteLine("  1. Pain,280  ");
		Console.WriteLine("  2. Slight,400 ");
		Console.WriteLine("  3. Prime,500  ");
		Console.WriteLine("==================");
		Console.Write("Select Watch: ");
		menu2 = int.Parse(Console.ReadLine());

		switch (menu3)
		{
		case 1:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Pain\n");
		allprod += Pain_pce * amount;
		break;
		case 2:
		Console.Write("Quantity: ");

		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Slight\n");
		allprod += Slight_pce * amount;
		break;
		case 3:
		Console.Write("Quantity: ");
		amount = int.Parse(Console.ReadLine());
		Console.WriteLine($"You ordered {amount} Prime\n");
		allprod += Prime_pce * amount;
		break;

		default:
		Console.WriteLine("Invalid");
		break;
		}
	}
}