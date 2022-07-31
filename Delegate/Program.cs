using System;

namespace Delegate
{
    class Program
    {
        public delegate void del1();
        public void sum1()
        {
            Console.WriteLine("Total :" );
        }

        public delegate void del(int a, int b);
        public void sum(int x,int y)
        {
            Console.WriteLine("Total :" + (x + y));
        }

        static void Main(string[] args)
        {
            Program o = new Program();

            del obj = new del(o.sum);
            obj(90, 9);

            del1 obj1 = new del1(o.sum1);
            obj1();
            Console.WriteLine("Hello World!");
        }
    }
}
