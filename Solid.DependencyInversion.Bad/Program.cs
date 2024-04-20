namespace Solid.DependencyInversion;

internal class Program
{
    static void Main(string[] args)
    {
        ProductService sqlService = new ProductService(new ProductRepositorySqlServer());
        List<Product> products = sqlService.GetAll();
        foreach (var p in products)
        {
            Console.WriteLine(p.Name);
        }

        ProductService oracleService = new ProductService(new ProductRepositoryOracleServer());
        
        //2. Yol
        Console.WriteLine("****************2. YÖNTEM******************");
        oracleService.GetAll().ForEach(x => Console.WriteLine(x.Name));
    }
}
