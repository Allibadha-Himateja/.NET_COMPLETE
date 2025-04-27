using System;
interface MyInterface1
{
    public virtual int sum(int x, int y);
}
interface MyInterface2 : MyInterface1
{
    public virtual int subt(int x, int y);
}
interface MyInterface3
{
    public virtual int multi(int x, int y);
}
class Math : MyInterface2, MyInterface3
{
    public int sum(int x, int y)
    {
        return x + y;
    }
    public int subt(int x,int y)
    {
        return x - y;
    }
    public int multi(int x, int y)
    {
        return x * y;
    }
    public int div(int x,int y)
    {
        return x / y;
    }
}
class Program
{
    public static void Main()
    {
        MyInterface1 m1;
        MyInterface2 m2;
        MyInterface3 m3;
        Math m=new Math();

        m1 = m;
        Console.WriteLine(m1.sum(10,20));
        m2 = m;
        Console.WriteLine(m2.sum(10,20)+""+m2.subt(20,10));
    }
}