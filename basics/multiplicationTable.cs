// Write a program to generate a multiplication table for a given number.

using System;

class Multi
{
    static void Main(String[] args)
    {
        int number;
        Console.WriteLine("Enter the Number: ");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine("******Multiplication table of " + number + "******");

        for (int i = 1; i <= 10; i++)
        {
            int mul = number * i;
            Console.WriteLine($"{number} * {i} = {mul}");
        }
        Console.WriteLine();
    }
}