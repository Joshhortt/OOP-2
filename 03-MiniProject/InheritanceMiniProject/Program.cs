// // Object Oriented Programming - part 2 - Mini-Project - Interfaces and Inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<InventoryItemModel> inventory = new List<InventoryItemModel>();   // 6. Add List 
                                                                                     // 44. Comment List created in the beginning

            List<IRentable> rentables = new List<IRentable>();   // 42. Add List
            List<IPurchasable> purchasables = new List<IPurchasable>();   // 43. Add List

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Toyota Carisma" };  // 44. add variable ne Instance
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };  // 45. add variable ne Instance
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };  // 46. add variable ne Instance

            //inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Toyota Carisma" });  // 7. Add a Inventory piece-Vehicle
            //inventory.Add(new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 });  // 8. Add another piece to Inventory-Book
                                                                                                           // 47. Comment or delete 8.

            Console.ReadLine();   // 0. Add
        }
    }
}
