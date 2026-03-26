class PrimeCheck
{

    static void Check(int num)
    {
        int counter = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                counter++;
            }
        }

      if(counter == 2)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }

    static void Main()
    {
        PrimeCheck.Check(5);
    }
}