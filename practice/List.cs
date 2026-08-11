using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> l = new List<int>(5);
        l.Add(6);
        l.Add(2);
        l.Add(3);
        l.Add(4);
        l.Add(5);
        Console.WriteLine("Before removing the data");
        foreach (int data in l)
        {
            Console.WriteLine(data);
        }

        l.Remove(4);
        l.Sort();
        Console.WriteLine("After removing one data");
        foreach (int data in l)
        {
            Console.WriteLine(data);
        }
        Console.ReadKey();
    }
}