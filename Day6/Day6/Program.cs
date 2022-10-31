using System;

namespace Day6
{
    class B
    {
        int a;
        public B(int a)
        {
            this.a = a;
        }
        public void print()
        {
            Console.WriteLine("Value of a is " + a);
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
           
            B b = new B(1);
            b.print();
            B b1 = new B(2);
            b1.print();
        }
    }
}
