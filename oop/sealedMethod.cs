using System;

class Base
{
    public virtual void test()
    {
        Console.WriteLine("Test 1");
    }
}
class subclass : Base
{
    public sealed override void test()
    {
        base.test();
        Console.WriteLine("Test 2");
    }
}

class Program
{
    public static void Main(String[]args)
    {
        subclass s = new subclass();
        s.test();
    }
}