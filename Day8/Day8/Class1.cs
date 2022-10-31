using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class Sample
    {
        public Sample(int a)
        {
            Console.WriteLine("Hi i am sample" + a);
        }
    }
    class SampleB : Sample
    {
        public SampleB(int a) : base(a)
        {
            Console.WriteLine("Hi i am sample B" + b);
        }
    }
    class SampleC : SampleB
    {
        public SampleC(int a) : base(a)
        {
            Console.WriteLine("Hi i am sample C" + c);
        }
    }
    class Class1
    {
        public static void Main23()
        {
            SampleC c = new SampleC(2);
        }
    }
}
