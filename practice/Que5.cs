using System;


class Program<T>
{
    T [] t = new T [5];
    int c = 0;
    public void Sum(T item)
    {
       if (c < 5)
        {
            t[c] = item;
            c++;
            
        }     
    }

    public void show()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{t[i]}");
        }
    }

    static void Main(String []args)
    {
        Program<int> p = new Program<int>();
        p.Sum(50);
        p.Sum(50);
        p.Sum(50);
        p.show();
    
    }
}
