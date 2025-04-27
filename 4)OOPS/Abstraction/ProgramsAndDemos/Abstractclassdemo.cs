using System;

public abstract class AbstractClass
{
	// AN ABSTRACT CLASS DOES NOT NEED ANY CONSTRUCTOR 
	// NO USE OF THE CONSTRUCTOR 

	public virtual void print();
	public void print(string str)
	{
		Console.WriteLine("from abstract class with str:" + str);
	}
}
class Mycls : AbstractClass
{
    public override void print()
    {
		Console.WriteLine("From Child class");
		public void print(string x,string y)
		{
			Console.WriteLine("" + x + y);
		}
    }
}
class Program
{
	public static void Main()
	{
		AbstractClass a;
		// a=new AbstractClass(); =========>  this is wrong no instance for abstract class

		Mycls cls;
		cls = new Mycls();
		cls.print();
		cls.print("hi", "hello");
		a = cls; // parent holding child instance
		a.print();// calling the overriden method with access virtual method
		// a.print("hi","hello"); this is wrong no signiture of print with parameter in parent class

	}
}
