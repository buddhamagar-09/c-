// Accept a string and reverse it without using built-in methods.

using System;


class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a dummy String: ");
        String str = Console.ReadLine();

        String revStr = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            revStr += str[i];
        }
        Console.WriteLine($"The Reversed String is: {revStr}");
    }
}