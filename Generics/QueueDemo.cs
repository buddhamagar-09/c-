// Queue members
// enqueue()
// dequeue()
// peek()

using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        Queue<String> queue1 = new Queue<string>();
        queue1.Enqueue("MCA");
        queue1.Enqueue("BCA");
        queue1.Enqueue("CSIT");
        queue1.Enqueue("BIM");
        queue1.Enqueue("BCA");

        Console.WriteLine("Elements in queue are: ");
        foreach (String s in queue1)
        {
            Console.WriteLine(s);
        }

        queue1.Dequeue();
        queue1.Dequeue();
        Console.WriteLine("After dequeuing: ");
        foreach (String item in queue1)
        {
            Console.WriteLine(item);
        }
    }
}