// See https://aka.ms/new-console-template for more information
using Tobeto;

Console.WriteLine("Hello, World!");

//---------------------------------------Interfaces-------------------------------

PersonManager manager5 = new PersonManager();
manager5.Add(new Product() { Id = 5, FirstName = 4 });

IPerson myPerson = new Customer();

CustomerManager5 customer2 = new CustomerManager5();
customer2.Add(new SqlServerCustomerDal());

//Polymorphizm
ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleServerCustomerDal(),
    new MySqlServerCustomerDal()
};
interface IPerson
{
    int Id { get; set; }
    int FirstName { get; set; }
    int LastName { get; set; }

}
class Product : IPerson
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
class Product2 : IPerson
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
class PersonManager
{
    public void Add(Product product)
    {
        Console.WriteLine(product.FirstName);
    }
}
