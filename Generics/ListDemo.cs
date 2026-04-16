//list members
// add()
//remove()
//insert(index,value)



using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        List<int> l = new List<int>();
        l.Add(34);
        l.Add(45);
        l.Add(343);
        l.Add(76);
        l.Add(22);
        l.Add(12);
        l.Add(89);

        Console.WriteLine("Elements in List are: ");
        foreach (int i in l)
        {
            Console.WriteLine(i);
        }

        l.Remove(76);
        l.Remove(89);

        Console.WriteLine("After Removing: ");
        foreach (int item in l)
        {
            Console.WriteLine(item);
        }

        l.Insert(2,11);
        Console.WriteLine("After Sorting: ");
        l.Sort();
         foreach (int i in l)
        {
            Console.WriteLine(i);
        }
        
    }
}