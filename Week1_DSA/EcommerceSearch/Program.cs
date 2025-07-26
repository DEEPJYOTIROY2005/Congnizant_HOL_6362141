using System;

class Program
{
    static void Main()
    {
        // Create a sample product list
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shoes", "Fashion"),
            new Product(103, "Watch", "Accessories"),
            new Product(104, "Smartphone", "Electronics")
        };

        Console.WriteLine("=== E-Commerce Product Search ===");

        Console.Write("Enter product name to search: ");
        string searchName = Console.ReadLine();

        // Linear Search
        Product? linearResult = LinearSearch.SearchByName(products, searchName);
        if (linearResult != null)
        {
            Console.WriteLine("Linear Search Result: " + linearResult);
        }
        else
        {
            Console.WriteLine("Linear Search: Product not found");
        }

        // Binary Search
        Product? binaryResult = BinarySearch.SearchByName(products, searchName);
        if (binaryResult != null)
        {
            Console.WriteLine("Binary Search Result: " + binaryResult);
        }
        else
        {
            Console.WriteLine("Binary Search: Product not found");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
