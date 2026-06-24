using System;

class Number
{
    private int n1;
    private int n2;

    public Number()
    {

    }
    public Number(int i, int j)
    {
        n1 = i;
        n2 = j;
    }

    public void show()
    {
        Console.WriteLine($"{n1},{n2}");
    }

    public static Number operator -(Number num1, Number num2)
    {
        Number temp = new Number();
        temp.n1 = num1.n1 - num2.n1;
        temp.n2 = num1.n2 - num2.n2;
        return temp;
    }

    static void Main()
    {
        Number num1 = new Number(100,89);
        num1.show();
        Number num2 = new Number(60, 50);
        num2.show();
        Number num3 = num1 - num2;
        num3.show();

    }
}