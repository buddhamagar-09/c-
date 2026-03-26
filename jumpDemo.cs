using System;
class JumpDemo
{
    static void Main()
    {
        int i;
        for(i = 0 ; i<= 10; i++)
        {
            if(i == 5)
            continue;
            Console.WriteLine(i);
        }
        Console.WriteLine("Loop Completed:");
    }
}