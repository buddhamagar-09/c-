using System;


class Parent
{
    public virtual void message()
    {
        Console.WriteLine("This is Parent class");
    }
}

class Child : Parent
{
    public override void message()
    {
        Console.WriteLine("This is child class");
    }
}
class Program
{
    public static void Main(String[] args)
    {
        Child c = new Child();
        c.message();
    }
}