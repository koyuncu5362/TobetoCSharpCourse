// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





//---------------------------------------Prime Number-------------------------------
static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (global::System.Int32 i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            break;

        }
    }
    Console.WriteLine(result);
    return result;
}
IsPrimeNumber(17);
