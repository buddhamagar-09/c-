// Use a switch statement to perform a simple calculator (add, sub, mul, div).

using System;

class calculator
{
    static void Main(String[] args)
    {
        Console.WriteLine("*****Calculator*****");
        Console.WriteLine("You have 4 Options \n 1.ADD \n 2.SUB \n 3.Multiply \n 4.Division");
        Console.WriteLine("Enter First Number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("*****Options***** \n1 for addition \n2 for Subtraction \n3 for Multiplication \n4 for Division");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
                break;

            case 2:
                int sub = num1 - num2;
                Console.WriteLine($"The Difference of {num1} and {num2} is {sub}");
                break;

            case 3:
                int Multiply = num1 * num2;
                Console.WriteLine($"The Multiplication of {num1} and {num2} is {Multiply}");
                break;

            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Divisor cannot be Zero.");
                    return;
                }
                double div = num1 / num2;
                Console.WriteLine($"The division of {num1} and {num2} is {div}");
                break;

            default:
                Console.WriteLine("Invalid Option: ");
                break;
        }
    }
}