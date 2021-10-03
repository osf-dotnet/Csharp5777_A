using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ex94
{

    class MyClass
    {
     public  MyEnum E1;
    }

     enum MyEnum { male , female }
  enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
 //   enum Days { ראשון,שני,שלישי,רבעי,חמישי,שישי,שבת };
    class Program
    {
        static void Main(string[] args)
        {
           
            Days d = Days.Fri;
           
            MyClass m = new MyClass();
            Console.WriteLine(m.E1);
            MyEnum e1  = MyEnum.male;
            MyEnum e2 = e1;
            MyEnum e3 = MyEnum.female;
            Console.WriteLine("e1: " + e1);
            Console.WriteLine("e2: " + e2);
            Console.WriteLine("e3: " + e3);

        

            Console.ReadLine();
        }
    }

}
