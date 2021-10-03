using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex99
{
    class Program
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4));
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(6));
            Console.WriteLine(Sum(10, 5));
            Console.WriteLine(Sum(13, 2, 26, 14, 5, 6, 7, 8, 9, 19, 11, 34, 67, 89, 123, 56));
        }
    }
}
