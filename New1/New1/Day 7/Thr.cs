using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day_7
{
    internal class Thr
    {
        public void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadId=" + id);
            Console.WriteLine("Isalive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString);
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture"+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString);
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());


        }
      

    }
}
