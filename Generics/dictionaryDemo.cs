// Dictionary

// Syntax: Dictionary <Tkey, Tvalue>

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, String> dobj = new Dictionary<int, string>(5);
        dobj.Add(1, "Sabin");
        dobj.Add(2, "Sabin");
        dobj.Add(3, "Sabin");
        dobj.Add(4, "Sabin");
        dobj.Add(5, "Sabin");

        for (int i = 1; i <= dobj.Count; i++)
        {
            Console.WriteLine($"Key: {i}  \nValue: {dobj[i]}");
        }
        Console.ReadKey();
    }
}