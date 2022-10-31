﻿using System;

namespace Day8
{
    class Program
    {
        static void Main1(string[] args)
        {
            int a = 7, b = 0;
            int c;
            int[] a1 = new int[3];
            try
            {
                c= a / b;
                a1[3] = 90;
            }
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine("Some error Occured");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine("Some error Occured in array");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
