// Generic Class
// Syntax : public class TestClass<T>{}
// each collection are found under System.Collections.Generic namespace
// Generic Classes
// Collection<T>
// List<T>
// Dictionary<TKey,TValue>
// Stack<T>
// Queue<T>

using System;
using System.Collections.Generic;

class TestClass<T>
{
    T[] t = new T[5];
    int c = 0;

    public void addItem(T item)
    {
        if (c < 5)
        {
            t[c] = item;
            c++;
        }
        else
        {
            Console.WriteLine("Overflow Exists");
        }
    }

    public void display()
    {
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine($"Item at index {i} = {t[i]}");
        }
    }
}

class Genericity
{
    static void Main()
    {
        TestClass<int> obj = new TestClass<int>();
        obj.addItem(10);
        obj.addItem(20);
        obj.addItem(30);
        obj.addItem(40);
        obj.addItem(50);
        obj.display();
        Console.ReadKey();
    }
}