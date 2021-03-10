using System;

namespace InheritanceMiniProject
{
	// Inheritance
	public class BookModel : InventoryItemModel, IPurchasable 
											  
	{
		// property
		public int NumberOfPages { get; set; }  

		// method
		public void Purchase()   
		{
			QuantityInStock -= 1; 
			Console.WriteLine("This book has been purchased.");  
		}
	}
}
