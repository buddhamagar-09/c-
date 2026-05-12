// It is aproblem that arrives at the execution of the program and it is not possible to predict it, but we can handle it with try and catch block
//key words: try, catch, finally, throw
//system.applicationException class supports exception

using System;
class Test
{
    static void Main(String[] args)
    {
        try
        {
            int a = 10, b = 0, c;
            c = a / b;
            Console.WriteLine("Result: {0}", c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("This block will always execute.");
        }
    }
}