using System;

class Vote
{
    static void Main()
    {
        int age;
        Console.WriteLine("Enter the Age: ");
        age = int.Parse(Console.ReadLine());

        if(age < 18)
        {
            throw new ArithmeticException("Not eligible to Vote: ");
        }
        else
        {
            Console.WriteLine("You are Eligible to Vote.");
        }
    }
}