using System;
class Test
{
    static void Counter(int x = 5)
    {
        Console.Write("Counter\n");
        for(int i = 0 ;i <= x; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Main()
    {
        Counter();
    }
}
