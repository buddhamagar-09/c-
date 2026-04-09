using System;
// It is a value type with a set of related name constants often referred to as an enumerator list. It is used to assign names to the integral constants which makes the code more readable and maintainable.


enum Days
{
    sunday, monday, tuesday, wednesday, thursday, friday, saturday
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("The value of Sunday in " + "enum is" + (int)Days.sunday);
        Console.WriteLine("The value of Monday in " + "enum is" + (int)Days.monday);
        Console.WriteLine("The value of Tuesday in " + "enum is" + (int)Days.tuesday);
        Console.WriteLine("The value of Wednesday in " + "enum is" + (int)Days.wednesday);
        Console.WriteLine("The value of Thursday in " + "enum is" + (int)Days.thursday);
        Console.WriteLine("The value of Friday in " + "enum is" + (int)Days.friday);
        Console.WriteLine("The value of Saturday in " + "enum is" + (int)Days.saturday);
    }
}