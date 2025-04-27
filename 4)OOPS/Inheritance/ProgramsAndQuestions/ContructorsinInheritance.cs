using System;

namespace MySpace
{
	public class Parent
	{
		//public Parent()
		//{
		//	Console.WriteLine("from parent contructor");
		//}
		public Parent(int val)
		{
			Console.WriteLine("from parent class" + val);
		}
	}
	public class Child : Parent
	{
		//public Child()
		//{
		//	Console.WriteLine("from the child contructor");
		//}
		public Child(int val) : base(val)
		{
			Console.WriteLine("from the child class" + val);
		}
	}

	class Program
	{
		public static void Main()
		{
			///////////////////////////////////////////
			Parent parent;
			Child child;

			//parent = new Parent();
			//child = new Child();

			//output
			// from parent contructor
			// from parent constructor
			// from child contructor

			// why the parent constructor is called two times
			// its because the parent constructor will be initialized before the child instance is even created 
			//	DURING THE CREATION OF INSTANCE OF THE CHILD THE PARENT CONSTRUCTOR IS INVOKED
			// that means the functionality of the base clss is being initialized
			// to provide them to the child which is derived from the base class
			////////////////////////////////////////////

			// LETS ASSUME THE CONSTRUCTORS WITH PARAMETERS

			Parent p = new Parent(100); // ====>  from parent class 100
			Child c = new Child(100);  // =====> ERROR

			// so we discussed the before child initialization the parent constructor will be invoked
			// BUT THE PARENT CLASS DOES NOT HAVE ANY CONSTRUCTOR WITH NO PARAMENTERS
			//  the solution for that is we should call the parent class constructor manually 
			// USING THE BASE() METHOD  
			//  CHECK OUT THE ABOVE SYNTAX
			// public Child(int val) : base(val)

			// the output is
			//from parent class100
			//from parent class100
			//from the child class100
		}
	}
}