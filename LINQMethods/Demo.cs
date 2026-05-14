using System;
using System.Collections.Generic;
using System.Linq;

class dog
{
    public String name { get; set; }
    public int age { get; set; }
}
class Demo
{
    static void Main()
    {
        List<dog> dogs = new List<dog>()
        {
            new dog{name="Rex",age=4},
            new dog{name="Ram",age=45},
            new dog{name="shyam",age=7}

        };
        var sortdogs = dogs.OrderByDescending(x => x.age);
        foreach (var dog in sortdogs)
        {
            Console.WriteLine("Dog {0} is {1} years old.", dog.name, dog.age);
        }
    }
}
