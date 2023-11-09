namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Metin", "Esra", "Mahmut" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            
            List<string> names2 = new List<string>();
            names2.Add("Metin");
            names2.Add("Mahmut");
            names2.Add("Esra");
            Console.WriteLine(names2[0]);
            names2.Add("Taha");
            Console.WriteLine(names[4]);
        }
    }
}