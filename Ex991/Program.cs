using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex991
{
    class Program
    {
        public static void PrintPerson(string name, int age, int id)
        {
            Console.WriteLine
                ("id: {0} name: {1} age: {2}", id, name, age);
        }

        static void Main(string[] args)
        {
            int x = 9;
            double y =  x;

            x = (int)y;

            PrintPerson(age: 29, name: "oshri", id: 1234);
        }
    }
}
