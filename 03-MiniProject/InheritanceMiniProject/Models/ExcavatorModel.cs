using System;

namespace InheritanceMiniProject
{
	// Inheritance
	public class ExcavatorModel : InventoryItemModel, IRentable  
												
    {
		// method
		public void Dig() 
		{
			Console.WriteLine("I am Digging!");  
		}

		// method
		public void Rent()  
		{
			QuantityInStock -= 1;  
			Console.WriteLine("This Excavator has been rented."); 
		}

		// method
		public void ReturnRental()  
		{
		
			QuantityInStock += 1;  
			Console.WriteLine("This Excavator has been returned.");  
		}
	}
}
