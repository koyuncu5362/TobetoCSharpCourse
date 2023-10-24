// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//---------------------------------------Reference Types-------------------------------

//Strings
string city = "İstanbul";
string city2 = "İzmir";
var result2 = city + city2;
Console.WriteLine(result2);
foreach (var item in city)
{
    Console.WriteLine(item); ;

}
Console.ReadLine();

//String Methods
string sentence = "My name is Metin";
Console.WriteLine(sentence.Length);

var sentence2 = sentence.Clone();
Console.WriteLine(sentence.EndsWith('n'));
Console.WriteLine(sentence.StartsWith("My name"));
Console.WriteLine(sentence.IndexOf("name"));
Console.WriteLine(sentence.LastIndexOf("name"));
Console.WriteLine(sentence.Insert(0, "hello, "));
Console.WriteLine(sentence.Substring(3));
Console.WriteLine(sentence.Substring(3, 5));
Console.WriteLine(sentence.ToUpper());
Console.WriteLine(sentence.ToLower());
Console.WriteLine(sentence.Replace(" ", "-"));
Console.WriteLine(sentence.Remove(2, 4));
Console.ReadLine();