using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9
{
    class Employee
    {
        public string str = "Sejal";
        public int id = 101;
    }
    class Class1
    {
        static void Main2(string[] args)
        {
            Employee e = new Employee();
            FileStream fs = new FileStream("Employee.json", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(e.str);
            sw.WriteLine(e.id);
            sw.Flush();
            sw.Close();
            fs.Close();


            //Reading from a file
            FileStream fsR = new FileStream("Employee.Json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsR);
            Console.WriteLine("======Content from file========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (e != null)
            {
                Console.WriteLine(e.str);
                e.str = sr.ReadLine();
                Console.WriteLine(e.id);
                e.id =Convert.ToInt32 ( sr.ReadLine());
                break;
            }
            sr.Close();
            fsR.Close();
        }
    }
}
