// Create a program that sorts an array in ascending order.

using System;

class Program
{
    static void Main(String[] args)
    {
        Program p = new Program();
        p.Ascending_Demo();
    }
    public void Ascending_Demo()
    {
        int[] arr;
        int temp;
        Console.WriteLine("Enter the Size of the array: ");
        int n = int.Parse(Console.ReadLine());
        arr = new int[n];

        Console.WriteLine("Enter the elements of the Array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted Array: \n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine();
    }
}