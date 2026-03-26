using System;

class GotoDemo
{
    static void Main()
    {
        int i = 1;
        startloop:
        if(i<=10)
        {
            Console.WriteLine(i);
            i++;
            goto startloop;
        }
        Console.WriteLine("Out of Goto.");
    }
}