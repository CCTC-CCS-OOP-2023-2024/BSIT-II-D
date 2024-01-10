using System;

class MenuOrder2
{
    public static int order, choice, coffeeIn, burgerIn, sandwichIn, pizzaIn, milkshakeIn, drinkIn, fruitIn, dessertIn, soupIn, quantity, cash, change, total;
    public static int cap = 80, frap = 70, amer = 80, latt = 90, espre = 85, iced = 85;
    public static int gc = 120, dc = 130, mc = 125, mush = 110, cc = 135, bb = 140;
    public static int rb = 90, sala = 80, tuna = 100, chicken = 85, bacon = 75, pep = 85;
    public static int ts = 180, hc = 150, haw = 150, veg = 140, pipep = 160, pich = 145;
    public static int sc = 85, pb = 75, straw = 85, choc = 85, oreo = 85, vanil = 90;
    public static int coke = 20, sprite = 20, royal = 20, c2 = 15, md = 20, it = 10;
    public static int orange = 30, pine = 35, melon = 30, apple = 25, grape = 35, mango = 30;
    public static int checake = 50, chocake = 50, vancake = 60, chocice = 65, sundae = 55, pudding = 45;
    public static int tomato = 30, fo = 55, chiccorn = 45, vegbeef = 50, broccoli = 45, noodle = 30;
    public static string again;


    public static void DisplayMenu()
    {
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Welcome to Our Cafe <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        Console.WriteLine(">                         |                             |                          <");
        Console.WriteLine(">     1. Coffee           |          4. Pizza           |      7. Fruit Juices     <");
        Console.WriteLine(">*************************|*****************************|**************************<");
        Console.WriteLine(">     2. Burgers          |          5. Milkshakes      |      8. Desserts         <");
        Console.WriteLine(">*************************|*****************************|**************************<");
        Console.WriteLine(">     3. Sandwiches       |          6. Drinks          |      9. Soups            <");
        Console.WriteLine(">                         |                             |                          <");
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
    }

    public static void Order()
    {
        Console.Write("Choose your Order/s: ");
        choice = int.Parse(Console.ReadLine());

        if (choice > 9)
        {
            Console.WriteLine("Please input 1 - 9 ");
            Order();
        }

        switch (choice)
        {
            case 1: Coffee(); break;
            case 2: Burgers(); break;
            case 3: Sandwiches(); break;
            case 4: Pizza(); break;
            case 5: Milkshakes(); break;
            case 6: Drinks(); break;
            case 7: FruitJuices(); break;
            case 8: Desserts(); break;
            case 9: Soups(); break;
        }

        Console.WriteLine();
        Console.Write("Do you wish to Order anything else (Y/N) : ");
        again = Console.ReadLine();
        Console.Write("\n");

        if (again.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            DisplayMenu();
            Order();
        }
        else if (again.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            GenerateBill();
            Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Invalid Input\nPlease try again");
        }
    }

