

abstract class Vehicle
{
    public abstract void start();
    public abstract void stop();
}

class Bike : Vehicle
{
    public override void start()
    {
        Console.WriteLine("1 2 3 start..");
    }
    public override void stop()
    {
        Console.WriteLine("Stopping Bike");
    }
}

class Car : Vehicle
{
    public override void start()
    {
        Console.WriteLine("broom broom broom");
    }

    public override void stop()
    {
        Console.WriteLine("Stopping Car");
    }
}


class demo
{
    static void Main()
    {
        Bike b = new Bike();
        b.start();
        b.stop();

        Car c = new Car();
        c.start();
        c.stop();
    }
}