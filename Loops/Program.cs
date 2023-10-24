// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//----------------------------Loops------------------------


//For
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();

//While

int number20 = 100;
while (number20 >= 0)
{
    number20--;
    Console.WriteLine(number20);
}

//Do While

number20 = 100;
do
{
    Console.WriteLine(number20);
    number20--;
} while (number20 >= 0);

//ForEach
string[] students3 = new string[3] { "Metin", "Koyuncu", "KK" };
foreach (var student in students)
{
    Console.WriteLine(student);
}