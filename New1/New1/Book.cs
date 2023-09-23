using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1
{
    internal abstract class Book
    {
        public Book() 
        {
            Console.WriteLine("Book Constructor");
        }
        public abstract void Openbook();
    }
}
