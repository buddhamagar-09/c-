
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
        };

        var result = mylist.Where(s => s.address.Equals("pkr")).OrderBy(s => s.address);
        Console.WriteLine("Name\tAddress");
        foreach (var res in result)
        {
            Console.WriteLine(res.name + "\t" + res.address);
        }
        Console.ReadLine();
    }
}