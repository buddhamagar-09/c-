using System;
using System.Linq;
using System.Collections.Generic;


class Student
{
    public int id{get; set;}
    public String name{get;set;}
    public String address{get;set;}
    public int mark{get;set;}

    public Student(int id, string name,string address, int mark)
    {
        id = this.id;
        name = this.name;
        address = this.address;
        mark = this.mark;
        
    }
}
class Program
{
    static void Main()
    {
        List<Student> s = new List<Student>()
        {
            new Student(1,"Buddha","Gaindakot",88),
            new Student(2,"Pawan","Japan",56),
            new Student(3,"Kamal","Ktm",58),
            new Student(4,"Ronaldo","Nep",88)
        };

        var result1 = s.Where( x => x.mark > 60);
        var result2 = s.orderByDescending( x => x.mark);
        // highest mark
        var result3 = s.Max();
        Console.WriteLine(result3);

        var result4 = s.Average( s => s.mark);
        Console.WriteLine(result4);
        var result5 = s.Count();
        Console.WriteLine(result5);

        foreach(var res1 in result1)
        {
            Console.WriteLine(res);
        }

          foreach(var res2 in result2)
        {
            Console.WriteLine(res2);
        }

    }
}