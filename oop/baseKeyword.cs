using System;

public class Animal
{
    public string color = "Black";
}

public class Dog : Animal
{
    String color = "White";
    public void show()
    {
        Console.WriteLine(base.color);
        Console.WriteLine(color);
    }

    public static void Main(String[]args)
    {
        Dog d = new Dog();
        d.show();
    }
}