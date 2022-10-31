using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Duplicate
    {
        static int maxCHARS = 256;
        static void calculate(String s, int[] cal)
        {

            for (int i = 0; i < s.Length; i++)
                cal[s[i]]++;
        }
        class Class4
        {
            public static void Main()
            {
                String s = "abbaba";

                int[] cal = new int[maxCHARS];
                calculate(s, cal);

                for (int i = 0; i < maxCHARS; i++)
                    if (cal[i] > 1)
                    {
                        Console.WriteLine("Character " + (char)i);
                        Console.WriteLine("Occurrence = " + cal[i] + " times");
                    }
            }
        }
    }
}
    
