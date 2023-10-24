// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//-----------------Conditionals-------------

//If
var number8 = 10;
if (number8 == 50)
{
    Console.WriteLine("number8 is not {0}", number8);

}
else
{
    Console.WriteLine("number8 is {0}", number8);
}
Console.ReadLine();

//Line If
Console.WriteLine(number8 == 10 ? "Number is 10" : "Number is not 10");


// Else IF
number8 = 10;
if (number8 == 50)
{
    Console.WriteLine("number8 is not {0}", number8);

}
else if (number8 == 90)
{
    Console.WriteLine("number8 is {0}", number8);
}
else
{
    Console.WriteLine("number8 is {0}", number8);
}
Console.ReadLine();

//Switch Case
var number9 = 20;
switch (number9)
{
    case 50:
        Console.WriteLine("Is Not {0}", number9);
        break;
    case 20:
        Console.WriteLine("Is  {0}", number9);
        break;
    default:
        break;
}

//Multiple If
number9 = 2;
if (number9 >= 0 && number9 <= 100)
{
    Console.WriteLine("Number is between 0-100");
    Console.ReadLine();
}
else if (number9 > 200 || number9 < 0)
{
    Console.WriteLine("number is less than  0 or greater than 200");
    Console.ReadLine();
}

//Integrate If
if (number9 >= 0 && number9 <= 100)
{
    if (number9 == 0 && number9 == 100)
    {
        Console.WriteLine("Number is equal 0-100");
        Console.ReadLine();
    }
}
