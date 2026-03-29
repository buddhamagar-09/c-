using System;

class Employee
{
    public String Name;
    public int Age;
    public int Salary;
    public Employee()
    {
        Name = "Unknown";
        Age = 0;
        Salary = 0;
    }
    // constructor with two parameters
    public Employee(String name, int age)
    {
        Name = name;
        Age = age;
        Salary = 0;
    }
    // Constructor with three paramers
    public Employee(String name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void display()
    {
        Console.WriteLine($"name: {Name} \n Age: {Age} \n Salary: {Salary}");
    }
}


class Program
{
    static void Main(String[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee("Buddha", 21);
        Employee e3 = new Employee("Santos", 23, 100000);

        e1.display();
        e2.display();
        e3.display();

    }
}