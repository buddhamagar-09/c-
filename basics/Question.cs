using System;

class Check
{
    static void printEven(int n)
    {
        int i;
        for(i = 1; i<=n; i++)
        {
            if(i%2 !=0)
            {
                continue;
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Even Number from 1 to hundred Printed Successfully.");
    }
    static void Main()
    {
        Check.printEven(100);
    }
}
