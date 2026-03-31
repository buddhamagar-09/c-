using System;


static class Demo
{
    public static String fname = "Buddha Saru Magar";
    public static String Positiotn = "CEO";

    public static void display_details()
    {
        Console.WriteLine("The details is Shown Below. ");
    }
    static void Main(String[] args)
    {
        Demo.display_details();
        Console.WriteLine("Name: " + Demo.fname);
        Console.WriteLine("Position: " + Demo.Positiotn);
    }
}