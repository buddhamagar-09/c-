using System;

class Program
{
    private int Num1{get;}
    private int Num2{get;}

    public Program(int a, int b)
    {
        Num1 =a;
        Num2 = b;
    }

    public static Program operator +(Program P1, Program p2)
    {
        return new Program(P1.Num1 + p2.Num1, P1.Num2 + p2.Num2);
    }

    // public static Program operator -(Program p1, Program p2)
    // {
    //     return new Program(p1.Num1 - p2.Num1, p1.Num2 - p2.Num2);
    // }

    static void Main()
    {
        Program p1 = new Program(20,30);
        Program p2 = new Program(30,20);
        Program p3 = p1 + p2;
        // Program p4 = p1 - p2;
        Console.WriteLine($"{p3.Num1} and {p3.Num2}");
        // Console.WriteLine($"{p4.Num1} and {p4.Num2}");
        // Console.WriteLine(p4);
    }
}