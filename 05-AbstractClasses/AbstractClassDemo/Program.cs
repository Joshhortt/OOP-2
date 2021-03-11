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
			Car car = new Car();  // 9. 
			car.NumberOfWheels = 4;  // 10. 
			car.Manufacturer = "Honda";
			Console.ReadLine();  // 1. 

		}
	}

	public abstract class Vehicle  // 2. A vehicle is abstract so you can't instantiate it directly, you have to inherit them from another class..
		{
			public string VIN { get; set; } // 3.
			public string Manufacturer { get; set; }  // 4.
			public string Model { get; set; } // 5.
			public int Year { get; set; } // 6.
	}
	public class Car : Vehicle  // 7.
	{
		public int NumberOfWheels { get; set; } = 4;  // 8.
	}
}

#region First Example

/*
InventoryItem item = new Book();  // 7. You can instantiate like this
item.ProductName = "A Tale of Two Cities";  // 8.   "

//InventoryItem item = new InventoryItem();  // 9. cannot create an instance of the abstract InventoryItem

Console.ReadLine();  // 1.
}
}

public abstract class InventoryItem  // 2. 'abstract class' it's a base class. It's a class that you build upon but it's not very complete by it's own.
{
public string ProductName { get; set; }  // 3.
public int QuantityOnHand { get; set; }  // 4.
}

public class Book : InventoryItem  // 5.
{

}

public class Vehicle : InventoryItem  // 6.
{

}
*/
#endregion
