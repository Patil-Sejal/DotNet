using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
     class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Greetings of the day");
        }
        public void SetAge(int n)
        {
           age=n;
        }
    }
    class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age);
        }

    }
    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: "+age);
        }
        public void study()
        {
            Console.WriteLine("I am studying");
        }
    }
    class Class2
    {
        public static void Main2()
        {
            Person p = new Person();
            p.Greet();
            Student s = new Student();
            s.SetAge(20);
            s.Greet();
            s.ShowAge();
            s.study();
            Teacher t = new Teacher();
            t.SetAge(26);
            t.Greet();
            t.ShowAge();
        }
    }
}
