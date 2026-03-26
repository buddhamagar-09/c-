using System;

class Pro
{
    static void Main()
    {
        int i, j;
        for (i = 1; i < 5; i++)
        {
            for (j = i; j < 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}