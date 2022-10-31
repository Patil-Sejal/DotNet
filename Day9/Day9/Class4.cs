using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Class4
    {
        public delegate void addNum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Main()
        {
            Class4 c = new Class4();
            addNum addNumDel = new addNum(c.sum);
            addNumDel(100, 40);

            addNum addNumDel2 = new addNum(c.subtract);
            addNumDel2(100, 40);

            addNum addNumDel3 = new addNum(c.mul);
            addNumDel3(100, 40);
        }
    }
}

