using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Array
    {
        int[] arr = new int[10];
        Random rand = new Random();
        double sum;

        public double property
        {
            get
            {
                for (int i = 0; i<arr.Length;i++)                
                    arr[i] = rand.Next(0, 11);

                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];

                return sum / arr.Length;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Array arr = new Array();
            a = arr.property;

            Console.WriteLine(arr.property);
            Console.WriteLine(a);
        }
    }
}
