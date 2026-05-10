//Implement a multilevel inheritance example using own examples.
using System;
class Vehicle
{
    public void show()
    {
        Console.WriteLine("This is a vehicle");
    }
}

class Car : Vehicle
{
    public void show()
    {
        Console.WriteLine("This is a car");
    }
}

class SportsCar : Car
{
    public void show()
    {
        Console.WriteLine("This is a sports car");
    }
}

class Program
{
    static void Main(String[] args)
    {
        SportsCar sc = new SportsCar();
        sc.show(); // This will call the show method of SportsCar class
        Car c = new Car();
        c.show(); // This will call the show method of Car class
        Vehicle v = new Vehicle();
        v.show(); // This will call the show method of Vehicle class
    }
}