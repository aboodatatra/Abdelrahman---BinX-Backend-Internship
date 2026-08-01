using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your GPA: ");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===== Student Information =====");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("GPA: " + gpa);
    }
}