	public static void Coffee(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                      COFFEE                                      <");
		Console.WriteLine(">****************************|****************************|*********************** <");
		Console.WriteLine(">     1. Capuccino - 80      |       3. Americano - 80    |    5. Espresso - 85    <");
		Console.WriteLine(">****************************|****************************|************************<");
		Console.WriteLine(">     2. Frapuccino - 70     |       4. Latte - 90        |    6. Iced Coffee - 85 <");
		Console.WriteLine(">********************************************************************************* <");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Coffee Flavor: ");
		coffeeIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(coffeeIn>6){
		Console.Write("Please input 1 - 6: ");
		coffeeIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (coffeeIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + cap * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + frap * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + amer * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + latt * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + espre * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + bb * quantity;
					break;
			case 7: Environment.Exit(1);
                    break;
            default:
            		break;

						}
		}

		public static void Burgers(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                      BURGERS                                     <");
		Console.WriteLine(">****************************|*************************|************************** <");
		Console.WriteLine(">   1. Grilled Cheese - 120  |   3. Mac & Cheese - 125 |  5. Crispy Chicken - 135  <");
		Console.WriteLine(">****************************|*************************|***************************<");
		Console.WriteLine(">   2. Double Cheese - 130   |   4. Mushroom - 110     |  6. Beef & Bacon - 140    <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Burger Flavor: ");
		burgerIn= Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(burgerIn>6){
		Console.Write("Please input 1 - 6: ");
		burgerIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (burgerIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + gc * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + dc * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + mc * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + mush * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + cc * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + iced * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

				}


		}

		public static void Sandwiches(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                      SANDWICHES                                  <");
		Console.WriteLine(">**************************|*******************************|***********************<");
		Console.WriteLine(">   1. Roasted Beef - 90   |       3. Tuna - 100           |    5. Bacon - 75      <");
		Console.WriteLine(">**************************|*******************************|***********************<");
		Console.WriteLine(">   2. Salami - 80         |       4. Chicken - 85         |    6. Pepperoni - 85  <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Sandwich Flavor: ");
		sandwichIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(sandwichIn>6){
		Console.Write("Please input 1 - 6: ");
		burgerIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (sandwichIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + rb * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + sala * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + tuna * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + chicken * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + bacon * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + pep * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

				}
		}

		public static void Pizza(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                         PIZZA                                    <");
		Console.WriteLine(">*******************************|************************|*************************<");
		Console.WriteLine(">     1. The Supreme - 180      |    3. Hawaiian - 150   |    5. Pepperoni - 160   <");
		Console.WriteLine(">*******************************|************************|*************************<");
		Console.WriteLine(">     2. Ham and Cheese - 150   |    4. Veggie - 140     |    6. Cheese - 145      <");
		Console.WriteLine(">********************************************************|*************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Pizza Flavor: ");
		pizzaIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(pizzaIn>6){
		Console.Write("Please input 1 - 6: ");
		pizzaIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (pizzaIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + ts * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + hc * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + haw * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + veg * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + pipep * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + pich * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

				}

		}

		public static void Milkshakes(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                      MILKSHAKES                                  <");
		Console.WriteLine(">******************************|**************************|********************** *<");
		Console.WriteLine(">     1. Salted Caramel - 85   |     3. Strawberry - 85   |    5. Oreo - 85        <");
		Console.WriteLine(">******************************|**************************|************************<");
		Console.WriteLine(">     2. Peanut Butter - 75    |     4. Chocolate - 85    |    6. Vanilla - 90     <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Milkshake Flavor: ");
		milkshakeIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(milkshakeIn>6){
		Console.Write("Please input 1 - 6: ");
		milkshakeIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (milkshakeIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + sc * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + pb * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + straw * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + choc * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + oreo * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + vanil * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

				}

		}

		public static void Drinks(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                      DRINKS                                      <");
		Console.WriteLine(">*************************|*****************************|**************************<");
		Console.WriteLine(">   1. Coke - 20          |       3. Royal - 20         |   5. Mountain Dew - 20   <");
		Console.WriteLine(">*************************|*****************************|**************************<");
		Console.WriteLine(">   2. Sprite - 20        |       4. C2 - 15            |   6. Iced Tea - 10       <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Drink Flavor: ");
		drinkIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(drinkIn>6){
		Console.Write("Please input 1 - 6: ");
		drinkIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (drinkIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + coke * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + sprite * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + royal * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + c2 * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + md * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + it * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

				}

		}

		public static void FruitJuices(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                    Fruit Juices                                  <");
		Console.WriteLine(">**************************|*****************************|*************************<");
		Console.WriteLine(">     1. Orange - 30       |         3. Melon - 30       |     5. Grape - 35       <");
		Console.WriteLine(">**************************|*****************************|*************************<");
		Console.WriteLine(">     2. Pineapple - 35    |         4. Apple - 25       |     6. Mango - 30       <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Fruit Juice Flavor: ");
		fruitIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(fruitIn>6){
		Console.Write("Please input 1 - 6: ");
		fruitIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (fruitIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + orange * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + pine * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + melon * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + apple * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + grape * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + mango * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

		}

		}

		public static void Desserts(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                      DESSERTS                                    <");
		Console.WriteLine(">****************************|****************************|************************<");
		Console.WriteLine(">   1. Cheese Cake - 50      |   3. Vanilla Cake - 60     |    5. Sundae - 55      <");
		Console.WriteLine(">****************************|****************************|************************<");
		Console.WriteLine(">   2. Chocolate Cake - 50   |   4. Choco Ice Cream - 65  |    6. Pudding - 45     <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Dessert Flavor: ");
		dessertIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(dessertIn>6){
		Console.Write("Please input 1 - 6: ");
		dessertIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (dessertIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + checake * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + chocake * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + vancake * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + chocice * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + sundae * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + pudding * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

						}

		}

		public static void Soups(){
		Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
		Console.WriteLine(">                                                                                  <");
		Console.WriteLine(">                                       SOUPS                                      <");
		Console.WriteLine(">***************************|*****************************|************************<");
		Console.WriteLine(">     1. Tomato - 30        |    3. Chicken corn - 45     |   5. Broccoli - 45     <");
		Console.WriteLine(">***************************|*****************************|************************<");
		Console.WriteLine(">     2. French Onion - 55  |    4. Vegetable Beef - 50   |   6. Noodle - 30       <");
		Console.WriteLine(">**********************************************************************************<");
		Console.WriteLine(">                             Input 0 to back to Main Menu                         <");
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
		Console.Write("Select Soup Flavor: ");
		soupIn = Convert.ToInt32(Console.ReadLine());;
		Console.Write("\n");
		if(soupIn>6){
		Console.Write("Please input 1 - 6: ");
		soupIn = Convert.ToInt32(Console.ReadLine());;
		}

		switch (soupIn){
			case 1: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + tomato * quantity;
					break;
			case 2: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + fo * quantity;
					break;
			case 3: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + chiccorn * quantity;
					break;
			case 4: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + vegbeef * quantity;
					break;
			case 5: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + broccoli * quantity;
					break;
			case 6: Console.Write("Enter quantity: ");
					quantity = Convert.ToInt32(Console.ReadLine());;
					total = total + noodle * quantity;
					break;
			case 0: DisplayMenu();Order();
					break;
			default:
					break;

				}

		}

		public static void GenerateBill()
		{
			Console.Write("Enter Cash: ");
			cash = Convert.ToInt32(Console.ReadLine());;
			change = cash - total;
			Console.Write("\n");
			if(change>0){
			Console.WriteLine("****************************** Thank you for Ordering ******************************");
        	Console.WriteLine("********************************* Your Bill is: " +total+" *********************************");
			Console.WriteLine("********************************* Your Change is: " +change+" *******************************\n");
			}else if(change<0){
			Console.WriteLine("********************************* Your Bill is: " +total+" *********************************");
			Console.WriteLine("********************************* Insufficient Cash *********************************\n");
			}else{Console.WriteLine("Invalid amount");
			}

		}


		static void Main(string []args){


	DisplayMenu();

		Order();


    }

}