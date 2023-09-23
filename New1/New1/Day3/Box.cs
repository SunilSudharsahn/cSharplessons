using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace New1.Day3
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x) 
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height: {Height}, Length: {Length}, Width: {Width}";
        }
    }
    internal class WoodenBox : Box
    {
        public WoodenBox():base(1)
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public WoodenBox(int x) : base(x)
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public WoodenBox(int x, int y) : base(x)
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public void Move()
        {
            Console.WriteLine("Wooden Box shifted");
        }
        public override string ToString()
        {
            return "SUNIL and KEERTHU";
        }

    }
    internal class BoxTester
    {
        public static void TestOne()
        {
           Box box = new Box(100);
            box.Height = 10;
            box.Length = 20;
            box.Width = 5;
            box.Open();
            box.Close();
            String outbox = box.ToString();
            Console.WriteLine(outbox);





        }




        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;
            box.Open();
            box.Close();
            String outbox = box.ToString();
            Console.WriteLine(outbox);
            //box.Move();
            //box.Area = 250;




        }
    }
}