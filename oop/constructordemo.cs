using System;

class Demo
{
    public readonly int number;
    public Demo(int id)
    {
        number = id;
    }
    public void show()
    {
        number = 200;
        Console.WriteLine(number);
    }
    static void Main(String [] args)
    {
        Demo d = new Demo(101);
        d.show();
    }
}