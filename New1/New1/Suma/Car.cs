using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Suma
{
    internal class Car
    {
        public void Supra()
        {
            Console.WriteLine("Supra is the worlds fastest car");
            int speed;
            int engine;
            string variant;
        }
        public void Skyline()
        {
            Console.WriteLine("Skyline Gtr is the worlds second fastest car");
            int speed;
            int engine;
            string variant;

        }
    }
    internal class Car2 : Car
    {
        public void vehicle()
        {
            int speed = 387;
            int engine = 16;
            string variant = "Supra Mk";
            Console.WriteLine("Supra is the fastest car");
        }
        public void Sky()
        {
            int engine = 15;
            int speed = 300;
        }

        internal static void car3()
        {
            throw new NotImplementedException();
        }
    }
    internal class Car3 : Car2
    {
        public static void Main(string[] args)
        {
            Car2 car = new Car2();
            Console.WriteLine("Worlds fastest car");
            int speed;
#pragma warning disable CS0168 // Variable is declared but never used
            int engine;
#pragma warning restore CS0168 // Variable is declared but never used
#pragma warning disable CS0168 // Variable is declared but never used
            string variant;
#pragma warning restore CS0168 // Variable is declared but never used

        }
    } 
}
