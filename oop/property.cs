using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private int x;
    public void setx(int i)
    {
        x = i;
    }
    public int GetX()
    {
        return x;
    }
    static void Main(String[] args)
    {
        Program p = new Program();
        p.setx(5);
        int val = p.GetX();
        Console.WriteLine($"Value: {val}");
    }
}