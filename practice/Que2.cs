using System;

class Program
{
    public String name;
    public String address;

    public Program(string Name, String Address)
    {
        name = Name;
        address = Address;
    }

    public void display()
    {
        Console.WriteLine($"Name:{name} \n Address: {address}");
    }
}

class Child : Program
{
    public Child(string name, string address):base(name,address)
    {
        Console.WriteLine("Name and address passed to the parent Constructor.");
    }

    static void Main()
    {
        Child c = new Child("Buddha","Gaindakot");
        c.display();
    }
}