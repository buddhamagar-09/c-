// Write a program with a method that uses ref and out parameters.

using System;


// by reference
// class ref_out_demo
// {

//     public static void Pass(ref int a, ref int b)
//     {
//         a += 1;
//         b += 1;
//         Console.WriteLine(a);
//         Console.WriteLine(b);
//     }
//     static void Main(String[] args)
//     {
//         int x = 5;
//         int y = 10;
//         Pass(ref x, ref y);
//         Console.WriteLine(x);
//         Console.WriteLine(y);
//     }
// }


// out 

class Program
{
    public static void Demo(int a, int b, out int x, out int y)
    {
        x = a + 1;
        y = b + 1;
    }

    static void Main(String[] args)
    {
        int x , y;
        Demo(10, 10, out x, out y);
        Console.WriteLine(x);
        Console.WriteLine(y);
    }

}