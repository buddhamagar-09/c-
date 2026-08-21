using System;
using System.Numerics;

// pass by reference
class Program
{
    static void Food(ref int p)
    {
        p  = 100;
        Console.WriteLine(p);
    }
    static void Main()
    {
        int x = 8;
        Food(ref x);
        Console.WriteLine(x);
    }
}


// out modifier
// class OutParam
// {
//     static void Pass(int a, int b, out int x, out int y)
//     {
//         x = a;
//         y = b;
//     }
//     static void Main()
//     {
//         int x, y;
//         Pass(10, 20, out x, out y);
//         Console.WriteLine(x);
//         Console.WriteLine(y);
//     }
// }

// params modifier = allows you to pass many arguments in a single varibale


// class Program
// {

//     public void Sum(params int [] numbers)
//     {
//         int total = 0;

//         foreach(int n in numbers)
//         {
//             total += n;
//         }
//         Console.WriteLine($"The sum of numbers is {total}");
//     }
//     static void Main()
//     {
//       Program p = new Program();
//       p.Sum(1,2,3,4,5,6,7,8,9);
//     }
// }