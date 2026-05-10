//WAP to show the binary operators overloading.

using System;

class Complex
{
    private int x;
    private int y;
    public Complex()
    {

        
    }

    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }

    public void show()
    {
        Console.WriteLine("{0},{1}", x, y);
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.x = c1.x + c2.x;
        temp.y = c1.y + c2.y;
        return temp;
    }
}

class MyClass
{
    public static void Main()
    {
        Complex c1 = new Complex(20, 30);
        c1.show();
        Complex c2 = new Complex(30, 20);
       Complex c3 = c1 + c2;
        c3.show();
    }
}