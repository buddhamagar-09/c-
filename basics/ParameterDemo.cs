using System;

// pass by reference
// class Program
// {
//     static void Food(ref int p)
//     {
//         p += 1;
//         Console.WriteLine(p);
//     }
//     static void Main()
//     {
//         int x = 8;
//         Food(ref x);
//         Console.WriteLine(x);
//     }
// }


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

class Test
{
    static int Sum(params int[] s)
    {
        int sum = 0;
        for(int i = 0; i<s.Length; i++)
        {
            sum += s[i];
        }
        return sum;
    }
    static void Main()
    {
        int total = Sum(1,2,3,4,5);
        Console.WriteLine(total);
    }
}