using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Change connection string according to your setup
        optionsBuilder.UseSqlServer(@"Server=localhost\MSSQLSERVER01;Database=RetailInventoryTest;Trusted_Connection=True;TrustServerCertificate=True;");

    }
}
