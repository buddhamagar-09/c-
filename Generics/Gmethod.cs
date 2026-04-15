using System.Collections.Generic;

class Program
{
    //Generic Method
    static void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }
    static void Main()
    {
        int a = 70, b = 60;
        Console.WriteLine("Before Swapping...\n {0},{1}", a, b);
        Swap<int>(ref a, ref b);
        Console.WriteLine("After Swapping \n {0},{1}", a, b);
        Console.ReadLine();
    }
}