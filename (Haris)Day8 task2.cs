using System;
class VAT
{
	public virtual int calculateTax(int n1)
	{
		int VAT;
		VAT=n1*20/100;
		Console.WriteLine("VAT is="+VAT);
		return VAT;

	}
	
}
class GST:VAT
{
		public override int calculateTax(int n1)
		{
			int GST;
		    GST=n1*12/100;
			Console.WriteLine("GST is="+GST);
			return GST;
		}
		
}
class inherit
{
	public static void Main()
	{
		int n1;
		Console.WriteLine("ENTER THE AMOUNT:");
		n1=Convert.ToInt32(Console.ReadLine());
		
		VAT obj=new VAT();
		obj.calculateTax(n1);
		
		GST obj1=new GST();
		obj1.calculateTax(n1);
		
		
	}
}