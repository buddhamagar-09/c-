
namespace outer
{
    class Program1
    {
        public void show()
        {
            Console.WriteLine("Inside Program 1");
        }
    }
    namespace inner
    {
        class Program2
        {
            public void display()
            {
                Program1 p = new Program1();
                p.show();
            } 
            static void Main()
            {
                Program2 p2 = new Program2();
                p2.display();
            }
        }
    }
}