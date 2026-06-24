
using System;

class College
{
    public static String name;
    public static String address;
    static College()
    {
        name = "Lumbini ICT Campus";
        address = " Gaindakot - 4";
        Console.WriteLine("Static Constructor executed."); 
    }

    void display()
    {
        Console.WriteLine($"{name}:{address}");
    }

    static void Main()
    {
        College c = new College();
        College c1 = new College();
        c.display();
        c1.display();
    }
}


//static constructor is called only once when the class is loaded into memory.
//  It is used to initialize static members of the class.
//  It cannot be called directly and does not take any parameters.