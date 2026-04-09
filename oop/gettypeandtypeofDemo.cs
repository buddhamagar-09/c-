using System;

// Get type is evaluated at run time
// type of is evaluated at complie time

public class Program
{
    public int x , y ;
}

class Demo
{
    static void Main(String[]args)
    {
        Program p = new Program();
        Console.WriteLine(p.GetType().Name);
        Console.WriteLine(typeof(Program).Name);
        Console.WriteLine(p.x.GetType().Name);
        Console.WriteLine(p.y.GetType().FullName);

    }
}

// boxing and unboxing example

