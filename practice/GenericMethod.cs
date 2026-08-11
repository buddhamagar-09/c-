using System;
using System.Collections.Generic;


class Demo
{
    public void display<t>(t value1, t value2)
    {
        Console.WriteLine(value1 + value2);
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.display<int>(5,5);
        d.display<string>("sex","xes");
    }
}
