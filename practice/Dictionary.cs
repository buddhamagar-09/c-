using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Dictionary<int,String> d = new Dictionary<int, string>();
        d.Add(1,"Buddha");
        d.Add(2,"Pandu");

        Console.WriteLine("Display Details.");
        for(int i = 1; i <= d.Count; i++)
        {
            Console.WriteLine($"Index:{i} \n value:{d[i]}");
        }
    }
}