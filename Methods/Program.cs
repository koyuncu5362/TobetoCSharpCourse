// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//-----------------Methods-------------

static void Add()
{
Console.WriteLine("Added");
}
Add();
Console.ReadLine();

//Parameters
static void Add2(int number1, int number2)
{
var result = number1 + number2;
Console.WriteLine(result);
Console.ReadLine();
}
Add2(20, 30);

//Default Parameter
static void Add3(int number1, int number2 = 20)
{
var result = number1 + number2;
Console.WriteLine(result);
Console.ReadLine();
}
Add3(20, 30);

//Ref Keyword
int number15 = 100;
int number25 = 200;

var result10 = Add4(ref number15, number25);
static int Add4(ref int number15, int number25 = 20)
{
number15 = 30;
Console.WriteLine(number15 + number25);
Console.ReadLine();
return number15 + number25;
}


//Out Keyword
int number16 = 100;
int number26 = 200;

var result55 = Add5(out number16, number26);
static int Add5(out int number16, int number26 = 20)
{
number16 = 30;
var result = number16 + number26;
Console.WriteLine(result);
Console.ReadLine();
return result;
}


//Method Overloading
class Overloading
{
    static int Multiply(int number111, int number222)
    {
        return number111 * number222;
    }
    static int Multiply(int number111, int number222, int number3)
    {
        return number111 * number222 * number3;
    }
}


//Params Keyword
class Params
{
    public static int Add6(params int[] numbers)
    {
        return numbers.Sum();
    }

}
