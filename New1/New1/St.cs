using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day3
{
    internal class St
    {
        public static void TestStringEquals()
        {
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";



            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// true



            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult); // true       
        }
        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length " + s1.Length);
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            String s3 = s1.Substring(5, 10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }
    }
}
