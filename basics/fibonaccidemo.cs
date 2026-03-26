// Create a program that prints the Fibonacci series up to n terms.
using System;
class Fibo
{
    static void Main(String[] args)
    {
        int n;
        Console.WriteLine("Enter the Nth tern: ");
        n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a + " ");
            int next = a + b;
            a = b;
            b = next;

        }
      Console.WriteLine();
    }
}