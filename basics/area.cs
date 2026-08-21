using System;

class Demo
{
    static void Main()
    {
        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine($" Area of the circle = {area}");
    }
}