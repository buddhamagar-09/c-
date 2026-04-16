// Stack members
// pop()
// push()
//clear()
//contains()

using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        Stack<String> stack1 = new Stack<string>();
        stack1.Push("BCA");
        stack1.Push("MCA");
        stack1.Push("CSIT");
        stack1.Push("BBA");
        stack1.Push("BIM");

        Console.WriteLine("Elements in Stack are: ");
        foreach (String s in stack1)
        {
            Console.WriteLine(s);
        }

        stack1.Pop();
        stack1.Pop();
        Console.WriteLine("After popping: ");
        foreach (String item in stack1)
        {
            Console.WriteLine(item);
        }
    }
}