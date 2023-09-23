using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day2
{
    internal class Box
    {
        public static int height;
        public int width;
        public const String type = "Wooden";

    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 200;
            Box first= new Box();
            Box second= new Box();
            first.width = 2345;
            second.width = 6789;
            Console.WriteLine($"first={first.width},{Box.height}");
            Console.WriteLine($"second={second.width},{Box.height}");
            Console.WriteLine(Box.type);
           
        }

    }
}
