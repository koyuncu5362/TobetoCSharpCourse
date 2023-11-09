namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.FirstName = "Metin";
            //customer1.LastName = "Koyuncu";
            //customer1.Id= 1;
            //customer1.TcNo = "+656546545";
            //customer1.CustomerNo = "654654656488";
            RealCustomer customer = new RealCustomer();
            customer.Id= 1;
            customer.FirstName = "aslşasg";
            customer.CustomerNo = "37965";

            LegalCustomer customer1= new LegalCustomer();
            customer.Id = 2;
            customer.FirstName = "aslşasg";
            customer.CustomerNo = "37965";

            Customer customer2 = new RealCustomer();
            Customer customer3 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();    
            customerManager.Add(customer3);
        }

    }
}