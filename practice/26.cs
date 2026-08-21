using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> students = new Dictionary<string, string>();

        students.Add("Ram", "ram@gmail.com");
        students.Add("Sita", "sita@gmail.com");
        students.Add("Hari", "hari@gmail.com");

        foreach (var student in students)
        {
            Console.WriteLine(student.Key + " - " + student.Value);
        }
    }
}