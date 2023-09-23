using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day8
{
    internal class Strem
    {
        public static void TestOne()
        {
            char ch;
            System.Console.WriteLine("Press a key followed by enter");
            int x=Console.Read();
            ch = (char)x;   
            Console.WriteLine("\n"+x+"Your key is:"+ch);
        }
        public static void TestTwo()
        {
            char ch = ' ';
            System.Console.WriteLine("Press any key q to Exit");
            while(ch != 'q')
            {
                ch=(char)Console.Read();
                Console.WriteLine("Your key is"+ch);
            }


        }
        public static void TestThree() 
        {
            System.Console.WriteLine("Enter a sentence");
            string?str=Console.ReadLine();
            Console.WriteLine(" " + str);


        }
    }
}
