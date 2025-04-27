using System;

namespace MySpace
{
	public class Student
	{
		/// note 1
		// we cant direcly initialize variable inside the class directly..
		// for example class
		//	{
		//		ind id = 0;
		//	}
		// instead we can only declare inside the class directly
		// class { int id; public constructor(){id=0;}/method{ list=new ....} } 

		public int id;
		public string name;
		public double fee;
		
		public Student()
		{

		}
		/// note 2
		//	IF WE ONLY GIVE CONSTRUCTOR WITH PARAMETER
		// WE CANNOT BE ABLE TO USE THE new Student();
		public Student(int id,string name,double fee)
		{
			this.id = id;
			this.name = name;
			this.fee = fee;
		}

		public void Read()
		{
			Console.WriteLine("Enter id:");
			this.id = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter name:");
			this.name = Console.ReadLine();
			Console.WriteLine("Enter fee:");
            this.fee = double.Parse(Console.ReadLine());
		}

		public void Print()
		{
			Console.WriteLine($" id={id} , name={name} , fee={fee}");
		}
		
		public GetId()
		{
			return id;
		}
	}

	public class program
	{
		public static void Main()
		{
			//Student s = new Student(1,"hi",32000.23);
			//s.Print();
			//Student t = new Student();
			//t.Read();
			//t.Print();

			//Read 5 Students and print
			//Student[] arr = new Student[5]; 

			//for (int i = 0; i < 5; i++)
			//{
			//	Student student = new Student();
			//	student.Read();
			//	arr[i] = student;
			//}
			//for (int i = 0;i < 5;i++)
			//{
			//	arr[i].Print();
			//}

			//Searching student
			Console.WriteLine("Enter Id:");
			int tar=int.Parse(Console.Read());
			int i;
			for(i=0;i<arr.Length;i++)
			{
				if (arr[i].GetId()==tar)
				{
					Console.WriteLine("Found");
				}
			}
			if(i>tar)
			{
				Console.WriteLine("Not Found");
			}

        }
	}
}
