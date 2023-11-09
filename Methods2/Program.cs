namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name= "Test";
            product.UnitPrice = 15;
            product.Description = "Description";

            Product product2 = new Product();
            product2.Name = "Test2";
            product2.UnitPrice = 15;
            product2.Description = "Description2";

            Product[] products = new Product[] { product, product2 };
            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.UnitPrice);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Description);
            }
            ProductManager manager = new ProductManager();
            manager.Add(product2);


            manager.AlternativeAdd("Banana", "zz", 35,5);
            manager.AlternativeAdd("Pineapple", "zz", 35,9);
            manager.AlternativeAdd("Strawberry", "zz", 35,7);
        }
    }
}