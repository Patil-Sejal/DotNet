using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Class4
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            string str = "Sejal";
            int x = 42;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
           // al.Remove(x);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

        }
    }
}
