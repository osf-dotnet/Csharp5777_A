using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex993
{
    using System;
    using System.Collections;

class Fragment
{
    public long Numerator { get; set; }

    long m_denominator;
    public long Denominator
    {
        get { return m_denominator; }
        set { m_denominator = value != 0 ? value : 1; }
    }



    public static Fragment operator *(Fragment fragment1, Fragment fragment2)
    {
        Fragment f = new Fragment();
        f.Numerator = fragment1.Numerator * fragment2.Numerator;
        f.Denominator = fragment1.Denominator * fragment2.Denominator;
        return f;
    }
    public static Fragment operator *(Fragment fragment1, int num)
    {
        Fragment f = new Fragment();
        f.Numerator = fragment1.Numerator * num;
        f.Denominator = fragment1.Denominator;
        return f;
    }

    public static Fragment operator ++(Fragment fragment1)
    {
        fragment1.Numerator++;
        return fragment1;
    }

    public static implicit operator double(Fragment fragment)
    {
        //  1/2 = 0.5
        return (double)fragment.Numerator / fragment.Denominator;
    }

    public static explicit operator Fragment(double num)
    {
        Fragment f = new Fragment();
        string stringNumber = num.ToString();
        int pointIndex = stringNumber.IndexOf('.');

        if (pointIndex == -1)
        {
            f.Numerator = (int)num;
            f.Denominator = 1;
        }
        else
        {
            // 1.5   --->   15/10 ---> 3/2
            string left = stringNumber.Substring(0, pointIndex);
            string right = stringNumber.Substring(pointIndex + 1, stringNumber.Length - (pointIndex + 1));

            long numerator = long.Parse(left + right);
            long denominator = (long)Math.Pow(10, right.Length);

            long m = GCD(numerator, denominator); // המחלק המשותף המקסימאלי

            f.Numerator = numerator / m;
            f.Denominator = denominator / m;
        }

        return f;
    }

    /// <summary>
    /// Greatest common divisor
    /// a must to be great then b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>greatest common divisor of two Int32 number </returns>
    private static long GCD(long a, long b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }
}





    class MainClass
    {
public static void Main()
{
    Fragment[] FragmentArr = new Fragment[3];
    FragmentArr[0] = new Fragment { Numerator = 3, Denominator = 2 }; // f1= 3/2
    FragmentArr[1] = FragmentArr[0] * 2; // f2 = 6/2
    FragmentArr[2] = FragmentArr[0] * FragmentArr[1]; // f3 = 18 / 4

    for (int i = 0; i < FragmentArr.Length; i++)
    {
        Console.WriteLine("{0} / {1} == {2}",
            FragmentArr[i].Numerator,
            FragmentArr[i].Denominator,
            (double)FragmentArr[i]);
    }

    Console.WriteLine();
    Console.WriteLine("double 1d / 3               =  {0}", 1d / 3);
    Fragment f1 = (Fragment)(1d / 3);
    Console.WriteLine("(Fragment)(1d / 3)          =  {0} / {1}", f1.Numerator, f1.Denominator);
    Console.WriteLine("(double)((Fragment)(1d / 3))  =  {0}", (double)((Fragment)(1d / 3)));
}
    }

}