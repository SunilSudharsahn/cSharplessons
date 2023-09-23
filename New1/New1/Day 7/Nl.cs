using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day_7
{
    internal class Nl
    {
        public static void Bank()
        {
            Console.WriteLine("Enter the Name of the bank");
        }
        public static void Customer()
        {
            Console.WriteLine("Enter the Name of the customer");
        }
        public static void Account()
        {
            Console.WriteLine("Enter the Account number");
            int a;
        }
        public static void Message()
        {
            Console.WriteLine("Enter your  Email id");
        }

    }
    internal class cl : Nl
    {
        public static void Deposit() 
        {
            Console.WriteLine("Enter the Deposit amount");
            int x;
        }
        public static void Withdrawl()
        {
            Console.WriteLine("Enter the withdrawl amount");
            int y;
        }
        public static void Sms()
        {
            Console.WriteLine("Amount has been Debited ");
        }
        public static void Email()
        {
            Console.WriteLine("Recipt has been sent to your Mail ");
        }
    }
    internal class Hg : cl
    {
        public static void Number()
        {
            Nl a=new Nl();
            Console.WriteLine("print bank");
            

        }


    }
}
