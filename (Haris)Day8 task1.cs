using System;
class ArthOp
{
	public void add(int n1,int n2)
	{
		
		sum=n1+n2;
		Console.WriteLine("Sum is="+sum);
	}
	public void sub(int n1,int n2)
	{
		sub=n1-n2;
		Console.WriteLine("Sub is="+sub);

	}

}
class ArthOp2:ArthOp
{
		public void mul(int n1,int n2)
		{
		    mul=n1*n2;
			Console.WriteLine("Product is="+mul);
		}
		public void div(int n1,int n2)
		{
			float div=n1/n2;
			Console.WriteLine("Difference is="+div);
		}
}
class inherit
{
	public static void Main()
	{
		ArthOp obj=new ArthOp();
		obj.add();
		obj.sub();
		ArthOp2 obj=new ArthOp2();
		obj.mul();
		obj.div();
	}
}