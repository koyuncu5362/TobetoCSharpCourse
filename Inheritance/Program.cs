// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// -------------------------------INHERİTANCE------------------------
Person[] persons = new Person[3]
{
    new Person{FirstName="Mahmut" },new Customer7{FirstName="Metin" },new Student{FirstName="Koyuncu" }
};
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer7 : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Class { get; set; }
}