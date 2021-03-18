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
		public event EventHandler<T> BadEntryFound;
		
		public void SaveToCSV(List<T> items, string filePath)   
		{
			List<string> rows = new List<string>();
			T entry = new T();
			var columns = entry.GetType().GetProperties(); 

			string row = "";
			foreach (var col in columns)  
			{
				row += $",{ col.Name }";  
			}
			row = row.Substring(1); 
			rows.Add(row);                      

			foreach (var item in items)  
			{
				row = "";
				bool badWordDetected = false;

				foreach (var col in columns)
				{
					string val = col.GetValue(item, null).ToString();

					badWordDetected = BadWordDetector(val);
					if (BadWordDetector(val) == true)
					{
						BadEntryFound?.Invoke(this, item);  
						break; 
					}

					row += $",{ val }";
				}

				if (badWordDetected == false)  
				{
					row = row.Substring(1);
					rows.Add(row);
				}
			}

			File.WriteAllLines(filePath, rows);  
		}

		private bool BadWordDetector(string stringToTest)  
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

