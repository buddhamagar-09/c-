using System;

class oddevendemo
{
    int n;
    public void number_Check(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine($"the number {n} is EVEN.");
        }
        else
        {
            Console.WriteLine($"the number {n} is ODD.");
        }
    }
    static void Main(String[] args)
    {
        oddevendemo oe = new oddevendemo();
        oe.number_Check(4);
    }
}