//Create an abstract class Shape with a method Area(), and inherit it in Circle and
//Rectangle.

using System;

abstract class Shape
{
    public abstract int Area();
}

class Rectangle : Shape
{
    int length, breadth;
    
    public Rectangle(int l, int b)
    {
        length = l;
        breadth = b;
    }
    
    public override int Area()
    {
        return length * breadth;
    }
}

class Circle : Shape
{
    double radius;
    
    public Circle(double r)
    {
        radius = r;
    }
    
    public override int Area()
    {
        return (int)(Math.PI * radius * radius);
    }
}

class Demo
{
    static void Main()
    {
        Rectangle rec = new Rectangle(5, 10);
        Console.WriteLine($"The area of Rectangle is: {rec.Area()}");
        Circle c = new Circle(5);
        Console.WriteLine($"The area of CIRCLE is: {c.Area()}");
    }
}