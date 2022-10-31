using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Class1
    {
        public static void Main2(string[] args)
        {
            Console.WriteLine("Enter any string: ");
            string name = Console.ReadLine();
            for (int i = 0; i = name[i].Length ; i++)
            {
                string rev = name[i].ToString();

                if (rev == name)
                {
                    Console.WriteLine("String is palindrome");
                }
                else
                    Console.WriteLine("String is not palindrome");
            }
        }
    }
}
