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
			
			List<PersonModel> people = new List<PersonModel>
			{
				new PersonModel{FirstName = "Josh", LastName = "Horttdarnit", Email = "joshhortt@yahoo.com"},
				new PersonModel{FirstName = "Ana", LastName = "Horta", Email = "joshhortt@yahoo.com"},
				new PersonModel{FirstName = "Sofia", LastName = "Nasala", Email = "joshhortt@yahoo.com"}
			};
			
			List<CarModel> cars = new List<CarModel>
			{
				new CarModel{Manufacturer = "Mitsubishi", Model = "DARNSpacestar"},
				new CarModel{Manufacturer = "Mini", Model = "Cooper S"},
				new CarModel{Manufacturer = "VW", Model = "hackBeetle"}

			};

			DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
			peopleData.BadEntryFound += PeopleData_BadEntryFound;
			peopleData.SaveToCSV(people, @"C:\Temp\SavedFiles\people.csv");

			DataAccess<CarModel> carData = new DataAccess<CarModel>();
			carData.BadEntryFound += CarData_BadEntryFound;
			carData.SaveToCSV(cars, @"C:\Temp\SavedFiles\cars.csv"); 

			Console.ReadLine();
		}

		private static void CarData_BadEntryFound(object sender, CarModel e)
		{
			Console.WriteLine($"Bad entry for {e.Manufacturer} {e.Model} ");
		}

		private static void PeopleData_BadEntryFound(object sender, PersonModel e)
		{
			Console.WriteLine($"Bad entry found for {e.FirstName} {e.LastName} ");
		}
	}

	public class DataAccess<T> where T : new()   
	{
		public event EventHandler<T> BadEntryFound;// Create Event Handler
		
		public void SaveToCSV(List<T> items, string filePath)   
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
				bool badWordDetected = false;

				foreach (var col in columns)
				{
					string val = col.GetValue(item, null).ToString();

					badWordDetected = BadWordDetector(val);
					if (BadWordDetector(val) == true)
					{
						BadEntryFound?.Invoke(this, item);  // Invoke it
						break;  // will break us out of this foreach loop
					}

					row += $",{ val }";
				}

				if (badWordDetected == false)  
				{
					row = row.Substring(1);
					rows.Add(row);
				}
			}

			File.WriteAllLines(filePath, rows);  // copying to File CSV
		}

		private bool BadWordDetector(string stringToTest)  // Method that is going to detect if a bad word is within a string.
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

