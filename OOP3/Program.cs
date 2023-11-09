namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager manager = new HabitationCreditManager();
            manager.Calculate();

            ICreditManager manager1 = new DemandCreditManager();
            manager1.Calculate();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.DoRecourse(manager1,new DbLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                manager1, manager
            };
            recourseManager.CreditPreInfo(credits);


        }
    }
}