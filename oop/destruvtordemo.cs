using System;

class ConDes
{
    public ConDes(String message)
    {
        Console.WriteLine(message);
    }
    ~ConDes()
    {
        Console.WriteLine("This is a destructor:");
    }

}

class Program
{
    static void Main(String[] args)
    {
        {
            ConDes cd = new ConDes("This is a constructor.");
        }
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}