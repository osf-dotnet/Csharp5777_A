using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex92
{
    class Point
    {
        public int x;
        public int y;

        public string GetPointString()
        {
            return  "(" + x + "," + y + ")" ; // return string.Format("({0},{1})", x, y);
        }
        public static void f1()
        {
            
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() {x=2,y=3 };
            //p1.x = 2;
            //p1.y = 3;
            Point p2 = p1;

          

            p2.y = 6;
            Console.WriteLine("p1: " + p1.GetPointString());
            Console.WriteLine("p2: " + p2.GetPointString());
        }
    }
}
