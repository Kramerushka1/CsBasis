using System;

class MainClass
{
    static void Main(string[] args)
    {
        const string MyName = "Jane";

        Console.WriteLine(MyName);

        Console.WriteLine("\tПривет, мир");
        Console.WriteLine("\tМне 27 лет");
        Console.WriteLine($"\tMy name is\n {MyName}");

        Console.WriteLine("\u0040");
        Console.WriteLine("\u0023");

        Console.ReadKey();
    }
}