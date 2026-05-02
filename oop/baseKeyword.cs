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

// base keyword is used to access the members of the base class from the derived class. In the above example, we have a base class called Animal which has a member variable color. The derived class Dog also has a member variable color. To access the color variable of the base class, we use the base keyword.