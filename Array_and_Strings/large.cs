
// Write a program to find the largest and smallest element in a 2D array.
using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            { 10, 25, 3 },
            { 45, 7, 18 },
            { 2, 30, 50 }
        };

        int largest = arr[0, 0];
        int smallest = arr[0, 0];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > largest)
                {
                    largest = arr[i, j];
                }

                if (arr[i, j] < smallest)
                {
                    smallest = arr[i, j];
                }
            }
        }

        Console.WriteLine("Largest element = " + largest);
        Console.WriteLine("Smallest element = " + smallest);
    }
}