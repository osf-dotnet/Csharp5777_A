using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Ex995
{

    //readonly struct Point
    //{
    //    public int X { rget; private set; }
    //    public int Y { get; private set; }


    //    public readonly double Sum()
    //    {
    //        int x = new Random().Next();
    //        x++;
    //        return X + Y+x;
    //    }

    //}

    //struct Point
    //{
    //    public int X { get; init; }
    //    public int Y { get; init; }
    //}


    class Program
    {

        static int x = 1;


        public int X { get; private set; }
        public int Y { get; private set; }


       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }
}
