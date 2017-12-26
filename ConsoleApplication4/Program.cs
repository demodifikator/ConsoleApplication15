using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    static class A
    {
        public static int a = 15;

        public static void Move(int x, int y)
        {
            Console.WriteLine(x*y);
        }
    }

    class B
    {
        public static int a;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.a);
            A.Move(12, 12343234);

            B b = new B();          
            B.a = 16;
            Console.WriteLine(B.a);
            Console.WriteLine(b);
        }
    }
}
