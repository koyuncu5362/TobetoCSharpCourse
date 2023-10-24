// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//----------------------------Arrays------------------------
string[] students = new string[3] { "Metin", "Koyuncu", "KK" };
students[0] = "Metin";
students[2] = "koyuncu";
string[] students2 = { "Metin", "Koyuncu", "KK" };
Console.WriteLine(students);
Console.WriteLine(students2);

//multidimensional arrays
string[,] regions = new string[2, 1]
{{
"İstanbul"
},{"Rize"}
};
for (int i = 0; i < regions.GetUpperBound(0); i++)
{
    for (global::System.Int32 j = 0; j <= regions.GetLowerBound(0); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
}
