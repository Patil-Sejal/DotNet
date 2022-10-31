using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Multiplication
    {
        public void Multi(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Multi(int a, int b, double c)
        {
            Console.WriteLine(a * b * c);
        }
        public void Multi(double  a, double  b)
        {
            Console.WriteLine(a * b);
        }
    }
    class Class4
    { public static void Main4()
        {
            Multiplication m = new Multiplication();
            m.Multi(5, 6);
            m.Multi(9,8,6.9);
            m.Multi(8,16,8.34);
        }
    }
}
