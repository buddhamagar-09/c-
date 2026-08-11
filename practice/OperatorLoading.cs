using System;

class Number
{
    public int n;
    public Number(int num)
    {
        n = num;
    }

    public static Number operator -(Number n1, Number n2)
    {
        return new Number(n1.n - n2.n);
}
}
class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(10);
        Number n3 = n1 - n1;
        Console.WriteLine(n3.n);
    }
}