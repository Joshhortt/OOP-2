// Object Oriented Programming - part 2 - Mini-Project - Generics & Events
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEventsWrapUpDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadLine();

		}
	}

	public class PersonModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}

	public class CarModel
	{
		public string Manufacturer { get; set; }
		public string Model { get; set; }
	}
}
