using System;

class Program
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Enter two numbers: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}