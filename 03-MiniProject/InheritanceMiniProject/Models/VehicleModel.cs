using System;

namespace InheritanceMiniProject
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentable  // 5. Add Inheritance
													 // 29.  Add Interface IPurchasable  + CTRL + DOT to implement Interface 'Purchase'.
																// 34. Add Interface IRentable + CTRL + DOT to implement Interfaces 'Rent' & 'ReturnRental'
	{

		public decimal DealerFee { get; set; }  // 4. Add property

		public void Purchase()  // 30. Add method created from IPurchasable 29.
		{
			//throw new NotImplementedException();    31. comment or remove
			QuantityInStock -= 1;                  // 32. check quantity
			Console.WriteLine("This vehicle has been purchased");  // 33. add message
		}

		public void Rent() // 35. Add method created from IPurchasable 34.
		{
			// throw new NotImplementedException(); 36.comment or remove
			QuantityInStock -= 1;                               //37. check quantity
			Console.WriteLine("This vehicle has been rented");  //38. add message													    
		}

		public void ReturnRental() // 35. Add method created from IPurchasable 34.
		{
			// throw new NotImplementedException(); 39.comment or remove
			QuantityInStock += 1;                               // 40. check quantity
			Console.WriteLine("This vehicle has been returned");// 41. add message
		}
	}
}
