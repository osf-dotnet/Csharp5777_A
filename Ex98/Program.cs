using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex98
{
    class Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string GetPointString()
        {
            return string.Format
    ("({0},{1})", x, y);
        }
    }
    class Program
    {
       
        public static void Swap(ref Point p1, ref Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }
        static void Main(string[] args)
        {
          

            Point p_1 = new Point { X = 2, Y = 3 };         

            Point p_2 = new Point { X = 4, Y = 5 };
            Swap(ref p_1, ref p_2);
            Console.WriteLine("p_1: " + p_1.GetPointString());
            Console.WriteLine("p_2: " + p_2.GetPointString());

            string str = "12334";
            int x ;
            bool b = int.TryParse(str, out x);
            Console.WriteLine(x);
        }

    }
}
