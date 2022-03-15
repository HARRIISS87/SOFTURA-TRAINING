using System;
class Tv
{
public static void Main()
{
Console.WriteLine("HOW MANY PACKAGE YOU NEED..?(1,2,3)");
int pack=Convert.ToInt32(Console.ReadLine());
switch(pack)
{
case 2:
{ 
	Console.WriteLine("SELECT THE COMBO PACKAGE(AB,BC,CA)");
	string cpack=Console.ReadLine();
	switch(cpack)
	{
		case "AB":
		Console.WriteLine("PACKAGE A+PACKAGE B=RS.700");
		break;
		case "BC":Console.WriteLine("PACKAGE B+PACKAGE C=RS.800");
		break;
		case "CA":Console.WriteLine("PACKAGE C+PACKAGE A=RS.600");
		break;
	}
	
	}
	break;

case 1:
{
	Console.WriteLine("SELECT THE PACKAGE");
	string pack1=Console.ReadLine();
	switch(pack1)
	{
		case "A":
		Console.WriteLine("PACKAGE A=RS.250");
		break;
		case "B":Console.WriteLine("PACKAGE B=RS.450");
		break;
		case "C":Console.WriteLine("PACKAGE C=RS.350");
		break;
	}

}
break;

case 3:
{
Console.WriteLine("PACKAGE A+ PACKAGE B +PACKAGE C=RS.1050");
}
break;
default:

break;
}
}
}