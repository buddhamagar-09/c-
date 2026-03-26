using System;

class Sum
{
    static void Main()
    {
        Console.WriteLine("Enter first numbers");
        String a = Console.ReadLine();
        int num1 = int.Parse(a);
        Console.WriteLine("Enter second Number ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        float division = num1 / num2;
        int multiply = num1 * num2;
        int difference = num1 - num2;
        Console.WriteLine("The sum of {0} and {1} is {2} ", num1, num2, sum);
        Console.WriteLine("The difference of {0} and {1} is {2} ", num1, num2, difference);
        Console.WriteLine("The division of {0} by {1} is {2} ", num1, num2, division);
        Console.WriteLine("The dmultiplication of {0} and {1} is {2} ", num1, num2, multiply);
    }
}
