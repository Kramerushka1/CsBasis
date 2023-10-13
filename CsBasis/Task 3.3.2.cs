using System;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{
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