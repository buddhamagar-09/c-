using System;
class Miscoperator
{
    static void Main()
    {
        //list of operators
        Console.WriteLine("Size of int: "+sizeof(int));
        Console.WriteLine("Size of double: "+sizeof(double));

        // type of operators
        Type t = typeof(string);
        Console.WriteLine("Type of String: "+t);

        // is operator
        object num = 50;
        if(num is int)
        {
            Console.WriteLine("Num is an integer");
        }

        // conditional Operator
        int a = 10;
        int b = 50;
        int max = (a > b)? a:b;
        Console.WriteLine("Maximum value is: "+max);
    }
}