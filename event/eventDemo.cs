using System;

public delegate void DelEventHandler();

class Program
{
    public static event DelEventHandler add;

    static void Australia()
    {
        Console.WriteLine("Australia");
    }
    static void Nepal()
    {
        Console.WriteLine("Nepal");
    }
    static void Japan()
    {
        Console.WriteLine("Japan");
    }

    static void Main(String[] args)
    {
        add += Australia;
        add += Nepal;
        add += Japan;

        add.Invoke();
    }
}