using System;

class Test
{
    static int test1() => 6;

    static int test2(int x) => x + 10;

    static void Main()
    {
        int x = test1();
        int res = test2(x);
        Console.WriteLine("the result is: " + res);
    }
}