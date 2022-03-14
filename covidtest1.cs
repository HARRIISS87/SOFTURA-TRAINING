using System;
class Covidtest
{
	public static void Main()
	{
		string hist,temp,cough;
		Console.WriteLine("Do you have any travel history for past few days?");
		hist=Console.ReadLine();
		if(hist=="Yes")
		{

			Console.WriteLine("Do you feel warmer always?");
			temp=Console.ReadLine();
		
		if(temp=="Yes")
		{
			Console.WriteLine("Do you Cough/Sneeze offenly?");
			cough=Console.ReadLine();
		
		if(cough=="Yes")
		{
			Console.WriteLine("Must take the Swab test.");
		}
		else
		{
			Console.WriteLine("You have to take medicine and be in home quarantine ");
		}
		}

		else
		{
			Console.WriteLine("Home quarantinefor 28 days");

		}
		}
	
		else
		{
			Console.WriteLine("You are safe..!..NO COVID-19");

		}
		}



	}

