using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day5
{
    internal class Arr
    {
        public static void FirstMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int length = sample.Length;
            int i;
            Random rnd = new Random();  
            for (i = 0; i < 10; i = i + 1)
                sample[i] = rnd .Next(100);
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            Console.WriteLine("Sum" + sample.Sum());
            Console.WriteLine("Average" + sample.Average());
            Console.WriteLine("Max" + sample.Max());
            Console.WriteLine("Min" + sample.Min());

        }
    }

}
