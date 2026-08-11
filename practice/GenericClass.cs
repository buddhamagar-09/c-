using System;
using System.Collections.Generic;

public class Sum<T>
{
    public T value;

    public void Display()
    {
        Console.WriteLine(value);
    }


}

class Test
{
    static void Main(String[] Args)
    {
        Sum<int> s = new Sum<int>();
        Sum<string> s2 = new Sum<string>();

        s.value = 5;
        s2.value = "Hello";

        s.Display();
        s2.Display();
    }
}