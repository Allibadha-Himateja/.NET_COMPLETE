using System;

//// THE EXTENTION QUESTION OF THE STUDENT AND PRODUCT LIST QUESTION
/// QUESTION IS 
/// l.add(p);
/// l.add(s);
/// l.add(100);
/// l.add("ram");
/// l.add(20.32);
/// this list have to store everytype in single array
/// as a brute force we should write base classes from every type 
/// for Integer,String,Double....
/// 
/// INSTEAD WE USE A CONCEPT CALLED OBJECT CLASS IN c#
/// In C#, the object class (also called System.Object) is the root base class for all other types, 
/// including value types (like int, struct) and reference types (like class, string).
/// so we need to create the array of object type in order to store them inside of them....

namespace MySpace
{
	class All
	{
		public virtual void Read() { }
		public virtual void print() { }
	}
	class Student : All
	{
		private int id;
		private string name;
		private double fee;
		public override void Read()
		{
			Console.WriteLine("Enter id");
			id = int.Parse(Console.ReadLine());

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
	class Product : All
	{
		private int id;
		private string name;
		private double price;
		public override void Read()
		{
			Console.WriteLine("Enter id");
			id = int.Parse(Console.ReadLine());

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
		private int top, first;
		private object[] m;
		public List()
		{
			top = 0;
			first = 0;
			m = new object[10];
		}
		public void add(object a)
		{
			m[top++] = a;
		}
		public object gets()
		{
			if (first < top)
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
			p = new Product();
			s = new Student();
			Console.WriteLine("Reading Prod");
			p.Read();
            Console.WriteLine("Reading Stud");
            s.Read();
			List l = new List();
			l.add(p);
			l.add(s);
			l.add(100);
			l.add("ram");
			l.add(20.32);
			for (int i = 0; i < 5; i++)
			{
				Object x = l.gets();
				if(x is Product || x is Student)
				{
					if (x is Student) ((Student)x).print();
					else ((Product)x).print();
				}
				else
				{
					Console.WriteLine(x.ToString());
				}
			}
			Console.WriteLine("---End-of-List---");
		}
	}
}
