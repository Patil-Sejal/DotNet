using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class IndexerClass
    {
        private string[] name = new string[3];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
    }
    class Class3
    {
        public static void Main3()
        {
            IndexerClass c = new IndexerClass();
            c[0] = "Sejal Patil";
            c[1] = "Sejal Vazare";
            c[2] = "Arbina Shaikh";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(c[i]);
            }

        }
    }
}
