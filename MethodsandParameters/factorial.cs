// Create a method to calculate the factorial of a given number using recursion.

using System;

class Factorial
{
    int number;
    public static int Find_Fact(int number)
    {
        if (number == 0 || number == 1)
        {
            return 1;
        }
        else
        {
            return number * Find_Fact(number - 1);
        }

    }
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"The factorial of {num} is {Find_Fact(num)}");
    }
}