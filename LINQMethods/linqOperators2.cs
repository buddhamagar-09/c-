
// var students = from s in studentList
//standard query operator 
// where s.age > 0
// select s

//eg. where condition (with object list)

using System;
using System.Collections.Generic;
using System.Linq;
class student
{
    public int sid { get; set; }
    public String name { get; set; }
    public String address { get; set; }

    public student(int sid, String name, String address)
    {
        this.sid = sid;
        this.name = name;
        this.address = address;
    }
}

class LingTest
{
    static void Main(String[] args)
    {
        List<student> mylist = new List<student>()
        {
            new student(1,"Buddha","pkr"),
            new student(2,"Pawan","KTM"),
            new student(3,"Sagar","chtwn"),
            new student(4,"Sushant","butwal"),
            new student(5,"sexy","butwal"),
            new student(6,"mesy","KTM"),
        };

        var result = mylist.GroupBy(s => s.address);
        Console.WriteLine("Displaying by Group:");

        foreach(var group in result)
        {
            Console.WriteLine("Department" + group.Key);

            foreach(var res in group)
            {
                Console.WriteLine($"Id:{res.sid} \n Name:{res.name} \n Address:{res.address}");
            }
        }      
    }
}