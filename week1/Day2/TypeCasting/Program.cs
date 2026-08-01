using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicit Casting
        int number = 100;
        double bigNumber = number;

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine(bigNumber);

        Console.WriteLine();

        // Explicit Casting
        double pi = 3.14;
        int integerPi = (int)pi;

        Console.WriteLine("Explicit Casting:");
        Console.WriteLine(integerPi);

        Console.WriteLine();

        // String Conversion
        string ageText = "20";
        int age = Convert.ToInt32(ageText);

        Console.WriteLine("String to Integer:");
        Console.WriteLine(age);
    }
}