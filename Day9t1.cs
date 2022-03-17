using System;
interface silver
{
	void accom();
}
interface gold
{
	void accom();
	void food();
}
interface platinum
{
	void accom();
	void food();
}
class Silver:silver
{
	public void accom()
	{
		Console.WriteLine("3 days accomodation at Resort");
	}
}
class Gold:gold
{
	public void accom()
	{
		Console.WriteLine("5 days accomodation at Resort");
	}
	public void food()
	{
		Console.WriteLine("2 Dinners on the house");
	}
}
class Platinum:platinum
{
	public void accom()
	{
		Console.WriteLine("7 days accomodation at Resort");
	}
	public void food()
	{
		Console.WriteLine("5 Dinners on the house");
	}
}
class result
{
	public static void Main()
	{
		Silver obj=new Silver();
		obj.accom();
		Gold obj1=new Gold();
		obj1.accom();
		obj1.food();
		Platinum obj2=new Platinum();
		obj2.accom();
		obj2.food();
	}
}