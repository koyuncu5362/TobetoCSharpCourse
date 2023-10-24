// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//---------------------------------------Classes-------------------------------
CustomerManager manager = new CustomerManager();
manager.Update();
Console.ReadLine();




//Props
CustomerManager2 manager2 = new CustomerManager2();
manager2.CustomerId = 35;
CustomerManager2 manager3 = new CustomerManager2()
{
    CustomerId = 5
};
manager2.Update();
Console.ReadLine();
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }

}
class CustomerManager2
{
    public int CustomerId { get; set; }
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }

}




//Encapsulation

class Customer : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Region { get { return "City " + Region; } set { Region = value; } }

    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IPerson.FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IPerson.LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
interface IPerson
{
    int Id { get; set; }
    int FirstName { get; set; }
    int LastName { get; set; }

}
