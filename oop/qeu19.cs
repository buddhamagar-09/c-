//19. Create a class Student with fields Name, RollNo, and Marks. Write methods to accept
// and display data.

using System;


class Student
{
    string std_name;
    int std_roll;
    int std_marks;

    public void info(string name, int roll, int marks)
    {
        std_name = name;
        std_roll = roll;
        std_marks = marks;

    }

    public void display()
    {
        Console.WriteLine($"{std_name} \n {std_roll}\n {std_marks}");
    }

    static void Main()
    {
        Student student = new Student();
        student.info("Buddha", 22, 500);
        student.display();
    }
}