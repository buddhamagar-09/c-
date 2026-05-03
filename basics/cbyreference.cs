using System;

class Demo
{
    static void ChangeValue(ref int x)
    {
        x = 100;
        Console.WriteLine("Inside the method : " + x);
    }

    static void Main(String[] args)
    {
        int a = 5;
        Console.WriteLine("Initial value of a :" + a);
        ChangeValue(ref a);
        Console.WriteLine("After passing value: " + a);
    }
}