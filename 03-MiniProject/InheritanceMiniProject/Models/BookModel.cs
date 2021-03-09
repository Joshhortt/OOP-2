using System;

namespace InheritanceMiniProject
{
    public class BookModel : InventoryItemModel, IPurchasable // 3. Add inheritance,
											   // 24.  Add Interface IPurchasable + CTRL + DOT to implement Interface 'Purchase'.
	{
		public int NumberOfPages { get; set; }  // 2. Add property

		public void Purchase()   // 25. Add method created from IPurchasable 24.
		{
			//throw new NotImplementedException();  26. Remove or comment
			QuantityInStock -= 1;  // 27. check quantity
			Console.WriteLine("This book has been purchased.");  // 28. add message
		}
	}
}
