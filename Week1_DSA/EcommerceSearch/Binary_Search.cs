using System;

public class BinarySearch
{
    public static Product? SearchByName(Product[] products, string name)
    {
        Array.Sort(products, (a, b) =>
            string.Compare(a.ProductName, b.ProductName, StringComparison.OrdinalIgnoreCase));

        int low = 0, high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int cmp = string.Compare(name, products[mid].ProductName, StringComparison.OrdinalIgnoreCase);

            if (cmp == 0)
                return products[mid];
            else if (cmp < 0)
                high = mid - 1;
            else
                low = mid + 1;
        }

        return null;
    }
}
