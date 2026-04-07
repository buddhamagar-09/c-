using System;

abstract class test1
{
    public int add(int i, int j)
    {
        return i + j;
    }
    public abstract int mul(int i, int j);
}

class test2 : test1
{
    public override int mul(int i, int j)
    {
        return i * j;
    }
}

class Program
{
    public static void Main(String[] args)
    {
        test2 t = new test2();
        int sum = t.add(10, 5);
        Console.WriteLine("The sum is = " + sum);
        int multiply = t.mul(5, 6);
        Console.WriteLine($"The Multiplication is {multiply}");

    }
}