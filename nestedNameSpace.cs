
namespace first
{
    class demo1
    {
        public void show()
        {
            Console.WriteLine("Inside demo1");
        }
    }
}

namespace second
{
    using first;

    class Demo2
    {
      public void display()
        {
            Console.WriteLine("Inside demo2");
        }
    }
}
namespace third
{
    using second;
    using first;

    class Demo3
    {
        public void Look()
        {
            demo1 d = new demo1();
            d.show();
            Demo2 d2 = new Demo2();
            d2.display();
            Console.WriteLine("Inside demo3"); 
        }
        static void Main()
        {
           Demo3 d3 = new Demo3();
           d3.Look();
        }
    }
}