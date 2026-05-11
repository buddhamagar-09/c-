using System;

//IT IS A METHOD WHICH DOESNT CONTAIN ANY NAME
//IT IS DEFINED AS: delegate(parameter-(list)){ ......};


class Test
{
    public delegate void MyCat(String name);

    static void Main(String[] args)
    {
        MyCat c = delegate (String name)
        {
            Console.WriteLine("My Cat Name is: {0}", name);
        };
        c("Kaley");
    }
}