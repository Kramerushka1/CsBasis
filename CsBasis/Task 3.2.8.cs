using System;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{
    static void Main(string[] args)
    {


        const string MyName = "Jane";

        Console.WriteLine(MyName);

        Console.WriteLine("\t������, ���");
        Console.WriteLine("\t��� 27 ���");
        Console.WriteLine($"\tMy name is\n {MyName}");
        Console.WriteLine();

        Console.WriteLine("\u0040");
        Console.WriteLine("\u0023");
        Console.WriteLine();

        Console.ReadKey();
    }
}