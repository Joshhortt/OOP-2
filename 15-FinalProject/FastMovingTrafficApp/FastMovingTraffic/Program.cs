// Object Oriented Programming - part 2 - Final-Project 
/*
Created a Highway class that can be used as extra documentation with directions. 
Include data members such as name of highway, type (i.e. Avenue, Blvd., Lane, Intersection, etc.), 
direction (i.e., E, W, N, or S), surface (i.e. blacktop, concrete, composite), 
number of lanes, toll or no toll, and the party that maintains it.
Wrote instance methods that returns the full name of the highway, full name of the highway and whether it is toll or not, 
and full name of the highway and the number of lanes. 
Also included a ToString( ) method that returns all data members with appropriate labels.
Added some constructors to make the class flexible.
*/

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

			Console.WriteLine("***** Fast Moving Traffic Highway Types: *****\n");
			// 4 new highway instances from different constructors, calling Tostring method.
			var highwayOne = new Highway("Super Highway", "Highway", 'S', "Asphalt", 3, false, "Maintainance Company");
			Console.WriteLine(highwayOne + "\n");

			var highwayTwo = new Highway("State Highway", true);
			Console.WriteLine(highwayTwo + "\n");

			var highwayThree = new Highway("Express Highway", false);
			Console.WriteLine(highwayThree + "\n");

			var highwayFour = new Highway("National Highway", 2);
			Console.WriteLine(highwayFour + "\n");

			Console.ReadLine();
		}
	}
}
