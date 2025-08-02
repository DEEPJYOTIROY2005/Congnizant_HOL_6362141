using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };
        await context.Categories.AddRangeAsync(electronics, groceries);

        var laptop = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var rice = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };
        await context.Products.AddRangeAsync(laptop, rice);

        await context.SaveChangesAsync();

        Console.WriteLine("Data inserted successfully.");
    }
}
