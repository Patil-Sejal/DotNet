using System;

namespace Day5
{
    abstract class Animal
    {
        public  string Name;
          public void setname()
          {
            Console.WriteLine("Enter any name you want to set: ");
            string name = Console.ReadLine();
            Name = name;
          }
          public void getname()
          {
            Console.WriteLine("The name you entered is: " + Name);
          }
        public abstract void eat();
    }
    class Dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine(Name + " is eating");
        }

    }
    class Class1
    {
        public static void Main1()
        {
            Dog d = new Dog();
            d.setname();
            d.getname();
            d.eat();
        }
    }
}

