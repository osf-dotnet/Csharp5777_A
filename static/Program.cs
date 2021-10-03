using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticEx
{
    class Product
    {
        public static int code = 0;

        public int Id { get; private set; }
        public string Name { get; set; }

        
        public Product(string name)
        {
            this.Id = code++;
            this.Name = name;
           
        }

        public static void f1()
        {
            code = 5;
        }

        public static void print()
        {
            Console.WriteLine(code);
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
    
            Product p1 = new Product("mouse");
            Product p2 = new Product("keyboard");
            Product.f1();
            Product p3 = new Product("microphone");
         
            
            Console.WriteLine("p1: id={0,-3} name = {1}", p1.Id, p1.Name);
            Console.WriteLine("p2: id={0,-3} name = {1}", p2.Id, p2.Name);
            Console.WriteLine("p3: id={0,-3} name = {1}", p3.Id, p3.Name);
           
            
        }
    }
}
