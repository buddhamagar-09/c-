// Accept a string and check if it is a palindrome or not.
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
        if (revStr == str)
        {
            Console.WriteLine($"The String {str} is Palindrome.");
        }
        else
        {
            Console.WriteLine($"The String {str} NOT is Palindrome.");
        }
    }
}