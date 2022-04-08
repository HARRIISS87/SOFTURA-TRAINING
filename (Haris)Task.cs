using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LINQ
{
	class task2
	{


		public static void Main()
		{
			int Eyes = 52, Legs = 80;

			int count = 0;
			int count2 = 0;

			count = 2 * (Eyes) - (Legs);
			count = count / 2;

			Console.WriteLine("No of Ducks:" + count);

			count2 = 26 - count;
			Console.WriteLine("No of Goats:" + count2);
		}
	}

}
