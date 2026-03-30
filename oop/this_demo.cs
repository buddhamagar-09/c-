using System;

class Student
{
    public int id, age;
    public String name, subject;

    public Student(int id, String name, int age, String subject)
    {
        this.id = id;
        this.age = age;
        this.name = name;
        this.subject = subject;
    }
    public void ShowInfo()
    {
        Console.WriteLine(id + " " + name + " " + age + " " + subject);
    }
}

class StudentDetails
{
    public static void Main(String[] args)
    {
        Student std1 = new Student(001, "Buddha", 21, "Dotnet Net");
        std1.ShowInfo();
    }
}