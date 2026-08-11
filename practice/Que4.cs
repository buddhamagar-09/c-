using System;
using System.Runtime.CompilerServices;

class Program
{

    public String Name{set; get;}
  
    public String Address { get; set; }

    static void Main()
    {
        Program P = new Program();
        
            P.Name = "Buddha";
            P.Address = "Gaindakot";
        
        Console.WriteLine($"Name : {P.Name} \nAddress : {P.Address}");

    }
}