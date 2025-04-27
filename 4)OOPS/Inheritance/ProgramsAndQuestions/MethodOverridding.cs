using System;

namespace MySpace
{
    class parent
    {
        //  the virtual functions(overriddable method)
        public virtual void print()
        {
            Console.WriteLine("from parent class");
        }
    }
    class child : parent
    {
        // overridding the virtual method from the parent class
        public override void print()
        {
            Console.WriteLine("from child class");
        }

        public void print(string str)
        {
            Console.WriteLine("from the child class"+str);
        }
    }
    class program
    {
        public static void Main()
        {
            parent p;
            // HOLDING THE INSTANCE OF THE PARENT CLASS
            p=new parent();
            p.print();

            // HOLDING THE INSTANCE OF THE CHILD CLASS
            p=new child();
            p.print();

            //p.print("hi"); ///// ERROR
            //error CS1501: No overload for method 'print' takes 1 arguments 
            // SINCE THE PRINT(STRING STR) IS NOT A METHOD WHICH IS BEEN OVER RIDDEN FROM THE PARENT CLASS
            // THE PARENT OBJECT CANNOT BE ABLE TO CALL THEM
            // COMPILE TIME ERROR

            // IN ORDER TO RESOLVE THIS ERROR OF PARENT C=OBJ HOLDING CHILD INSTANCE
            // USE THE TYPE CASTING
            ((child) p).print("hello");
            // now no error
            // BECAUSE THE COMPILER THINK THAT P IS ACTUALLY A CHILD OBJECT INSTEAD OF PARENT OBJECT
        }
    }
}

// THE USAGE OF THE VIRTUAL AND OVERRIDE KEYWORDS
// the virtual keyword is used inside the parent classes 
//  which are further can able to be overridden inside the child class

// the override keyword is used specifically inside the derived class of any base class
// the name of the method from the parent and child must be SAME(MOST IMPORTANT) and that method should be virtual method

// THE .NET FRAMEWORK PROVIDES THE COMPILE TIME BINDING
// WE HAVE TO MENTION WHAT ARE VIRTUAL AND WHAT ARE THE OVERRIDDEN METHOD INSIDE THE CODE

