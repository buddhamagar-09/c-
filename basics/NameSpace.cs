
namespace outer
{
    class Program1
    {
        public void show()
        {
            Console.WriteLine("i love Watching Anime.");
        }
    }

    namespace inner
    {
        class Program2
        {
            public void display()
            {
                Program1 p1 = new Program1();
                p1.show();
            }
            static void Main()
            {
                    Program2 p2= new Program2();
                    p2.display();
            }
        }
    }
}

// namespace = a container that holds a set of identifiers and allows the organization of code into a hierarchical structure. 
// It helps to avoid naming conflicts by providing a way to group related classes, interfaces, and other types together. 
// In C#, namespaces are defined using the "namespace" keyword followed by the name of the namespace. They can be nested within each other to create a hierarchy of namespaces.