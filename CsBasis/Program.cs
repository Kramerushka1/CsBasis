using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("Enter your birthdate: ");

        string birthdate = Console.ReadLine();
        Console.WriteLine("Your birthdate is {0}", birthdate);
    }

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
    /*
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
    */

    //Task 3.4.3
    /*
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
    */

    //Task 3.6.8
    /*
    public static void Main(string[] args)
    {
        double result = 10 % 3;
        Console.WriteLine(result);
    }
    */

    //Task 3.7.4
    /*
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        
        Console.Write("What is your favorite day of week? ");
        DaysOfWeek day = (DaysOfWeek) byte.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0} ", day);

        Console.ReadKey();
    }

    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    */

    //var
    /*
    public static void Main(string[] args)
    {
        Console.Write("What is your Name? ");
        var name = Console.ReadLine();

        Console.Write("How old are you? ");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("What is your favorite day of week? ");

        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);
    }
    */
}
