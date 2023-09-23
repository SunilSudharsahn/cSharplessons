using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day5
{
    internal class Gen
    {
        public static void GenericListDemoEmp()
        {
            List<Emp> empList = new List<Emp>();



            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            Emp e1 = new Emp() { ID = 123, Name = "Venkat", Salary = 10000 };
            empList.Add(e1);
            empList.Add(new Emp() { ID = 456, Name = "Krishnan", Salary = 15000 });
            //empList.Add("Hello");
            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            empList.Add(new Emp() { ID = 1000, Name = "Sam", Salary = 10000 });
            empList.Add(new Emp() { ID = 500, Name = "John", Salary = 10000 });
            empList.Add(new Emp() { ID = 200, Name = "Suresh", Salary = 10000 });
            empList.Add(e1);
            empList.Add(e1);



            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            //IEnumerator data = empList.GetEnumerator();
            //while (data.MoveNext())
            //{
            //    Object obj = data.Current;
            //    if (obj.GetType() == typeof(Emp))
            //    {
            //        Emp e = (Emp)obj;
            //        Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
            //    }
            //    else
            //        Console.WriteLine("=======> Object is not an Employee");
            //}
            foreach (Emp e2 in empList)
            {
                Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.ID, e2.Name, e2.Salary);
            }
        }
    }
}
