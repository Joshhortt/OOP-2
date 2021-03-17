// Object Oriented Programming - part 2 - Mini-Project - Generics & Events
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEventsWrapUpDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// New List Instance people
			List<PersonModel> people = new List<PersonModel>
			{
				// 3 persons
				new PersonModel{FirstName = "Josh", LastName = "Hortt", Email = "joshhortt@yahoo.com"},
				new PersonModel{FirstName = "Ana", LastName = "Horta", Email = "joshhortt@yahoo.com"},
				new PersonModel{FirstName = "Sofia", LastName = "Nasala", Email = "joshhortt@yahoo.com"}
			};

			// New List Instance cars
			List<CarModel> cars = new List<CarModel>
			{
				// 3 cars
				new CarModel{Manufacturer = "Mitsubishi", Model = "Spacestar"},
				new CarModel{Manufacturer = "Mini", Model = "Cooper S"},
				new CarModel{Manufacturer = "VW", Model = "Beetle"}

			};

			people.SaveToCSV(@"C:\Temp\SavedFiles\people.csv"); // saving to file path
			cars.SaveToCSV(@"C:\Temp\SavedFiles\cars.csv");  // saving to file path

			Console.ReadLine();
		}
	}
	public static class DataAccess  // Method
	{
		public static void SaveToCSV<T>(this List<T> items, string filePath) where T : new() // generic 'T' and extension method 'this'.
																							 // Add also parameter string filePath
		{
			List<string> rows = new List<string>();
			T entry = new T();
			var columns = entry.GetType().GetProperties();  // Now I have a list of columns

			string row = "";
			foreach (var col in columns)  // looping trough  the Headers 
			{
				row += $",{ col.Name }";  // adds a coma  between columns
			}
			row = row.Substring(1); //cuts off the first coma right before the first columns name in position '0'. (1) Jumps one start position
			rows.Add(row);                      //FirstName,LastName,Email  -- > How the CSV  row will look like

			foreach (var item in items)  // Looping through the items
			{
				row = "";
				foreach (var col in columns)
				{
					row += $",{ col.GetValue(item, null) }";  
				}
				row = row.Substring(1); 
				rows.Add(row);
			}

			File.WriteAllLines(filePath, rows);  // copying to File CSV
		}

		private static bool BadWordDetector(string stringToTest)  // Method that is going to detect if a bad word is within  a string
		{
			bool output = false;
			string lowerCaseTest = stringToTest.ToLower();
			if(lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("hack"))
			{
			output = true;
			}
			return output;
		}
	}
}

