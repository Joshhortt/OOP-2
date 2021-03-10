using System;

namespace InheritanceMiniProject
{
	// Inheritance
	public class VehicleModel : InventoryItemModel, IPurchasable, IRentable  
													
	{
		// property
		public decimal DealerFee { get; set; }

		// method
		public void Purchase() 
		{
			QuantityInStock -= 1;                  
			Console.WriteLine("This vehicle has been purchased");  
		}

		// method
		public void Rent()
		{
			QuantityInStock -= 1;                            
			Console.WriteLine("This vehicle has been rented");  												    
		}

		// method
		public void ReturnRental() 
		{
			QuantityInStock += 1;                              
			Console.WriteLine("This vehicle has been returned")
		}
	}
}
