//23. Implement an interface IDrive with method Start() and implement it in a class Car.

using System;

interface IDrive
{
    public void Start();
}

class Car :IDrive
{
    public void Start()
    {
        Console.WriteLine("Car is starting....");
    }

    static void Main(String[] args)
    {
        Car c = new Car();
        c.Start();
    }
}