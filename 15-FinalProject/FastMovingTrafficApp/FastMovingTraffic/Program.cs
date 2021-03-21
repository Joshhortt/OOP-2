// Object Oriented Programming - part 2 - Final-Project 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMovingTraffic
{
	class Program
	{
		static void Main(string[] args)
		{
			// 4 new highway instances from different constructors, calling Tostring method.
			var highwayOne = new Highway("Super Highway", "Highway", 'S', "Asphalt", 3, false, "Maintainance Company");
			Console.WriteLine(highwayOne + "\n");

			var highwayTwo = new Highway("State Highway", true);
			Console.WriteLine(highwayTwo + "\n");

			var highwayThree = new Highway("Expressway Highway");
			Console.WriteLine(highwayThree + "\n");

			var highwayFour = new Highway("National Highway", 2);
			Console.WriteLine(highwayFour + "\n");

			Console.ReadLine();
		}
	}
}
