using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Bake
    {        
        public int Temperature{ get; set; }
        protected void Heat()
        {
            Console.WriteLine("It is working now.");
        }

        public abstract void On();
        public abstract void Off();
    }

    class GasBake : Bake
    {
        public override void Off()
        {
            Console.WriteLine("Gas bake is off.");
        }

        public override void On()
        {
            Console.WriteLine("Gas bake is on.");
            Heat();
        }
    }

    class ElectricBake : Bake
    {
        public override void Off()
        {
            Console.WriteLine("Electric bake is off.");
        }

        public override void On()
        {
            Console.WriteLine("Electric bake is on.");
            Heat();
        }
    }

    class Program
    {
        static void On(Bake bake)
        {
            Console.WriteLine(bake.Temperature);
            bake.On();
        }
        static void Off(Bake bake)
        {
            Console.WriteLine(bake.Temperature);
            bake.Off();
        }
        static void Main(string[] args)
        {
            Bake elbake = new ElectricBake();
            Bake gasbake = new GasBake();
            elbake.Temperature = 123;
            gasbake.Temperature = 160;

            On(elbake);
            Off(elbake);
        }
    }
}
