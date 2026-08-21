using System;

class Program
{
    static void Main()
    {
        string str;
        int count = 0;
        Console.WriteLine("Enter a string: ");
        str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            {
                count++;
            }
        }
        Console.WriteLine($"Number of vowels in the string: {count}");
    }
}