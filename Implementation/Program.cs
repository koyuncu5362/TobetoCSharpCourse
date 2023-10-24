// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//-------------------------------------implementation--------------

//Interfaces Demo

IWorker[] workers = new IWorker[3]
{
    new Worker(),
    new Robot(),
    new Manager()
};
interface IWorker
{
    void Work();


}
interface IEat
{
    void Eat();
}
interface ISalary
{
    void GetSalary();
}
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}
