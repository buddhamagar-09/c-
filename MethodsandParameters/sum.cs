// 15. Create a method that returns the sum of two numbers.
using System;

class SumDemo
{
    int a, b;
    public static int FindSum(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    static void Main(String[] args)
    {
        Console.WriteLine(FindSum(2, 5));
    }
}