using System;

class User
{
    static User()
    {
        Console.WriteLine("This is a static Constructor.");
    }
    public User()
    {
        Console.WriteLine("I am a default Constructor.");
    }
}
class Program
{
    static void Main(String[]args)
    {
        User u1 = new User();
        User u2 = new User();
        Console.WriteLine("Press Enter to Exit.");
        Console.ReadLine();

    }
}