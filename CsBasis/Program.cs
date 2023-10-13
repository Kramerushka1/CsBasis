using System;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{
    //Task 3.2.4
    /*
    static void Main(string[] args)
    {
        string MyName;
        MyName = "Vik";
        Console.WriteLine(MyName);
        Console.ReadKey();
    }
    */

    //Task 3.2.8
    /*
    static void Main(string[] args)
    {
        const string MyName = "Jane";

        Console.WriteLine(MyName);

        Console.WriteLine("\tПривет, мир");
        Console.WriteLine("\tМне 27 лет");
        Console.WriteLine($"\tMy name is\n {MyName}");
        Console.WriteLine();

        Console.WriteLine("\u0040");
        Console.WriteLine("\u0023");
        Console.WriteLine();

        Console.ReadKey();
    }
    */

    //Task 3.3.2
    static void Main(string[] args)
    {
        string name = "Vik";
        byte age = 28;
        bool havePet = true;
        float shoeSize = 44.5f;

        Console.WriteLine($"My name is {name}");
        Console.WriteLine($"MyAge {age}");
        Console.WriteLine($"Do I have a pet? {havePet}");
        Console.WriteLine($"My shoe size is {shoeSize}");

        Console.ReadKey();
    }
}