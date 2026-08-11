

using System;

class Program
{
    public Program() : this(5,5)
    {
        Console.WriteLine("Default Constructor");
    }

    public Program(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }

    static void Main()
    {
        Program p = new Program();
    }
}