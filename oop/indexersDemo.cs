using System;

// String s = "Hello World";
// Console.WriteLine(s[0]);
// Console.WriteLine(s[1]);

// Syntax  
// <modifier> <return_type> this[<parameters>]  
// {  
//     get  
//     {  
//         // return the value of the specified index here  
//     }  
//     set  
//     {  
//         // set the value of the specified index here  
//     }  
// }

class Program
{
    class IndexClass
    {
        public String[] names = new String[5];
        public String this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    static void Main(String[] args)
    {
        IndexClass c = new IndexClass();
        c[0] = "Buddha";
        c[1] = "pandu";
        c[2] = "susu";
        c[3] = "sagu";
        c[4] = "neymu";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(c[i]);
        }
        Console.ReadKey();
    }
}