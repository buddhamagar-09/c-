using System;

class Program{
    static void Main()
    {
        int []a ={10,20,30,40,50};
        foreach(int val in a)
        {
            Console.WriteLine(val+10);
        }
        Console.ReadKey();
        // readkey is used to stop the console from closing immediately after executing the program. It waits for the user to press a key before closing the console window.
    }
}