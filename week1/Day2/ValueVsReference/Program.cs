using System;

class Program
{
    static void Main(string[] args)
    {
        // Value Type
        int x = 10;
        int y = x;

        y = 20;

        Console.WriteLine("Value Types:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        Console.WriteLine();

        // Reference Type
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;

        arr2[0] = 100;

        Console.WriteLine("Reference Types:");
        Console.WriteLine("arr1[0] = " + arr1[0]);
        Console.WriteLine("arr2[0] = " + arr2[0]);
    }
}