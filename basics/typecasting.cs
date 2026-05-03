using System;


class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Implicit TypeCasting from smaller to bigger.");
        int a = 100;
        float b = a;
        Console.WriteLine($"intger a = {a} and float a = {b}");
        float c = 19.22f;
        double d = c;
         Console.WriteLine($"float c = {c} and double c  = {d}");

        Console.WriteLine("Explicit type casting manually.");

        float x = 12.22f;
        int y = (int)x;
        Console.WriteLine($"float x = {x} and int x = {y}");

        double n = 12.22323123;
        float m = (float)n;
        Console.WriteLine($"double n = {n} and float n = {m}");
    }
}