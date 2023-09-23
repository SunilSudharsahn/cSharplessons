using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day_7
{
    internal class Lam
    {
        public static void DemoA()
        {
            Func<int, int> foo = x => x / 2;//Last int parameter is the result 1st is the input
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);



        }
        public static void DemoB()
        {
            Func<int> foo = () => 100; //has return type but no parameter
            int result = foo();
            Console.WriteLine(result);
        }



        public static void DemoC()
        {
            Func<double, double, double> callme = (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 10;
            double result = callme(v1, v2);
            Console.WriteLine(result);
        }
        public static void DemoD()
        {
            //smaller can be coverted to big that is int to long is possible but the vice versa is not possible.
            Func<int, double> foo = x => x / 2;
            int v1 = 101;
            double result = foo(v1);
            Console.WriteLine(result);
        }
        static void Echo(Func<string> foo) 
        {
            string str=foo();
            Console.WriteLine(str);
        }
        static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "World");
        }
        static double Strans(Func<int,int,double> foo)
        {
            return foo(50, 5);
        }
        static void TestStrans()
        {
            Func<int, int, double>Multiply=(x,y) => x * y;
            double d = Strans(Multiply);
            Console.WriteLine(d);
            Func<int, int, double>Add=(x,y) => x + y;
            d=Strans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0) y = 1;
                return x / y;
            };
            double d1 =Strans(Divide);
            Console.WriteLine(d1);
        }
    }
}
