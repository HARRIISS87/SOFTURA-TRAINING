using System;
abstract class ArithOp
{
	public abstract void add();
	public abstract void sub();
	public abstract void mul();
	public abstract void div();
}
class Calculator:ArithOp
{
	public override void add()
	{
		int n1,n2,res;
		Console.WriteLine("Enter any two numbers to add:");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		res=n1+n2;
		Console.WriteLine("Result:"+res);
	}
	public override void sub()
	{
		int n1,n2,res;
		Console.WriteLine("Enter any two numbers to subtract:");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		res=n1-n2;
		Console.WriteLine("Result:"+res);
	}
	public override void mul()
	{
		int n1,n2,res;
		Console.WriteLine("Enter any two numbers to multiple:");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		res=n1*n2;
		Console.WriteLine("Result:"+res);
	}
	public override void div()
	{
		int n1,n2;
		double res;
		Console.WriteLine("Enter any two numbers to divide:");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		res=n1/n2;
		Console.WriteLine("Result:"+res);
	}
	public static void Main()
	{
		Calculator obj=new Calculator();
		obj.add();
		obj.sub();
		obj.mul();
		obj.div();
	}
}