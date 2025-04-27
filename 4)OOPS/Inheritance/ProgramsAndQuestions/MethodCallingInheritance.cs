using System;
namespace MySpace
{
    class Parent
    {
        public void print()
        {
            Console.WriteLine("From parent class");
        }
    }
    class Child : Parent
    {
        public void print()
        {
            Console.WriteLine("from child class");
            //print();
            // this will be recursion

            // HOW TO CALL THE PARENT CLASS PRINT METHOD
            // using base method 
            base.print();
        }
    }

    class Program
    {
        public static void Main()
        {
            Child c;
            c = new Child();
            c.print();

            // this code specifically for telling you how to call the method of the parent class from the child class
            // that is using the base keyword
        }
    }
}