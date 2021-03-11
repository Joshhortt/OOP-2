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
			PersonModel person = new PersonModel  // 6.
			{
				FirstName = "Josh",  // 7.
				LastName = "Hortt",  // 8.
				Email = "joshhortt@yahoo.com"  // 9.
		};

		Console.WriteLine(person);  // 10.


			Console.ReadLine();  // 1. 
		}
	}
	public class PersonModel  // 2.
	{
		public string FirstName { get; set; }  // 3.
		public string LastName { get; set; }  // 4.
		public string Email{ get; set; }  // 5.

		public override string ToString()  // 11. Add method override
		{
			return base.ToString();  // 12. Add ToString option
		}
	}
}
