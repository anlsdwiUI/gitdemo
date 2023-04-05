public class Prod
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product { Id = 1, Name = "Product 1", Stock = 10 });
        products.Add(new Product { Id = 2, Name = "Product 2", Stock = 20 });
        products.Add(new Product { Id = 3, Name = "Product 3", Stock = 30 });

    }
}
