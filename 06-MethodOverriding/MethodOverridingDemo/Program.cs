// Object Oriented Programming - part 2 - Method Overriding

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			PersonModel person = new PersonModel  
			{
				FirstName = "Josh",  
				LastName = "Hortt",  
				Email = "joshhortt@yahoo.com"  
		};

		Console.WriteLine(person);  

			Console.ReadLine();  
		}
	}
}
