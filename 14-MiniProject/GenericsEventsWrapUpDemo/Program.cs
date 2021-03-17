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
			List<PersonModel> people = new List<PersonModel>
			{
				// 3 persons
				new PersonModel{FirstName = "Josh", LastName = "Hortt", Email = "joshhortt@yahoo.com"},
				new PersonModel{FirstName = "Ana", LastName = "Horta", Email = "joshhortt@yahoo.com"},
				new PersonModel{FirstName = "Sofia", LastName = "Nasala", Email = "joshhortt@yahoo.com"}
			};

			List<CarModel> cars = new List<CarModel>
			{

				// 3 cars
				new CarModel{Manufacturer = "Mitsubishi", Model = "Spacestar"},
				new CarModel{Manufacturer = "Mini", Model = "Cooper S"},
				new CarModel{Manufacturer = "VW", Model = "Beetle"}
			};

			Console.ReadLine();

		}
	}
	public static class DataAccess
	{
		public static void SaveToCSW<T>(List<T> items)  // generic 'T' and extension method 'this'
		{

		}
	}
}
