using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex994
{
    public class DynamicStringArray
    {
        String[] arr;
        public int Count { get; private set; }
        int capacity = 2;

        public DynamicStringArray()
        {
            arr = new string[capacity];
        }

        private void growingArray()
        {
            capacity += capacity;
            String[] temp = new String[capacity];
            for (int i = 0; i < arr.Length; i++)
                temp[i] = arr[i];
            arr = temp;
        }

        public void Add(String obj)
        {
            if (Count >= capacity)
                growingArray();

            arr[Count] = obj;
            Count++;
        }

        public string this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        
        public string this[string c]
        {
            get
            {
                string str = "no result";
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i].StartsWith(c))
                    {
                        str = arr[i];
                        break;
                    }
                return str;
            }
        }
    }


    public class MyClass
    {
        static void Main(string[] args)
        {

            DynamicStringArray arr = new DynamicStringArray();
            arr.Add("oshri");
            arr.Add("osi");
            arr.Add("abc");
            arr.Add("efg");

            Console.WriteLine(arr[2]);
            Console.WriteLine(arr["e"]);
        }
    }

}