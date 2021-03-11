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
		
}
