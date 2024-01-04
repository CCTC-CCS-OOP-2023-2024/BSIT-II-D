using System;
using System.Collections.Generic;
using System.Linq; // Add this line for the Sum method

class Program
{
    static List<Product> products = new List<Product>();
    static List<Product> shoppingCart = new List<Product>();

    static void Main()
    {
        InitializeProducts();

        while (true)
        {
            Console.Clear();
            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayProducts();
                    break;
                case "2":
                    AddToCart();
                    break;
                case "3":
                    ViewCart();
                    break;
                case "4":
                    Checkout();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void InitializeProducts()
    {
        products.Add(new Product("1", "Laptop", 999.99));
        products.Add(new Product("2", "Smartphone", 499.99));
        products.Add(new Product("3", "Headphones", 99.99));
        products.Add(new Product("4", "Tablet", 299.99));
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Online Shop Menu:");
        Console.WriteLine("1. Display Products");
        Console.WriteLine("2. Add to Cart");
        Console.WriteLine("3. View Cart");
        Console.WriteLine("4. Checkout");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
    }

    static void DisplayProducts()
    {
        Console.WriteLine("Available Products:");
        Console.WriteLine("ID   Product       Price");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id}    {product.Name}       ${product.Price}");
        }
    }

    static void AddToCart()
    {
        DisplayProducts();
        Console.Write("Enter the ID of the product you want to add to the cart: ");
        string productId = Console.ReadLine();

        Product selectedProduct = products.Find(p => p.Id == productId);
        if (selectedProduct != null)
        {
            shoppingCart.Add(selectedProduct);
            Console.WriteLine($"{selectedProduct.Name} added to the cart.");
        }
        else
        {
            Console.WriteLine("Invalid product ID.");
        }
    }

    static void ViewCart()
    {
        Console.WriteLine("Shopping Cart:");
        Console.WriteLine("ID   Product       Price");
        foreach (var product in shoppingCart)
        {
            Console.WriteLine($"{product.Id}    {product.Name}       ${product.Price}");
        }
    }

    static void Checkout()
    {
        if (shoppingCart.Count == 0)
        {
            Console.WriteLine("Your shopping cart is empty. Add items before checking out.");
        }
        else
        {
            double totalAmount = shoppingCart.Sum(p => p.Price);
            Console.WriteLine($"Total Amount: ${totalAmount}");
            Console.WriteLine("Thank you for shopping with us! Your order has been placed.");
            shoppingCart.Clear();
        }
    }
}

class Product
{
    public string Id { get; }
    public string Name { get; }
    public double Price { get; }

    public Product(string id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}
