using System;
namespace MySpace
{
    class All
    {
        public virtual void Read() { }
        public virtual void print() { }
    }
    class Student:All
    {
        private int id;
        private string name;
        private double fee;
        public override void Read()
        {
            Console.WriteLine("Enter id");
            id=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter fee");
            fee = double.Parse(Console.ReadLine());
        }
        public override void print()
        {
            Console.WriteLine($"{id} + {name} + {fee}");
        }
    }
    class Product:All
    {
        private int id;
        private string name;
        private double price;
        public override void Read()
        {
            Console.WriteLine("Enter id");
            id=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter price");
            price = double.Parse(Console.ReadLine());
        }
        public override void print()
        {
            Console.WriteLine($"{id} + {name} + {price}");
        }
    }
    class List
    {
        private int top,first;
        private All[] m;
        public List()
        {
            top=0;
            first=0;
            m=new All[10];
        }
        public void add(All a)
        {
            m[top++] = a;
        }
        public All gets()
        {
            if(first<top)
            {
                return m[first++];
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Product p;
            Student s;
            p= new Product();
            s = new Student();
            p.Read();
            s.Read();
            List l = new List();
            l.add(p);
            l.add(s);
            for(int i = 0;i<2;i++)
            {
                All x = l.gets();
                x.print();
            }
            Console.WriteLine("---End-of-List---");
        }
    }
}