using System;

// wap for the demonstration of switch case

class Program
{
    static void Run()
    {
        is_running = true;
        while (is_running == true)
        {
            char grade;
            Console.WriteLine("Enter your grade (A/B/C/D/E)");
            grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Need Improvement");
                    break;
                case 'E':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade.");
                    break;
            }
            Console.WriteLine("Do you want to check again ? (Y/N)");
            char check = Convert.ToChar(Console.ReadLine().ToUpper());
            if (check != 'Y')
            {
                is_running = false;
                Console.WriteLine("Thank You for your time.");
                exit();
            }
        }

    }
    static void Main()
    {
        
    }
}