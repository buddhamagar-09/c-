using System;

class Program
{
    public int a {get;set;}
    public int b {get;set;}

    public int Sum
    {
        get { return a + b; }
    }
    static void Main(String[]args)
    {
        Program p = new Program();
        p.a = 5;
        p.b = 6;
        Console.WriteLine($"The sum of {p.a} and {p.b} is {p.Sum}");
        Console.ReadKey();
    }
}