public class LinearSearch
{
    public static Product? SearchByName(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (string.Equals(product.ProductName, name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }
}
