using System;

namespace InheritanceMiniProject
{
    public class ExcavatorModel : InventoryItemModel, IRentable  // 10. Inheritance ,  
													// 18. Add Interface IRentable + CTRL + DOT to implement Interface 'ReturnRental'
    {
       public void Dig()  // 09. Method
		{
			Console.WriteLine("I am Digging!");  // 11.  message
		}

        public void Rent()  // 16. Add method
		{
			QuantityInStock -= 1;  // 20. check quantity
			Console.WriteLine("This Excavator has been rented.");  // 17. add message
		}

		public void ReturnRental()  // 19. Add method created from IRentable 18.
		{
			//throw new NotImplementedException();  21. Remove or comment
			QuantityInStock += 1;  // 22. check quantity
			Console.WriteLine("This Excavator has been returned.");  // 23. add message
		}
	}
}
