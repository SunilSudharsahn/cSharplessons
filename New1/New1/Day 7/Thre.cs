using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace LessonA.DaySeven
{
    internal class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAlive" + t1.IsAlive);
            Console.WriteLine("priority=" + t1.Priority);
            Console.WriteLine("ThreadSTAATE" + t1.ThreadState);
            Console.WriteLine("currentculture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("currentculture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("currentculture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());



        }
        public static void DemoA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Main ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" + id);
            ServiceA a1=new ServiceA(); 
            Thread t1 = new Thread(a1.DoTaskA);
            t1.Start();
            Console.WriteLine("-------------------End of DemoB----------------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            Console.WriteLine(t1.ManagedThreadId+"t1 state"+t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "state after sleep" + t1.ThreadState);
            Thread.Sleep(8000);
            Console.WriteLine(t1.ManagedThreadId + "t1 state after sleep" + t1.ThreadState);
            Console.WriteLine("-------------------End of DemoB----------------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts); 
            t1.Start();
            t2.Start();
            t1.Join(2000);
            if(t1.IsAlive) t1.Abort();
            t2.Join(2000);
            if (t2.IsAlive) t2.Abort();
            Console.WriteLine("-------------------End of Demo----------------");
        }
    }
    class ServiceA
    {
        int x = 0;
        public void DoTaskA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside DoTaskA");
            Console.WriteLine("\t Thread ID :" + id);
            //int x = 0;
            for (int icount = 0; icount < 10; icount++)
            {
                x += icount;
                Console.WriteLine("\t ID=" + id + ":" + x + "icount" + icount);
                Thread.Sleep(1000);
            }
        }
    }
}

