// 11. Write a program to search an element in an array.

using System;

class Program
{
    static void Main(String[] args)
    {
        Program p = new Program();
        p.Search_Element();
    }
    public void Search_Element()
    {
        int[] arr;
        Console.WriteLine("Enter the size of the Array: ");
        int n = int.Parse(Console.ReadLine());
        arr = new int[n];
        Console.WriteLine("Enter the Elements of the Array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the element to search: ");
        int element = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == element)
            {
                Console.WriteLine($"Element found at Position {i + 1}");
                return;
            }
        }
        Console.WriteLine("Element Not Found In Array.");
    }
}