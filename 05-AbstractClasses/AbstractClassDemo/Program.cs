// // Object Oriented Programming - part 2 - Abstract Classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();  
			car.NumberOfWheels = 4;   
			car.Manufacturer = "Honda";
			Console.ReadLine();  
		}
	}

	public abstract class Vehicle 
		{
			public string VIN { get; set; } 
			public string Manufacturer { get; set; } 
			public string Model { get; set; } 
			public int Year { get; set; }
	}
	public class Car : Vehicle 
	{
		public int NumberOfWheels { get; set; } = 4; 
	}
}

#region First Example

/*
InventoryItem item = new Book();  
item.ProductName = "A Tale of Two Cities"; 

//InventoryItem item = new InventoryItem();  

Console.ReadLine();  // 1.
}
}

public abstract class InventoryItem  
public string ProductName { get; set; }  
public int QuantityOnHand { get; set; } 
}

public class Book : InventoryItem .
{

}

public class Vehicle : InventoryItem 
{

}
*/
#endregion
