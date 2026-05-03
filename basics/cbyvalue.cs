using System;


class Demo
{
    public void changeValue(int x)
    {
        x = 100;
        Console.WriteLine("The value of x is: "+ x);
    }
    static void Main(String[] args)
    {
        Demo d = new Demo();
        int a = 10;
        Console.WriteLine("Before value pass: "+ a);
        d.changeValue(a);
        Console.WriteLine("After value passing still nochange to original value of a: "+ a);
    }
}