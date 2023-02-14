using System;
using System.Collections.Generic;

// Create a class 
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Type { get; set; }

    // Create a constructor
    public Product(string Name, double Price, int Quantity, string Type)
    {
        this.Name = Name;
        this.Price = Price;
        this.Quantity = Quantity;
        this.Type = Type;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Product 
        List<Product> products = new List<Product>
        {
            new Product("lettuce", 10.5, 50, "Leafy green"),
            new Product("cabbage", 20, 100, "Cruciferous"),
            new Product("pumpkin", 30, 30, "Marrow"),
            new Product("cauliflower", 10, 25, "Cruciferous"),
            new Product("zucchini", 20.5, 50, "Marrow"),
            new Product("yam", 30 , 50, "Root"),
            new Product("spinach", 10 , 100, "Leafy green"),
            new Product("broccoli", 20.2 , 75, "Cruciferous"),
            new Product("garlic", 30 , 20, "Leafy green"),
            new Product("silverbeet", 10 , 50, "Marrow")
        };

        // Print the total number of products in the list
        Console.WriteLine(products.Count());
        Console.WriteLine();

        // Create a new Product , add to the list
        // new Product("Potato", 10, 50, "Root");

        try
        {
            Console.WriteLine("Enter the name of the product:");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter the price of the product:");
            double newPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the quantity of the product:");
            int newQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the type of the product:");
            string newType = Console.ReadLine();

            Product newProduct = new Product(newName, newPrice, newQuantity, newType);
            products.Add(newProduct);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input! ");
        }

        Console.WriteLine();
        //  print 
        foreach (Product item in products)
        {
            Console.WriteLine($"Products: {item.Name} : {item.Price} : {item.Quantity} : {item.Type}");
        }
        Console.WriteLine();
        // Print the total number of products in the list
        Console.WriteLine("Total numbers of the Products : " + products.Count());
        Console.WriteLine();
        // Loop through the list of products and print out the properties of each product that has a type of "Leafy green"
        foreach (Product item in products)
        {
            if (item.Type == "Leafy green")
            {
                Console.WriteLine($"Product: {item.Name} : {item.Price} : {item.Quantity} : {item.Type}");
            }
        }

        // Remove garlic
        products.RemoveAll(product => product.Name == "garlic");
        Console.WriteLine("Total number of products left: " + products.Count);

        // Find  "cabbage" 
        Product cabbageProduct = products.Find(product => product.Name == "cabbage");

        // Add 50  cabbage 
        cabbageProduct.Quantity += 50;

        // Print  total cabbage 
        Console.WriteLine("Quantity of cabbage : " + cabbageProduct.Quantity);

        // Find 3 product 
        Product lettuceProduct = products.Find(product => product.Name == "lettuce");
        Product zucchiniProduct = products.Find(product => product.Name == "zucchini");
        Product broccoliProduct = products.Find(product => product.Name == "broccoli");

        // Calculate the total cost
        double totalCost = (lettuceProduct.Price * 1) + (zucchiniProduct.Price * 2) + (broccoliProduct.Price * 1);

        // Round
        int roundedTotalCost = (int)Math.Round(totalCost);
        Console.WriteLine();
        // Print 
        Console.WriteLine("Round figure  user needs to pay: " + roundedTotalCost);





    }
}