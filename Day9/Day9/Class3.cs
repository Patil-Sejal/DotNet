using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9
{
    class Employeee
    {
        public int EmployeeeID { get; set; }
        public string EmployeeeName { get; set; }
        public int EmployeeeSalary { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter your EmployeeID");
            EmployeeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your EmployeeName");
            EmployeeeName = Console.ReadLine();
            Console.WriteLine("Please enter your Salary");
            EmployeeeSalary = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Class3
    {
        public static void Main4()
        {
            List<Employeee> employeeList = new List<Employeee>();
            Employeee e = new Employeee();
            e.GetData();
            employeeList.Add(e);
            //c# to json
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(e);
            Console.WriteLine(json);
            //json to c#
            var eObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(json);
            FileStream f = new FileStream("emp.json", FileMode.Append, FileAccess.Write);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine(e.EmployeeeID);
            s.WriteLine(e.EmployeeeName);
            s.WriteLine(e.EmployeeeSalary);
            s.Flush();
            s.Close();
            f.Close();

            //reading json
            FileStream fsR = new FileStream("emp.Json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsR);
            Console.WriteLine("======Content from file========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (e != null)
            {
                Console.WriteLine("Employee ID:" + e.EmployeeeID);
                e.EmployeeeID = Convert.ToInt32(sr.ReadLine());
                Console.WriteLine("Employee Name: " + e.EmployeeeName);
                e.EmployeeeName = sr.ReadLine();
                Console.WriteLine("Employee Salary: " + e.EmployeeeSalary);
                e.EmployeeeSalary = Convert.ToInt32(sr.ReadLine());
                break;
            }
            sr.Close();
            fsR.Close();
        }
    }
}
