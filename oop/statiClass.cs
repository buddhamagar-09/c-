using System;


static class MyCollege
{
    public static String collegename;
    public static String address;

    static MyCollege()
    {
        collegename = "Lumbini ICT Campus";
        address = "Giandakot";
    }
}
class Prorgam
{
    static void Main(String[] args)
    {
        Console.WriteLine(MyCollege.collegename + "\n" +MyCollege.address);
    }
}