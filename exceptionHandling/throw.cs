using System;

class Test
{
    public static void Check(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Not Eligible To Vote.");
        }
    }
    static void Main(String[] args)
    {
        try
        {
            Check(10);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class Program
{
    static void Main(String[] args)
    {
        int a = 20;
        int b = 0;
        int res;
        try
        {
            res = a / b;
        }
        catch (ArithmeticException ae)
        {
            Console.WriteLine(ae);
            throw;
        }
    }
}