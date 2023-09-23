using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day3
{
    internal abstract class Vehicle
    {
        public Vehicle() {
            Console.WriteLine("Vehicle Constructor");
        }
        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }
    internal class Car: Vehicle 
    {
        public Car() 
        {
            Console.WriteLine("Car Constructor");
        }
    }
    class VehicleTester
    {
        public static void VehicleTestOne()
        {
            Vehicle Tester=new Car();
            Tester.Start();
        }
    }
}
