using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Add(double a, double b)
    {
        return a + b ;
    }
    static void Main(String[]args)
    {
        Console.WriteLine("Sum of Two integers:" + Add(3,5));
        Console.WriteLine("Sum of Three integers:" + Add(3,5,5));
        Console.WriteLine("Sum of Two double:" + Add(3.3,4.5));
    }
}