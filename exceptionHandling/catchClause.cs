using System;

//IT IS A BLOCK OF CODE WHICH HANDLES THE EXCEPTION
//IT IS DEFINED AS: catch(exceptionType e){ ......};
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number to divide 10:");
        try
        {
            int num = int.Parse(Console.ReadLine());
            int c = 10 / num;
            Console.WriteLine("Result: {0}", c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("This block will always execute.");
        }
    }
}