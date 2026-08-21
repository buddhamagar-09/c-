using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Stack - LIFO
        Stack<string> stack = new Stack<string>();

        stack.Push("Ram");
        stack.Push("Sita");
        stack.Push("Hari");

        Console.WriteLine("Stack:");
        Console.WriteLine(stack.Pop());   // Removes Hari
        Console.WriteLine(stack.Peek());  // Shows Sita

        // Queue - FIFO
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Ram");
        queue.Enqueue("Sita");
        queue.Enqueue("Hari");

        Console.WriteLine("\nQueue:");
        Console.WriteLine(queue.Dequeue()); // Removes Ram
        Console.WriteLine(queue.Peek());    // Shows Sita
    }
}