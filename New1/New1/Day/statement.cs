using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day
{
    internal class Statement
    {
        public static int Test(int y) {
          
            if (y<10) {
                Console.WriteLine("less than 0");
            }
            else 
            {
                Console.WriteLine("more than 0");
            }
            return 0;
        }
       

    }
}
