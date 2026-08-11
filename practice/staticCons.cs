
//static constructor is used to initialize static data members of a class. It is called automatically before the first instance is created or any static members are referenced.
using System;


// class Program
// {
//     public static int count;

//     static Program()
//     {
//         count = 100;
//     }

//     public Program()
//     {
//         count++;
//     }


//     static void Main(String[]args)
//     {
//         Program p1 = new Program();
//         Program p2 = new Program();
//         Program p3 = new Program();

//         Console.WriteLine($"Count : {count}");
//     }
// }


class Program
{
    static Program()
    {
        Console.WriteLine("Static constructor");
    }

    static void Main()
    {
        // Program p =new Program();
    }
}