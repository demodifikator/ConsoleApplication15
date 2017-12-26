using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class Figure
    {
        public abstract void Area();
    }

    class Square : Figure
    {
        public double Side { get; set; };
        public override void Area()
        {
            Console.WriteLine($"Area of the square = {Side * Side}");
        }
    }

    class Circle : Figure
    {
        public double Radius { get; set; }
        public override void Area()
        {
            Console.WriteLine($"Area of the circle = {Math.PI * Math.Pow(Radius, 2)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure square = new Square();
            Figure circle = new Circle();
            
        }
    }
}
