namespace Solid.InterfaceSegregationPrinciple;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Id = 1, Name = "Kalem 1"},
            new Product(){Id = 2, Name = "Kalem 2"},
            new Product(){Id = 3, Name = "Kalem 3"}
        };
        ReadProductRepository readProduct = new ReadProductRepository();
        readProduct.GetProductList().AddRange(products);
        WriteProductRepository writeProduct = new WriteProductRepository();
        writeProduct.Create();
        writeProduct.Update();
        writeProduct.Delete();
        foreach (var itemProduct in readProduct.GetProductList())
        {
            Console.WriteLine(itemProduct.Id + " " + itemProduct.Name );
        }

        Console.WriteLine(readProduct.GetById().Name);
    }
}
