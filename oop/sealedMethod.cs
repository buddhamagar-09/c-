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

// sealed keyword is used to prevent a class from being inherited or a method from being overridden. In the above example, we have a base class called Base which has a virtual method test(). The derived class subclass overrides the test() method and marks it as sealed. This means that no further derived class can override the test() method.