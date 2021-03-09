using System;

namespace InheritanceMiniProject
{
    public class ExcavatorModel : InventoryItemModel  // 10. Inheritance
    {
       public void Dig()  // 09. Method
		{
			Console.WriteLine("I am Digging!");  // 11.  message
		}
    }
}
