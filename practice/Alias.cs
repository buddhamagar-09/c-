using System;
using app = Application;
namespace Application
{
    class Program
    {
        public void display()
        {
            Console.WriteLine("Alias using for namespace.");
        }
    }
}

class Program2
{
    static void Main()
    {
        app.Program p = new app.Program();
        p.display();
    }
    
}