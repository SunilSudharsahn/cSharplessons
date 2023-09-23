using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day5
{
    internal class Do
    {
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
           Console.WriteLine(x);
        }
        public static void DotaskA(ref int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void Main()
        {
            int v1 = 1000;
            Console.WriteLine($"v1{ v1}");
            Dotask(v1);
            Console.WriteLine($"v1:{v1}");
            DotaskA(ref v1);
            Console.WriteLine($"v1:{v1}");

        }
    }
}
