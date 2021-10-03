using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex992
{
    class Program
    {
        public static void CreateFile(string name, string path = "\\", int size = 1024)
        {
            // do something 
            Console.WriteLine("name:{0,-5} | path:{1,-3} | size:{2,-5}", name, path, size);
        }

        static void Main(string[] args)
        {
            CreateFile("file1.txt");
            CreateFile("file1.txt", "c:\\");
            CreateFile("file1.txt", "c:\\", 512);
            CreateFile("file1.txt", size: 128);
        }
    }
}
