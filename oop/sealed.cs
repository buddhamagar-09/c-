using System;


sealed class Parent
{
    public void message()
    {
        Console.WriteLine("This is a Parent Method.");
    }
}

// class Program
// {
//     public static void Main(String[] args)
//     {
//         Parent p = new Parent();
//         p.message();
//     }
// }

class Child : Parent
{
    public void show()
    {
        Console.WriteLine("This is a child.");
    }
    public static void Main(String[] args)
    {
        Child c = new Child();
        c.show();
        c.message();
    }
}