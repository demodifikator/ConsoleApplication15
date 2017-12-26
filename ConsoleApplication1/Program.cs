using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculate
    {
        private int first;

        public Calculate(){}      
        public Calculate(int first)
        {
            this.first = first;
        }

        public int MyProperty
        {            
            private set { first = value; }
            get { return first; }
        }

        public void SetValue(int t)
        {
            MyProperty = t;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            int i;            
            calc.SetValue(1111);
            i = calc.MyProperty;
            Console.WriteLine(i);
            Console.WriteLine(calc.MyProperty);
        }
    }
}