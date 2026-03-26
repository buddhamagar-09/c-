using System;

namespace oopdemo
{
    public class Student
    {
        private int id;
        private String name;
        public void setData(int i, String n)
        {
            id = i;
            name = n;            
        }
        public void display_data()
        {
            Console.WriteLine("Studentid: "+id);
            Console.WriteLine("Name: "+name);
        }
    }

 class Program
    {
        static void Main(String []args)
        {
            Student s1 = new Student();
            s1.setData(1,"Buddha");
            s1.display_data();
            Console.ReadLine();
        }
    }
}