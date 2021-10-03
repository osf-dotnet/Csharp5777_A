using System;

namespace Ex913
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                    Console.Write($"{i*j ,3} ");
                Console.WriteLine();
            }
        }
    }
}
