namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 1;
            product.Name = "Test";
            product.UnitPrice = 7;
            product.UnitsInStock = 10;
            Product product1 = new Product { Id = 2,CategoryId=2,Name="Test2",UnitPrice=50,UnitsInStock=7 };
            
            ProductManager manager = new ProductManager();
            manager.Add()
        }
    }
}