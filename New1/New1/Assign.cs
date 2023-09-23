using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day3
{
    internal class Assign
    {
        public static void AssignSameStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                String s2 = "Hello";
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
    }
}
