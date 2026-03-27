// Write a program to reverse a given number.

using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int reversedNum = ReverseNumber(num);
        Console.WriteLine($"The reversed number is: {reversedNum}");
    }

    static int ReverseNumber(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            int a = number % 10;
            reversed = reversed * 10 + a;
            number = number / 10;
        }
        return reversed;
    }

}