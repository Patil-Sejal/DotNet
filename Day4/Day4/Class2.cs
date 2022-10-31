using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class employee
    {
        int ID;
        string EmpName;
        int salary;
        public void GetData()
        {
            Console.WriteLine("Please enter the Employee ID ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Please enter Employee Salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine("***************Employee Details are***************");
            Console.WriteLine("Employee ID : " + ID);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + salary);
        }
    }
    class emp
    {
        public static void main()
        {
            employee emp = new employee();
            emp.GetData();
            emp.PrintData();
        }
    }
}
