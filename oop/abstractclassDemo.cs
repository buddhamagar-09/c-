using System;

abstract class mcn
{
    public int add(int a, int b)
    {
        return (a + b);
    }
}

class mcn1 : mcn
{
    public int mul(int a, int b)
    {
        return (a * b);
    }
}

class Program
{
    public static void Main(String[] args)
    {
        mcn1 m = new mcn1();
        int sum = m.add(10, 5);
        Console.WriteLine("The sum is = " + sum);
        int multiply = m.mul(5, 6);
        Console.WriteLine($"The Multiplication is {multiply}");

    }
}